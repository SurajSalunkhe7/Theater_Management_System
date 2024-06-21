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
    public partial class frm_Charges : Form
    {
        public frm_Charges()
        {
            InitializeComponent();
        }
        public frm_Charges(string ID, string M_Name)
        {
            InitializeComponent();
            tb_Movie_ID.Text = ID;
            tb_Movie_Name.Text = M_Name;
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

        void Clear_Control()
        {
            tb_Movie_ID.Clear();
            tb_Movie_Name.Clear();
            tb_Balcony.Clear();
            tb_Delux.Clear();
            tb_Stall.Clear();

            tb_Balcony.Focus();
        }

        //void Bind_TextBox()
        //{
        //    Con_Open();

        //    SqlCommand Cmd = new SqlCommand();

        //    Cmd.Connection = Con;

        //    Cmd.CommandText = "Select Movie_ID from Add_Movie_Details";

        //    var Obj = Cmd.ExecuteReader();

        //    while (Obj.Read())
        //    {
        //        tb_Movie_ID.Text = (Obj["Movie_ID"].ToString());
        //    }
        //    Cmd.Dispose();
        //    Obj.Dispose();
        //    Con_Close();
        //}
        private void frm_Charges_Load(object sender, EventArgs e)
        {
            //Clear_Control();
            //Bind_TextBox();

        }

        private void tb_Movie_ID_TextChanged(object sender, EventArgs e)
        {
            //Con_Open();

            //tb_Movie_Name.Clear();

            //SqlCommand Cmd1 = new SqlCommand();

            //Cmd1.Connection = Con;

            //Cmd1.CommandText = "Select Distinct(Movie_Name) from Add_Movie_Details Where Movie_ID = '" + tb_Movie_ID.Text + "'";

            //var obj1 = Cmd1.ExecuteReader();
            
            //while (obj1.Read())
            //{
            //    tb_Movie_Name.Text = obj1.GetString(obj1.GetOrdinal("Movie_Name"));
            //}

            //obj1.Dispose();
            //Con_Close();
       }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (tb_Balcony.Text != "" && tb_Delux.Text != "" && tb_Stall.Text != "")
            {
                Con_Open();
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;

                Cmd.CommandText = "Insert Into Add_Movie_Charges(Movie_ID,Movie_Name,Balcony,Delux,Stall)Values(@Movie_ID,@Movie_Name,@Balcony,@Delux,@Stall)";

                Cmd.Parameters.Add("Movie_ID", SqlDbType.Int).Value = tb_Movie_ID.Text;
                Cmd.Parameters.Add("Movie_Name", SqlDbType.NVarChar).Value = tb_Movie_Name.Text;
                Cmd.Parameters.Add("Balcony", SqlDbType.Float).Value = tb_Balcony.Text;
                Cmd.Parameters.Add("Delux", SqlDbType.Float).Value = tb_Delux.Text;
                Cmd.Parameters.Add("Stall", SqlDbType.Float).Value = tb_Stall.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Charges Added Succsessfuly", "Succsess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
            }
            else 
            {
                MessageBox.Show("Enter All Details","Fail",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Mumeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void pcb_Logout_Click(object sender, EventArgs e)
        {
            {
                frm_MDI_Theatre_Management_System MDI = new frm_MDI_Theatre_Management_System();
                MDI.Show();
                this.Hide();
            }
        }

        }
    }
