using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Theater_Management_System_
{
    public partial class frm_View_Ticket_Purchasing : Form
    {
        public frm_View_Ticket_Purchasing()
        {
            InitializeComponent();
        }

        private void frm_View_Ticket_Purchasing_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theater_Management_System_DBDataSet3.Ticket_Purchasing' table. You can move, or remove it, as needed.
            this.ticket_PurchasingTableAdapter1.Fill(this.theater_Management_System_DBDataSet3.Ticket_Purchasing);
            
       

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            {
                frm_MDI_Theatre_Management_System MDI = new frm_MDI_Theatre_Management_System();
                MDI.Show();
                this.Hide();
            }
        }
    }
}
