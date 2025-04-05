partial class FormSupport
{
    private System.ComponentModel.IContainer components = null;
    private ListView listViewTickets;
    private TextBox txtSearch;
    private ComboBox cmbStatusFilter;
    private ComboBox cmbUserFilter;
    private Button btnUpdateStatus;
    private Button btnAssignTicket;
    private Button btnRefresh;
    private Label lblCurrentUser;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(920, 520);
        this.Controls.Add(this.lblCurrentUser);
        this.Controls.Add(this.btnRefresh);
        this.Controls.Add(this.btnAssignTicket);
        this.Controls.Add(this.btnUpdateStatus);
        this.Controls.Add(this.cmbUserFilter);
        this.Controls.Add(this.cmbStatusFilter);
        this.Controls.Add(this.txtSearch);
        this.Controls.Add(this.listViewTickets);
        this.Name = "FormSupport";
        this.Text = "Техническая поддержка - Обработка заявок";
        this.ResumeLayout(false);
        this.PerformLayout();

        this.listViewTickets = new System.Windows.Forms.ListView();
        this.txtSearch = new System.Windows.Forms.TextBox();
        this.cmbStatusFilter = new System.Windows.Forms.ComboBox();
        this.cmbUserFilter = new System.Windows.Forms.ComboBox();
        this.btnUpdateStatus = new System.Windows.Forms.Button();
        this.btnAssignTicket = new System.Windows.Forms.Button();
        this.btnRefresh = new System.Windows.Forms.Button();
        this.lblCurrentUser = new System.Windows.Forms.Label();
        this.SuspendLayout();
        // 
        // listViewTickets
        // 
        this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            new System.Windows.Forms.ColumnHeader { Text = "Номер" },
            new System.Windows.Forms.ColumnHeader { Text = "Дата" },
            new System.Windows.Forms.ColumnHeader { Text = "Тема" },
            new System.Windows.Forms.ColumnHeader { Text = "Статус" },
            new System.Windows.Forms.ColumnHeader { Text = "Пользователь" },
            new System.Windows.Forms.ColumnHeader { Text = "Содержание" }
        });
        this.listViewTickets.FullRowSelect = true;
        this.listViewTickets.GridLines = true;
        this.listViewTickets.Location = new System.Drawing.Point(10, 100);
        this.listViewTickets.Name = "listViewTickets";
        this.listViewTickets.Size = new System.Drawing.Size(900, 400);
        this.listViewTickets.TabIndex = 0;
        this.listViewTickets.UseCompatibleStateImageBehavior = false;
        this.listViewTickets.View = System.Windows.Forms.View.Details;
        this.listViewTickets.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewTickets_ColumnClick);
        // 
        // txtSearch
        // 
        this.txtSearch.Location = new System.Drawing.Point(10, 70);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new System.Drawing.Size(200, 20);
        this.txtSearch.TabIndex = 1;
        this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
        // 
        // cmbStatusFilter
        // 
        this.cmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbStatusFilter.FormattingEnabled = true;
        this.cmbStatusFilter.Items.AddRange(new object[] {
            "Все",
            "Создана",
            "Назначена",
            "Закрыта"
        });
        this.cmbStatusFilter.Location = new System.Drawing.Point(220, 70);
        this.cmbStatusFilter.Name = "cmbStatusFilter";
        this.cmbStatusFilter.Size = new System.Drawing.Size(121, 21);
        this.cmbStatusFilter.TabIndex = 2;
        this.cmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.cmbStatusFilter_SelectedIndexChanged);
        // 
        // cmbUserFilter
        // 
        this.cmbUserFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cmbUserFilter.FormattingEnabled = true;
        // Populate this combo box with the list of users
        this.cmbUserFilter.Location = new System.Drawing.Point(350, 70);
        this.cmbUserFilter.Name = "cmbUserFilter";
        this.cmbUserFilter.Size = new System.Drawing.Size(121, 21);
        this.cmbUserFilter.TabIndex = 3;
        this.cmbUserFilter.SelectedIndexChanged += new System.EventHandler(this.cmbUserFilter_SelectedIndexChanged);
        // 
        // btnUpdateStatus
        // 
        this.btnUpdateStatus.Location = new System.Drawing.Point(10, 10);
        this.btnUpdateStatus.Name = "btnUpdateStatus";
        this.btnUpdateStatus.Size = new System.Drawing.Size(100, 23);
        this.btnUpdateStatus.TabIndex = 4;
        this.btnUpdateStatus.Text = "Обновить статус";
        this.btnUpdateStatus.UseVisualStyleBackColor = true;
        this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);
        // 
        // btnAssignTicket
        // 
        this.btnAssignTicket.Location = new System.Drawing.Point(120, 10);
        this.btnAssignTicket.Name = "btnAssignTicket";
        this.btnAssignTicket.Size = new System.Drawing.Size(100, 23);
        this.btnAssignTicket.TabIndex = 5;
        this.btnAssignTicket.Text = "Назначить заявку";
        this.btnAssignTicket.UseVisualStyleBackColor = true;
        this.btnAssignTicket.Click += new System.EventHandler(this.btnAssignTicket_Click);
        // 
        // btnRefresh
        // 
        this.btnRefresh.Location = new System.Drawing.Point(230, 10);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new System.Drawing.Size(100, 23);
        this.btnRefresh.TabIndex = 6;
        this.btnRefresh.Text = "Обновить";
        this.btnRefresh.UseVisualStyleBackColor = true;
        this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
        // 
        // lblCurrentUser
        // 
        this.lblCurrentUser.AutoSize = true;
        this.lblCurrentUser.Location = new System.Drawing.Point(350, 15);
        this.lblCurrentUser.Name = "lblCurrentUser";
        this.lblCurrentUser.Size = new System.Drawing.Size(108, 13);
        this.lblCurrentUser.TabIndex = 7;
        this.lblCurrentUser.Text = "Текущий пользователь:";
    }
}