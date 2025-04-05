using System;
using System.Windows.Forms;

namespace OSNOVA_Client
{
    public partial class FormTicketDetails : Form
    {
        private int ticketId;

        public FormTicketDetails(int ticketId)
        {
            InitializeComponent();
            this.ticketId = ticketId;
        }

        // Other methods and logic for managing ticket details
    }
}