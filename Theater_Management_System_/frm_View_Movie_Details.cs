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
    public partial class frm_View_Movie_Details : Form
    {
        public frm_View_Movie_Details()
        {
            InitializeComponent();
        }

        private void frm_View_Movie_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'theater_Management_System_DBDataSet.Add_Movie_Details' table. You can move, or remove it, as needed.
            this.add_Movie_DetailsTableAdapter.Fill(this.theater_Management_System_DBDataSet.Add_Movie_Details);

        }

        private void dgv_View_Movie_Details_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
