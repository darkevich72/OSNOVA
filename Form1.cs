using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.SignalR.Client;
using System.Net.Http.Json;
using System.Collections;

public partial class Form1 : Form
{
    private readonly HttpClient http;
    private List<Ticket> allTickets;
    private HubConnection? hub;
    private bool showingAllTickets = true;
    private TextBox txtEdit;
    private int sortColumn = -1;

    public Form1()
    {
        var handler = new HttpClientHandler { UseDefaultCredentials = true };
        http = new HttpClient(handler);
        http.BaseAddress = new Uri("https://localhost:7179/api/");
        InitializeComponent();
        this.Load += async (s, e) =>
        {
            await LoadTickets();
            await SetupSignalR();
            await CheckUser();
            ShowCurrentUser();
        };
    }

    private async Task LoadTickets()
    {
        allTickets = await http.GetFromJsonAsync<List<Ticket>>("tickets");
        UpdateListView(allTickets);
    }

    private void UpdateListView(List<Ticket> tickets)
    {
        listViewTickets.Items.Clear();
        foreach (var ticket in tickets)
        {
            var item = new ListViewItem(ticket.Id.ToString())
            {
                SubItems =
                {
                    ticket.Date.ToString(),
                    ticket.Topic,
                    ticket.Status,
                    ticket.Service,
                    ticket.Content
                }
            };
            listViewTickets.Items.Add(item);
        }
    }

    private async Task CheckUser()
    {
        var username = Environment.UserName;
        var response = await http.GetAsync($"users/{username}");
        if (!response.IsSuccessStatusCode)
        {
            await http.PostAsJsonAsync("users", new { Username = username, FullName = username, Role = "user" });
        }
    }

    private async Task SetupSignalR()
    {
        hub = new HubConnectionBuilder()
            .WithUrl("https://localhost:7179/ticketHub", options =>
            {
                options.UseDefaultCredentials = true;
            })
            .Build();
        hub.On("TicketUpdated", async () => await Invoke(async () => await LoadTickets()));
        await hub.StartAsync();
    }

    private void ClearFields()
    {
        txtFullName.Text = txtModule.Text = txtDescription.Text = "";
    }

    private async void btnCreate_Click(object sender, EventArgs e)
    {
        string userName = Environment.UserName;
        string domainName = Environment.UserDomainName;
        string fullName = userName;

        using (PrincipalContext context = new PrincipalContext(ContextType.Domain, domainName))
        {
            UserPrincipal user = UserPrincipal.FindByIdentity(context, userName);
            if (user != null)
            {
                fullName = user.DisplayName;
            }
        }

        var ticket = new
        {
            FullName = fullName,
            ModuleName = txtModule.Text,
            Description = txtDescription.Text
        };
        var response = await http.PostAsJsonAsync("tickets", ticket);
        if (response.IsSuccessStatusCode)
        {
            MessageBox.Show("Заявка отправлена на сервер!");
            ClearFields();
            await LoadTickets();
        }
        else
        {
            MessageBox.Show($"Ошибка: {response.StatusCode} - {await response.Content.ReadAsStringAsync()}");
        }
    }

    private async void btnRepeat_Click(object sender, EventArgs e)
    {
        // Логика для повторения заявки
    }

    private async void btnRefresh_Click(object sender, EventArgs e)
    {
        await LoadTickets();
    }

    private async void btnHideClosed_Click(object sender, EventArgs e)
    {
        var filteredTickets = allTickets.Where(t => t.Status != "Закрыта").ToList();
        UpdateListView(filteredTickets);
    }

    private async void btnHideOthers_Click(object sender, EventArgs e)
    {
        var username = Environment.UserName;
        var myTickets = allTickets.Where(t => t.FullName == username).ToList();
        UpdateListView(myTickets);
    }

    private async void btnChangeUserParams_Click(object sender, EventArgs e)
    {
        // Логика для изменения параметров пользователя
    }

    private void txtFilterUserName_TextChanged(object sender, EventArgs e)
    {
        var filteredTickets = allTickets.Where(t => t.FullName.IndexOf(txtFilterUserName.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        UpdateListView(filteredTickets);
    }

    private void txtSearch_TextChanged(object sender, EventArgs e)
    {
        var filteredTickets = allTickets.Where(t => t.Content.IndexOf(txtSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
        UpdateListView(filteredTickets);
    }

    private async void ListViewTickets_AfterLabelEdit(object sender, LabelEditEventArgs e)
    {
        if (e.Label == null) return;

        var item = listViewTickets.Items[e.Item];
        var ticketId = int.Parse(item.Text);
        var newStatus = e.Label;
        var ticket = allTickets.FirstOrDefault(t => t.Id == ticketId);

        if (ticket != null)
        {
            ticket.Status = newStatus;
            var response = await http.PutAsJsonAsync($"tickets/{ticketId}", ticket);
            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show($"Ошибка при обновлении статуса: {response.StatusCode} - {await response.Content.ReadAsStringAsync()}");
                e.CancelEdit = true;
            }
        }
    }

    private void TxtEdit_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            txtEdit.Visible = false;
            listViewTickets.SelectedItems[0].SubItems[4].Text = txtEdit.Text;
            // Сохранение изменений на сервере
            ListViewTickets_AfterLabelEdit(listViewTickets, new LabelEditEventArgs(listViewTickets.SelectedIndices[0], txtEdit.Text));
        }
    }

    private void ShowCurrentUser()
    {
        string userName = Environment.UserName;
        string domainName = Environment.UserDomainName;
        using (PrincipalContext context = new PrincipalContext(ContextType.Domain, domainName))
        {
            UserPrincipal user = UserPrincipal.FindByIdentity(context, userName);
            if (user != null)
            {
                lblCurrentUser.Text = $"Текущий пользователь: {user.DisplayName}";
            }
            else
            {
                lblCurrentUser.Text = "Текущий пользователь не найден.";
            }
        }
    }

    private void listViewTickets_ColumnClick(object sender, ColumnClickEventArgs e)
    {
        // Determine if clicked column is already the column that is being sorted.
        if (e.Column != sortColumn)
        {
            // Set the sort column to the new column.
            sortColumn = e.Column;
            // Set the sort order to ascending by default.
            listViewTickets.Sorting = SortOrder.Ascending;
        }
        else
        {
            // Determine what the last sort order was and change it.
            if (listViewTickets.Sorting == SortOrder.Ascending)
            {
                listViewTickets.Sorting = SortOrder.Descending;
            }
            else
            {
                listViewTickets.Sorting = SortOrder.Ascending;
            }
        }

        // Call the sort method to manually sort.
        listViewTickets.Sort();
        // Set the ListViewItemSorter property to a new ListViewItemComparer object.
        this.listViewTickets.ListViewItemSorter = new ListViewItemComparer(e.Column, listViewTickets.Sorting);
    }

    public class Ticket
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string? FullName { get; set; }
        public string? Topic { get; set; }
        public string? Status { get; set; }
        public string? Service { get; set; }
        public string? Content { get; set; }
    }

    public class User
    {
        public int Id { get; set; } // Добавлено свойство Id
        public string? Username { get; set; }
        public string? FullName { get; set; }
        public string? Role { get; set; }
    }

    // Implements the manual sorting of items by columns.
    public class ListViewItemComparer : IComparer
    {
        private int col;
        private SortOrder order;
        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }
        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }
        public int Compare(object x, object y)
        {
            int returnVal = -1;
            returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,
                                        ((ListViewItem)y).SubItems[col].Text);
            // Determine whether the sort order is descending.
            if (order == SortOrder.Descending)
                // Invert the value returned by String.Compare.
                returnVal *= -1;
            return returnVal;
        }
    }
}