using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace Theater_Management_System_
{
    public partial class frm_Ticket_Purchasing_Report : Form
    {
        public frm_Ticket_Purchasing_Report()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Theater_Management_System_DB;Integrated Security=True");

        private void frm_Ticket_Purchasing_Report_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Customer_ID,Movie_Name,Screen,Seat_Type,Show_Timing,Amount from Ticket_Purchasing",Con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Ticket_Purchasing");
            Ticket_Purchasing_CrystalReport Tpcr = new Ticket_Purchasing_CrystalReport();
            Tpcr.SetDataSource(ds);

            crystalReportViewer1.ReportSource = Tpcr;
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            frm_MDI_Theatre_Management_System MDI = new frm_MDI_Theatre_Management_System();
            MDI.Show();
            this.Hide();
        }
    }
}
