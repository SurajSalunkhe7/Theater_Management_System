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
    public partial class frm_Ticket_Purchasing : Form
    {
        public frm_Ticket_Purchasing()
        {
            InitializeComponent();
        }

        int gBalcony = 0;
        int gDelux = 0;
        int gStall = 0;

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
            tb_Customer_ID.Text = Convert.ToString(Auto_Increment());
            cmb_Movie_Name.Text = "";
            tb_Quantity.Clear();
            dtp_Date.Text = "";
            tb_Amount.Clear();

            tb_Customer_ID.Focus();
        }

        int Auto_Increment()
        {
            Con_Open();

            int cnt = 0;

            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*) From Ticket_Purchasing";
            cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            Cmd.Dispose();
            Con_Close();
            if (cnt > 0)
            {
                Con_Open();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Max(Customer_ID) From Ticket_Purchasing";
                cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
                Cmd.Dispose();
                Con_Close();
            }
            else
            {
                cnt = 101;
            }

            return cnt;
         
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //string Show_Timing;
            if (cmb_Movie_Name.Text != "" && cmb_Screen.Text != "" && tb_Quantity.Text != "" && dtp_Date.Text != "" && tb_Amount.Text != "" )
            {
                Con_Open();

                SqlCommand Cmd = new SqlCommand();

                Cmd.Connection = Con;
                Cmd.CommandText = "Insert into Ticket_Purchasing values(@ID,@Movie_Name,@Screen,@Seat_Type,@Seat_Frm,@Seat_To,@Quantity,@Date,@Show_Timing,@Amount)";
                Cmd.Parameters.Add("ID", SqlDbType.Int).Value = tb_Customer_ID.Text;
                Cmd.Parameters.Add("Movie_Name", SqlDbType.NVarChar).Value = cmb_Movie_Name.Text;
                Cmd.Parameters.Add("Screen", SqlDbType.Int).Value = cmb_Screen.Text;
                Cmd.Parameters.Add("Seat_Type", SqlDbType.NVarChar).Value = cmb_Seat_Types.Text;
                Cmd.Parameters.Add("Seat_Frm", SqlDbType.Int).Value = tb_From.Text;
                Cmd.Parameters.Add("Seat_To", SqlDbType.Int).Value = tb_To.Text;
                Cmd.Parameters.Add("Quantity", SqlDbType.Int).Value = tb_Quantity.Text;
                Cmd.Parameters.Add("Date", SqlDbType.Date).Value = dtp_Date.Text;
                Cmd.Parameters.Add("Show_Timing", SqlDbType.NVarChar).Value = cmb_Show_Timing.Text;
                Cmd.Parameters.Add("Amount", SqlDbType.Money).Value = tb_Amount.Text;

                Cmd.ExecuteNonQuery();

                MessageBox.Show("Ticket Added Succesfully...", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Control();
                Con_Close();
            }
            else
            {
                MessageBox.Show("Incomplete Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void Bind_ComboBox()
        {
            Con_Open();

            cmb_Movie_Name.Items.Clear();

            SqlCommand Cmd = new SqlCommand("Select Distinct(Movie_Name) From Add_Movie_Details where Status = 'On'", Con);

            var obj = Cmd.ExecuteReader();
           
            while (obj.Read())
            {
                cmb_Movie_Name.Items.Add(obj.GetString(obj.GetOrdinal("Movie_Name")));
            }
            Cmd.Dispose();
            Con_Close();
        }

        private void frm_Ticket_Purchasing_Load(object sender, EventArgs e)
        {
            tb_Customer_ID.Text = Convert.ToString(Auto_Increment());
            DateTime DT = DateTime.Now;
            this.dtp_Date.Text = DT.ToString();
            Bind_ComboBox();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
                frm_MDI_Theatre_Management_System MDI = new frm_MDI_Theatre_Management_System();
                MDI.Show();
                this.Hide();
        }

        private void cmb_Movie_Name_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            Cmd.CommandText = "Select Screen from Add_Movie_Details where Movie_Name ='" + cmb_Movie_Name.Text + "'";
             
            var Obj = Cmd.ExecuteReader();

            if(Obj.Read())
            {
                cmb_Screen.Text = Obj.GetString(Obj.GetOrdinal("Screen")); 
            }
         
            Cmd.Dispose();
            Con_Close();
        }

        private void cmb_Charges_SelectedIndexChanged(object sender, EventArgs e)
        {
            Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Con;

            if (cmb_Seat_Types.Text == "Balcony")
            {
                Cmd.CommandText = "Select Balcony from Add_Movie_Charges  where Movie_Name ='" + cmb_Movie_Name.Text + "'";


                SqlDataReader Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_Unit.Text = (Obj["Balcony"].ToString());
                }

                Obj.Dispose();
            }
            else if (cmb_Seat_Types.Text == "Delux")
            {

                Cmd.CommandText = "Select Delux from Add_Movie_Charges  where Movie_Name ='" + cmb_Movie_Name.Text + "'";


                SqlDataReader Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_Unit.Text = (Obj["Delux"].ToString());
                }

                Obj.Dispose();
            }
            else
            {
                Cmd.CommandText = "Select Stall from Add_Movie_Charges  where Movie_Name ='" + cmb_Movie_Name.Text + "'";


                SqlDataReader Obj = Cmd.ExecuteReader();

                if (Obj.Read())
                {
                    tb_Unit.Text = (Obj["Stall"].ToString());
                }

                Obj.Dispose();
            }

            Cmd.Dispose();

            Con_Close();
        }

        private void tb_Quantity_TextChanged(object sender, EventArgs e)
        {
            if (tb_Quantity.Text != "")
            {
                if(cmb_Seat_Types.SelectedIndex == 0)
                {
                    if (Convert.ToInt32(tb_Quantity.Text) <= Convert.ToInt32(lbl_Balcony_Count.Text))
                    {
                        int quant = Convert.ToInt32(tb_Quantity.Text);
                        float charges = Convert.ToInt32(tb_Unit.Text);
                        tb_Amount.Text = (quant * charges).ToString();

                        tb_From.Text = Convert.ToString(31 - Convert.ToUInt32(lbl_Balcony_Count.Text));
                        tb_To.Text = Convert.ToString(30 - Convert.ToUInt32(lbl_Balcony_Count.Text) + Convert.ToUInt32(tb_Quantity.Text));
                    }
                    else
                    {
                        MessageBox.Show("No Enough Balcony Tickets Available");
                    }
                }
                else if(cmb_Seat_Types.SelectedIndex == 1)
                {
                    if (Convert.ToInt32(tb_Quantity.Text) <= Convert.ToInt32(lbl_Delux_Count.Text))
                    {
                        int quant = Convert.ToInt32(tb_Quantity.Text);
                        float charges = Convert.ToInt32(tb_Unit.Text);
                        tb_Amount.Text = (quant * charges).ToString();

                        tb_From.Text = Convert.ToString(31 - Convert.ToUInt32(lbl_Delux_Count.Text));
                        tb_To.Text = Convert.ToString(30 - Convert.ToUInt32(lbl_Delux_Count.Text) + Convert.ToUInt32(tb_Quantity.Text));
                    }
                    else
                    {
                        MessageBox.Show("No Enough Delux Tickets Available");
                    }
                }
                else if(cmb_Seat_Types.SelectedIndex == 2)
                {
                    if (Convert.ToInt32(tb_Quantity.Text) <= Convert.ToInt32(lbl_Stall_Count.Text))
                    {
                        int quant = Convert.ToInt32(tb_Quantity.Text);
                        float charges = Convert.ToInt32(tb_Unit.Text);
                        tb_Amount.Text = (quant * charges).ToString();

                        tb_From.Text = Convert.ToString(31 - Convert.ToUInt32(lbl_Stall_Count.Text));
                        tb_To.Text = Convert.ToString(30 - Convert.ToUInt32(lbl_Stall_Count.Text) + Convert.ToUInt32(tb_Quantity.Text));
                    }
                    else
                    {
                        MessageBox.Show("No Enough Stall Tickets Available");
                    }
                }
            }
        }

        private void cmb_Screen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Screen.Text == "1")
            {
                Con_Open();

                int cnt = 0;

                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Select Count(*) From Screen_1_Seat_Allocation where Booking_Status = 1";
              
               // cnt = Convert.ToInt32(Cmd.ExecuteScalar());
                
                Cmd.Dispose();
                Con_Close();

                if (cnt > 0)
                {
                    Con_Open();
                    Cmd.CommandText = "Select * From Screen_1_Seat_Allocation where Booking_Status = 1";
                    Cmd.Connection = Con;

                    var obj = Cmd.ExecuteReader();

                    if (obj.Read())
                    {
                        lbl_Balcony_Count.Text = (obj["Balcony"].ToString());
                        lbl_Delux_Count.Text = (obj["Delux"].ToString());
                        lbl_Stall_Count.Text = (obj["Stall"].ToString());
                    }
                    Cmd.Dispose();
                    Con_Close();
                }
                else
                {
                    MessageBox.Show("No Show Bookings Open For Screen 1");
                }
            }
            else if (cmb_Screen.Text == "2")
            {

            }

        }

    }
}
