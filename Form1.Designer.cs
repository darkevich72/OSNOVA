partial class Form1
{
    private System.ComponentModel.IContainer components = null;
    private ListView listViewTickets;
    private TextBox txtFilterUserName;
    private Label lblCurrentUser;
    private Button btnCreate;
    private Button btnRepeat;
    private Button btnRefresh;
    private Button btnHideClosed;
    private Button btnHideOthers;
    private Button btnChangeUserParams;
    private TextBox txtSearch;

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
        this.listViewTickets = new System.Windows.Forms.ListView();
        this.txtFilterUserName = new System.Windows.Forms.TextBox();
        this.lblCurrentUser = new System.Windows.Forms.Label();
        this.btnCreate = new System.Windows.Forms.Button();
        this.btnRepeat = new System.Windows.Forms.Button();
        this.btnRefresh = new System.Windows.Forms.Button();
        this.btnHideClosed = new System.Windows.Forms.Button();
        this.btnHideOthers = new System.Windows.Forms.Button();
        this.btnChangeUserParams = new System.Windows.Forms.Button();
        this.txtSearch = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // listViewTickets
        // 
        this.listViewTickets.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            new System.Windows.Forms.ColumnHeader { Text = "Номер" },
            new System.Windows.Forms.ColumnHeader { Text = "Дата" },
            new System.Windows.Forms.ColumnHeader { Text = "Тема" },
            new System.Windows.Forms.ColumnHeader { Text = "Статус" },
            new System.Windows.Forms.ColumnHeader { Text = "Услуга" },
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
        // txtFilterUserName
        // 
        this.txtFilterUserName.Location = new System.Drawing.Point(10, 70);
        this.txtFilterUserName.Name = "txtFilterUserName";
        this.txtFilterUserName.Size = new System.Drawing.Size(200, 20);
        this.txtFilterUserName.TabIndex = 1;
        this.txtFilterUserName.TextChanged += new System.EventHandler(this.txtFilterUserName_TextChanged);
        // 
        // lblCurrentUser
        // 
        this.lblCurrentUser.AutoSize = true;
        this.lblCurrentUser.Location = new System.Drawing.Point(10, 40);
        this.lblCurrentUser.Name = "lblCurrentUser";
        this.lblCurrentUser.Size = new System.Drawing.Size(108, 13);
        this.lblCurrentUser.TabIndex = 2;
        this.lblCurrentUser.Text = "Текущий пользователь:";
        // 
        // btnCreate
        // 
        this.btnCreate.Location = new System.Drawing.Point(10, 10);
        this.btnCreate.Name = "btnCreate";
        this.btnCreate.Size = new System.Drawing.Size(100, 23);
        this.btnCreate.TabIndex = 3;
        this.btnCreate.Text = "Создать";
        this.btnCreate.UseVisualStyleBackColor = true;
        this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
        // 
        // btnRepeat
        // 
        this.btnRepeat.Location = new System.Drawing.Point(120, 10);
        this.btnRepeat.Name = "btnRepeat";
        this.btnRepeat.Size = new System.Drawing.Size(100, 23);
        this.btnRepeat.TabIndex = 4;
        this.btnRepeat.Text = "Повторить";
        this.btnRepeat.UseVisualStyleBackColor = true;
        this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click);
        // 
        // btnRefresh
        // 
        this.btnRefresh.Location = new System.Drawing.Point(230, 10);
        this.btnRefresh.Name = "btnRefresh";
        this.btnRefresh.Size = new System.Drawing.Size(100, 23);
        this.btnRefresh.TabIndex = 5;
        this.btnRefresh.Text = "Обновить";
        this.btnRefresh.UseVisualStyleBackColor = true;
        this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
        // 
        // btnHideClosed
        // 
        this.btnHideClosed.Location = new System.Drawing.Point(340, 10);
        this.btnHideClosed.Name = "btnHideClosed";
        this.btnHideClosed.Size = new System.Drawing.Size(150, 23);
        this.btnHideClosed.TabIndex = 6;
        this.btnHideClosed.Text = "Скрыть закрытые заявки";
        this.btnHideClosed.UseVisualStyleBackColor = true;
        this.btnHideClosed.Click += new System.EventHandler(this.btnHideClosed_Click);
        // 
        // btnHideOthers
        // 
        this.btnHideOthers.Location = new System.Drawing.Point(500, 10);
        this.btnHideOthers.Name = "btnHideOthers";
        this.btnHideOthers.Size = new System.Drawing.Size(200, 23);
        this.btnHideOthers.TabIndex = 7;
        this.btnHideOthers.Text = "Скрыть заявки других пользователей";
        this.btnHideOthers.UseVisualStyleBackColor = true;
        this.btnHideOthers.Click += new System.EventHandler(this.btnHideOthers_Click);
        // 
        // btnChangeUserParams
        // 
        this.btnChangeUserParams.Location = new System.Drawing.Point(710, 10);
        this.btnChangeUserParams.Name = "btnChangeUserParams";
        this.btnChangeUserParams.Size = new System.Drawing.Size(180, 23);
        this.btnChangeUserParams.TabIndex = 8;
        this.btnChangeUserParams.Text = "Изменить параметры пользователя";
        this.btnChangeUserParams.UseVisualStyleBackColor = true;
        this.btnChangeUserParams.Click += new System.EventHandler(this.btnChangeUserParams_Click);
        // 
        // txtSearch
        // 
        this.txtSearch.Location = new System.Drawing.Point(710, 70);
        this.txtSearch.Name = "txtSearch";
        this.txtSearch.Size = new System.Drawing.Size(200, 20);
        this.txtSearch.TabIndex = 9;
        this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(920, 520);
        this.Controls.Add(this.txtSearch);
        this.Controls.Add(this.btnChangeUserParams);
        this.Controls.Add(this.btnHideOthers);
        this.Controls.Add(this.btnHideClosed);
        this.Controls.Add(this.btnRefresh);
        this.Controls.Add(this.btnRepeat);
        this.Controls.Add(this.btnCreate);
        this.Controls.Add(this.lblCurrentUser);
        this.Controls.Add(this.txtFilterUserName);
        this.Controls.Add(this.listViewTickets);
        this.Name = "Form1";
        this.Text = "Мои заявки";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}