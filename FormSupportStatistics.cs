using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OSNOVA_Client
{
    public partial class FormSupportStatistics : Form
    {
        private readonly HttpClient http;
        private System.ComponentModel.IContainer components = null;

        public FormSupportStatistics()
        {
            var handler = new HttpClientHandler { UseDefaultCredentials = true };
            http = new HttpClient(handler);
            http.BaseAddress = new Uri("https://localhost:7179/api/");
            InitializeComponent();
        }

        private async void btnLoadStatistics_Click(object sender, EventArgs e)
        {
            var fromDate = dateTimePickerFrom.Value;
            var toDate = dateTimePickerTo.Value;

            var statistics = await http.GetFromJsonAsync<TicketStatistics>($"tickets/statistics?from={fromDate:yyyy-MM-dd}&to={toDate:yyyy-MM-dd}");

            if (statistics != null)
            {
                LoadCharts(statistics);
                LoadDataGrid(statistics);
            }
        }

        private void LoadCharts(TicketStatistics statistics)
        {
            chartTicketsStatus.Series.Clear();
            chartTicketsByUser.Series.Clear();

            var statusSeries = new Series("Статусы заявок")
            {
                ChartType = SeriesChartType.Pie
            };

            statusSeries.Points.AddXY("Создана", statistics.Created);
            statusSeries.Points.AddXY("Назначена", statistics.Assigned);
            statusSeries.Points.AddXY("Закрыта", statistics.Closed);

            chartTicketsStatus.Series.Add(statusSeries);

            var userSeries = new Series("Заявки по пользователям")
            {
                ChartType = SeriesChartType.Bar
            };

            foreach (var user in statistics.TicketsByUser)
            {
                userSeries.Points.AddXY(user.Key, user.Value);
            }

            chartTicketsByUser.Series.Add(userSeries);
        }

        private void LoadDataGrid(TicketStatistics statistics)
        {
            dataGridViewTickets.DataSource = statistics.TicketDetails;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    public class TicketStatistics
    {
        public int Created { get; set; }
        public int Assigned { get; set; }
        public int Closed { get; set; }
        public Dictionary<string, int> TicketsByUser { get; set; }
        public List<TicketDetail> TicketDetails { get; set; }
    }

    public class TicketDetail
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string FullName { get; set; }
        public string Topic { get; set; }
        public string Status { get; set; }
        public string Service { get; set; }
        public string Content { get; set; }
    }
}