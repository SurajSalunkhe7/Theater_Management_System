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
    public partial class frm_Login : Form
    {
        public frm_Login()
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


        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "Suraj" && tb_Password.Text == "123")
            {
                MessageBox.Show("Login Successfully", "Working", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_MDI_Theatre_Management_System MDI = new frm_MDI_Theatre_Management_System();
                MDI.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Enter Valid Username And Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();
        }

        private void tb_Password_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
        }

        //public object tb { get; set; }
    }
}
