using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Theater_Management_System_
{
    public partial class frm_Add_Movie_Details : Form
    {
        public frm_Add_Movie_Details()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=Theater_Management_System_DB;Integrated Security=True");
        string Imagelocation = "";
        string status = "";

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
            tb_Movie_ID.Text = Convert.ToString(Auto_Increment());
            tb_Movie_Name.Clear();
            cb_12_pm.Checked = false;
            cb_3_pm.Checked = false;
            cb_6_pm.Checked = false;
            cb_9_pm.Checked = false;
            tb_Cast.Clear();
            pb_Photograph.Image = null;
            cmb_Screen.Text = "";
            dtp_Rele_Date.Text = "";
            cmb_Language.Text = "";
            tb_Description.Clear();

            tb_Movie_Name.Focus();
        }

        int Auto_Increment()
        {
            Con_Open();

            int cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Add_Movie_Details";
            cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            

            if (cnt > 0)
            {
                Cmd.Dispose();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Movie_ID) From Add_Movie_Details";
                cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                cnt = 101;
            }
            Cmd.Dispose();
            return cnt;
        }

        private void pcb_Logout_Click(object sender, EventArgs e)
        {
            {
                frm_MDI_Theatre_Management_System MDI = new frm_MDI_Theatre_Management_System();
                MDI.Show();
                this.Hide();
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string Show_Timing;

            //string Status;
            if(rb_On.Checked == true)
            {
                status = rb_On.Text;
            }
            else
            {
                status = rb_Off.Text;
            }

            if (rb_On.Checked == true && tb_Movie_Name.Text != "" && tb_Cast.Text != "" && cmb_Screen.Text != "" && dtp_Rele_Date.Text != "" && cmb_Language.Text != "" && tb_Description.Text != "" && pb_Photograph.Image != null && (cb_12_pm.Checked || cb_3_pm.Checked || cb_6_pm.Checked || cb_9_pm.Checked))
            {
                Con_Open();




                SqlCommand Cmd1 = new SqlCommand();
                Cmd1.Connection = Con;
                Cmd1.CommandText = "select * from Add_Movie_Details where Screen= '" + cmb_Screen.Text + "' and Status= 'On'";

                var obj = Cmd1.ExecuteReader();
              
                if (obj.Read())
                {
                    MessageBox.Show("Movie Already Running On Screen '" + cmb_Screen.Text + "'", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // string screen = obj["Screen"].ToString();
                    // string  Status = obj["Status"].ToString();
                }
                      
                else
                {
                    Con_Close();
                    if (cb_12_pm.Checked == true)
                    {
                        Show_Timing = "12PM";
                    }
                    else if (cb_3_pm.Checked == true)
                    {
                        Show_Timing = "3PM";
                    }
                    else if (cb_6_pm.Checked == true)
                    {
                        Show_Timing = "6PM";
                    }
                    else
                    {
                        Show_Timing = "9PM";
                    }


                    /*if (rb_On.Checked == true)
                    {
                        Status = "On";
                    }*/
                    SqlCommand Cmd = new SqlCommand();

                    Cmd.Connection = Con;
                    Con_Open();
                    Cmd.CommandText = "Insert into Add_Movie_Details(Movie_ID,Movie_Name,Show_Timing,Cast,Screen,Rele_Date,Language,Description,Movie_Image,Status)values(@M_ID,@Movie_Name,@Show_Timing,@Cast,@Screen,@Date,@Language,@Discription,@Movie_Image,@status)";
                    Cmd.Parameters.Add("M_ID", SqlDbType.Int).Value = tb_Movie_ID.Text;
                    Cmd.Parameters.Add("Movie_Name", SqlDbType.NVarChar).Value = tb_Movie_Name.Text;
                    Cmd.Parameters.Add("Show_Timing", SqlDbType.NVarChar).Value = Show_Timing;
                    Cmd.Parameters.Add("Cast", SqlDbType.VarChar).Value = tb_Cast.Text;
                    Cmd.Parameters.Add("Screen", SqlDbType.NVarChar).Value = cmb_Screen.Text;
                    Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Rele_Date.Text;
                    Cmd.Parameters.Add("Language", SqlDbType.VarChar).Value = cmb_Language.Text;
                    Cmd.Parameters.Add("Discription", SqlDbType.NVarChar).Value = tb_Description.Text;
                    Cmd.Parameters.Add("status", SqlDbType.VarChar).Value = status;
                    //Cmd.Parameters.Add("Status", SqlDbType.NVarChar).Value = Status;

                    ImageConverter IC = new ImageConverter();
                    byte[] imaArray = (byte[])IC.ConvertTo(pb_Photograph.Image, typeof(byte[]));

                    Cmd.Parameters.Add("Movie_Image", SqlDbType.Image).Value = imaArray;

                    Cmd.ExecuteNonQuery();

                    MessageBox.Show("Movie Added Succesfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Con_Close();

                    frm_Charges FC = new frm_Charges(tb_Movie_ID.Text, tb_Movie_Name.Text);
                    FC.Show();
                    this.Hide();
                    Clear_Control();
                }
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frm_Add_Movie_Details_Load(object sender, EventArgs e)
        {
            tb_Movie_ID.Text = Convert.ToString(Auto_Increment());
            DateTime DT = DateTime.Now;
            this.dtp_Rele_Date.Text = DT.ToString();
        }

        private void btn_Upload_Click(object sender, EventArgs e)
        {
            
                //lbl_Photograph.Visible = false;
                //lbl_size.Visible = false;

                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All Files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Imagelocation = dialog.FileName.ToString();
                    pb_Photograph.ImageLocation = Imagelocation;
                }
            }
            
        
    }
}
