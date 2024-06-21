using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Theater_Management_System_
{
    public partial class frm_Screen_2 : Form
    {
        public frm_Screen_2()
        {
            InitializeComponent();
        }

         public frm_Screen_2(string ID, string M_Name)
        {
            InitializeComponent();
            lbl_Movie_ID.Text = ID;
            lbl_Movie_Name.Text = M_Name;
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
         void Bind_Date()
         {
             SqlCommand Cmd = new SqlCommand();
             Cmd.Connection = Con;
             Cmd.CommandText = "Select Distinct (Movie_ID,Movie_Name,Movie_Image) from Add_Movie_Details";

             var Obj = Cmd.ExecuteReader();
             while (Obj.Read())
             {
                 // tb_M_ID.Text
             }

             Obj.Dispose();
             Con_Close();
         }

        private void frm_Screen_2_Load(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select * from Add_Movie_Details where Status = 'On' and Screen = '2' ", Con);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            DA.Fill(ds);
            var obj = cmd.ExecuteReader();
            if (obj.Read())
            {
                tb_M_ID.Text = obj["Movie_ID"].ToString();
                tb_M_Name.Text = obj["Movie_Name"].ToString();
            }

            if(ds.Tables[0].Rows.Count>0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["Movie_Image"]);
                pb_Photograph.Image = Image.FromStream(ms);
            }
            Con.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                frm_MDI_Theatre_Management_System MDI = new frm_MDI_Theatre_Management_System();
                MDI.Show();
                this.Hide();
            }
        }
    }
}
