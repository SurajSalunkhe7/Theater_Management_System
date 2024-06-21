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
    public partial class frm_Update : Form
    {
        public frm_Update()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            cmb_Language.Text = "";
            cmb_Screen.Text = "";
            tb_Movie_Name.Clear();
            tb_Movie_ID.Clear();
            cb_12_pm.Checked = false;
            cb_3_pm.Checked = false;
            cb_6_pm.Checked = false;
            cb_9_pm.Checked = false;
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
         void Bind_Brand_Name_To_Combox()
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Distinct(Movie_Name) from Add_Movie_Details where Status = '" + 1 + "'";

            var Obj = Cmd.ExecuteReader();

            while (Obj.Read())
            {
                cmb_Screen.Items.Add(Obj.GetString(Obj.GetOrdinal("Movie_Name")));
            }

            Obj.Dispose();

            Con_Close();
        }

        private void pb_Back_Click(object sender, EventArgs e)
        {
            DialogResult RES = MessageBox.Show("Go to Back", "Are You Sure??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (RES == DialogResult.Yes)
            {
                frm_MDI_Theatre_Management_System MDI = new frm_MDI_Theatre_Management_System();
                MDI.Show();
                this.Hide();
            }
   
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
               Con_Open();

              string ShowT = "",st = "";

              if (tb_Movie_ID.Text != "" && tb_Movie_Name.Text != "" && cmb_Screen.Text != "" && cmb_Language.Text != "" && (cb_12_pm.Checked || cb_3_pm.Checked || cb_6_pm.Checked || cb_9_pm.Checked))
              {

                  if (cb_12_pm.Checked)
                  {
                      ShowT = "12PM";
                  }
                  else if ( cb_3_pm.Checked)
                  {                                
                      ShowT = "3PM";
                  }
                  else if (cb_6_pm.Checked)
                  {
                      ShowT = "6PM";
                  }
                  else if ( cb_9_pm.Checked)
                  {
                      ShowT = "9PM";
                  }

                  if (rb_On.Checked)
                  {
                      st = "On";
                  }
                  else if (rb_Off.Checked)
                  {
                      st = "Off";
                  }

                  SqlCommand Cmd = new SqlCommand();

                  Cmd.Connection = Con;

                  Cmd.CommandText = "Update Add_Movie_Details Set Screen = @Sc, Show_Timing = @ShowTime, Language = @Lang , Status = @status Where Movie_ID = " + tb_Movie_ID.Text + " ";
                  Cmd.Parameters.Add("SC", SqlDbType.NVarChar).Value = cmb_Screen.Text;
                  Cmd.Parameters.Add("ShowTime", SqlDbType.NVarChar).Value = ShowT;
                  Cmd.Parameters.Add("Lang", SqlDbType.VarChar).Value = cmb_Language.Text;
                  Cmd.Parameters.Add("status", SqlDbType.NVarChar).Value = st;

                  Cmd.ExecuteNonQuery();

                  MessageBox.Show("Movie Details Updated Successfully!!!", "Saving", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  Clear_Controls();

                  
              }
              else 
              {
                  MessageBox.Show("Incomplete Information !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              }
              Con_Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if(tb_Movie_ID.Text != "")
            {
                string ShowT,Status;

                Con_Open();

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select * from Add_Movie_Details Where Movie_ID = " + tb_Movie_ID.Text + "";

                SqlDataReader MU = Cmd.ExecuteReader();

                if (MU.Read())
                {
                    tb_Movie_Name.Text = MU.GetString(MU.GetOrdinal("Movie_Name"));
                    cmb_Language.Text = MU.GetString(MU.GetOrdinal("Language"));
                    cmb_Screen.Text = MU.GetString(MU.GetOrdinal("Screen"));
                    ShowT = MU["Show_Timing"].ToString();
                    Status = MU.GetString(MU.GetOrdinal("Status"));

                    if ( ShowT == "12PM")
                    {
                        cb_12_pm.Checked = true;
                    }
                    else if (ShowT == "3PM")
                    {
                        cb_3_pm.Checked = true;
                    }
                    else if (ShowT == "6PM")
                    {
                        cb_6_pm.Checked = true;
                    }
                    else if (ShowT == "9PM")
                    {
                        cb_9_pm.Checked = true;
                    }

                    if (Status == "On")
                    {
                        rb_On.Select();
                    }
                    else
                    {
                        rb_Off.Select();
                    }
                   
                }

                else
                {
                    MessageBox.Show("Movie Record Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Movie_ID.Focus();
                }

                Con_Close();
            }
        }

        public string Show_Time { get; set; }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void pb_Back_Click_1(object sender, EventArgs e)
        {
            {
                frm_MDI_Theatre_Management_System MDI = new frm_MDI_Theatre_Management_System();
                MDI.Show();
                this.Hide();
            }
        }

        private void Is_Numbric(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

    }
}
