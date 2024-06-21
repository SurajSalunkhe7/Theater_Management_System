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
    public partial class frm_Movie_Details_Report : Form
    {
        public frm_Movie_Details_Report()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Theater_Management_System_DB;Integrated Security=True");

        private void frm_Movie_Details_Report_Load(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("Select Movie_ID,Movie_Name,Show_Timing,Cast,Screen,Language from Add_Movie_Details", Con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Add_Movie_Details");
            Movie_CrystalReport cr = new Movie_CrystalReport();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            frm_MDI_Theatre_Management_System MDI = new frm_MDI_Theatre_Management_System();
            MDI.Show();
            this.Hide();
        }
    }
}
