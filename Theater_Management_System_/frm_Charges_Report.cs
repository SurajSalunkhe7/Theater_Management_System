using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace Theater_Management_System_
{
    public partial class frm_Charges_Report : Form
    {
        public frm_Charges_Report()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Theater_Management_System_DB;Integrated Security=True");

        void Con_Open()
        {
            if (Con.State == ConnectionState.Closed)
            {
                Con.Open();
            }
        }

        void Con_Close()
        {
            if (Con.State == ConnectionState.Open)
            {
                Con.Close();
            }
        }

        private void frm_Charges_Report_Load(object sender, EventArgs e)
        {
            string sqlStr = "select * From Add_Movie_Charges";
            SqlDataAdapter DA = new SqlDataAdapter(sqlStr,Con);
            DataSet DS = new DataSet();
            DA.Fill(DS, "Add_Movie_Charges");
            Charges_CrystalReport CR = new Charges_CrystalReport();
            CR.SetDataSource(DS);
            crystalReportViewer1.ReportSource = CR;
        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            {
                frm_MDI_Theatre_Management_System MDI = new frm_MDI_Theatre_Management_System();
                MDI.Show();
                this.Hide();
            }
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
