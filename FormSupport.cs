namespace OSNOVA_Client
{
    using System;
    using System.Windows.Forms;

    public partial class FormSupport : Form
    {
        private System.ComponentModel.IContainer components = null;

        public FormSupport()
        {
            InitializeComponent();
        }

        private async void listViewTickets_DoubleClick(object sender, EventArgs e)
        {
            if (listViewTickets.SelectedItems.Count > 0)
            {
                var item = listViewTickets.SelectedItems[0];
                var ticketId = int.Parse(item.Text);
                var formTicketDetails = new FormTicketDetails(ticketId);
                formTicketDetails.ShowDialog();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void btnAssignTicket_Click(object sender, EventArgs e)
        {
            // ������ ���������� ������
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // ������ ���������� ������
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            // ������ ���������� �������
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ������ ���������� �� �������
        }

        private void cmbUserFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ������ ���������� �� ������������
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // ������ ���������� �� ������ ������
        }

        private void listViewTickets_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // ������ ���������� �� �������
        }
    }
}