partial class FormSupportStatistics
{
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartTicketsStatus;
    private System.Windows.Forms.DataVisualization.Charting.Chart chartTicketsByUser;
    private System.Windows.Forms.DataGridView dataGridViewTickets;
    private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
    private System.Windows.Forms.DateTimePicker dateTimePickerTo;
    private System.Windows.Forms.Button btnLoadStatistics;

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
        this.ClientSize = new System.Drawing.Size(784, 661);
        this.Controls.Add(this.btnLoadStatistics);
        this.Controls.Add(this.dateTimePickerTo);
        this.Controls.Add(this.dateTimePickerFrom);
        this.Controls.Add(this.dataGridViewTickets);
        this.Controls.Add(this.chartTicketsByUser);
        this.Controls.Add(this.chartTicketsStatus);
        this.Name = "FormSupportStatistics";
        this.Text = "Статистика заявок";
        this.ResumeLayout(false);

        this.chartTicketsStatus = new System.Windows.Forms.DataVisualization.Charting.Chart();
        this.chartTicketsByUser = new System.Windows.Forms.DataVisualization.Charting.Chart();
        this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
        this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
        this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
        this.btnLoadStatistics = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.chartTicketsStatus)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.chartTicketsByUser)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
        this.SuspendLayout();
        // 
        // chartTicketsStatus
        // 
        this.chartTicketsStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        this.chartTicketsStatus.Location = new System.Drawing.Point(12, 12);
        this.chartTicketsStatus.Name = "chartTicketsStatus";
        this.chartTicketsStatus.Size = new System.Drawing.Size(760, 200);
        this.chartTicketsStatus.TabIndex = 0;
        this.chartTicketsStatus.Text = "chart1";
        // 
        // chartTicketsByUser
        // 
        this.chartTicketsByUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        this.chartTicketsByUser.Location = new System.Drawing.Point(12, 218);
        this.chartTicketsByUser.Name = "chartTicketsByUser";
        this.chartTicketsByUser.Size = new System.Drawing.Size(760, 200);
        this.chartTicketsByUser.TabIndex = 1;
        this.chartTicketsByUser.Text = "chart2";
        // 
        // dataGridViewTickets
        // 
        this.dataGridViewTickets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
        this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridViewTickets.Location = new System.Drawing.Point(12, 424);
        this.dataGridViewTickets.Name = "dataGridViewTickets";
        this.dataGridViewTickets.Size = new System.Drawing.Size(760, 200);
        this.dataGridViewTickets.TabIndex = 2;
        // 
        // dateTimePickerFrom
        // 
        this.dateTimePickerFrom.Location = new System.Drawing.Point(12, 630);
        this.dateTimePickerFrom.Name = "dateTimePickerFrom";
        this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
        this.dateTimePickerFrom.TabIndex = 3;
        // 
        // dateTimePickerTo
        // 
        this.dateTimePickerTo.Location = new System.Drawing.Point(218, 630);
        this.dateTimePickerTo.Name = "dateTimePickerTo";
        this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
        this.dateTimePickerTo.TabIndex = 4;
        // 
        // btnLoadStatistics
        // 
        this.btnLoadStatistics.Location = new System.Drawing.Point(424, 630);
        this.btnLoadStatistics.Name = "btnLoadStatistics";
        this.btnLoadStatistics.Size = new System.Drawing.Size(75, 23);
        this.btnLoadStatistics.TabIndex = 5;
        this.btnLoadStatistics.Text = "Загрузить";
        this.btnLoadStatistics.UseVisualStyleBackColor = true;
        this.btnLoadStatistics.Click += new System.EventHandler(this.btnLoadStatistics_Click);
    }
}