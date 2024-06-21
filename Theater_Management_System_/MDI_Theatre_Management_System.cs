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
    public partial class frm_MDI_Theatre_Management_System : Form
    {
        private int imageNumber = 1;
        private bool isCollapsed;
        public frm_MDI_Theatre_Management_System()
       
        {
            InitializeComponent();
        }

        void Clear_Control()
        { 
            
        }
        private void timer_New_Movie_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_New_Movie.Height += 10;
                if (panel_New_Movie.Size == panel_New_Movie.MaximumSize)
                {
                    timer_New_Movie.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                panel_New_Movie.Height -= 10;
                if (panel_New_Movie.Size == panel_New_Movie.MinimumSize)
                {
                    timer_New_Movie.Stop();
                    isCollapsed = true;
                }
            }
        }
        
        private void timer_Ticket_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_Ticket.Height += 10;
                if (panel_Ticket.Size == panel_Ticket.MaximumSize)
                {
                    timer_Ticket.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                panel_Ticket.Height -= 10;
                if (panel_Ticket.Size == panel_Ticket.MinimumSize)
                {
                    timer_Ticket.Stop();
                    isCollapsed = true;
                }
            }
        }

        private Form activeForm = null;

        private void OpenChildForm(Form ChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            Pb_Image_Slider.Controls.Add(ChildForm);
            Pb_Image_Slider.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
        }

        private void btn_New_Movie_Click(object sender, EventArgs e)
        {
            timer_New_Movie.Start();

            //OpenChildForm(new frm_Add_Movie_Details());
            //Pb_Image_Slider.Visible = false;
        }

        private void btn_Ticket_Click(object sender, EventArgs e)
        {
            timer_Ticket.Start();
        }

        private void timer_Screen_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_Screen.Height += 10;
                if (panel_Screen.Size == panel_Screen.MaximumSize)
                {
                    timer_Screen.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                panel_Screen.Height -= 10;
                if (panel_Screen.Size == panel_Screen.MinimumSize)
                {
                    timer_Screen.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btn_Screen_Click(object sender, EventArgs e)
        {
            timer_Screen.Start();
        }

        private void timer_About_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_Tools.Height += 10;
                if (panel_Tools.Size == panel_Tools.MaximumSize)
                {
                    timer_About.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                panel_Tools.Height -= 10;
                if (panel_Tools.Size == panel_Tools.MinimumSize)
                {
                    timer_About.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void timer_Report_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel_Report.Height += 10;
                if (panel_Report.Size == panel_Report.MaximumSize)
                {
                    timer_Report.Stop();
                    isCollapsed = false;
                }

            }
            else
            {
                panel_Report.Height -= 10;
                if (panel_Report.Size == panel_Report.MinimumSize)
                {
                    timer_Report.Stop();
                    isCollapsed = true;
                }
            }
        }

        

        private void btn_Tools_Click(object sender, EventArgs e)
        {
            timer_About.Start();
        }

        private void slider()
        {
            if (imageNumber == 6)
            {
                imageNumber = 1;
            }
            Pb_Image_Slider.ImageLocation = string.Format(@"H:\Project\Theater_Management_System_\Theater_Management_System_\bin\Debug\Images\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void timer_Image_Slider_Tick(object sender, EventArgs e)
        {
            slider();
        }

        private void btn_Calculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void btn_NotePad_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        void hidesubmenu(Panel pnl)
        {
            pnl.Visible = false;
        }
        void Showhidesubmenu(Panel pnl)
        {
            pnl.Visible = true;
        }

        private void pb_Logout_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Logging Out", "Are You Sure??", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(Res == DialogResult.Yes)
            {
                frm_Login Obj = new frm_Login();
                Obj.Show();
                this.Hide();
            }
            if (Res == DialogResult.No)
            {
                frm_MDI_Theatre_Management_System MDI = new frm_MDI_Theatre_Management_System();
                MDI.Show();
                this.Hide();
            }
        }

        private void btn_Add_Movie_Details_Click(object sender, EventArgs e)
        {
            frm_Add_Movie_Details AMD = new frm_Add_Movie_Details();
            AMD.Show();
             this.Hide();

            //OpenChildForm(new frm_Add_Movie_Details());
            //Pb_Image_Slider.Visible = false;
        }

        private void btn_Purchasing_Click(object sender, EventArgs e)
        {
            frm_Ticket_Purchasing TP = new frm_Ticket_Purchasing();
            TP.Show();
            this.Hide();
        }
  
        private void btn_Screen_1_Click(object sender, EventArgs e)
        {
            frm_Screen_1 SC = new frm_Screen_1();
            SC.Show();
            this.Hide();
        }

        private void btn_Screen_2_Click(object sender, EventArgs e)
        {
            frm_Screen_2 SC = new frm_Screen_2();
            SC.Show();
            this.Hide();
        }

        private void btn_Update_Or_Delete_Click(object sender, EventArgs e)
        {
            

           frm_Update Update = new frm_Update();
            Update.Show();
            this.Hide();
        }

        private void btn_View_Movie_Details_Click(object sender, EventArgs e)
        {
            frm_View_Movie_Details VMD = new frm_View_Movie_Details();
            VMD.Show();
            this.Hide();
        }

        private void btn_View_Movie_Details_Click_1(object sender, EventArgs e)
        {
            frm_View_Movie_Details VMD = new frm_View_Movie_Details();
            VMD.Show();
            this.Hide();

        }


        private void btn_View_Ticket_Purchasing_Click(object sender, EventArgs e)
        {
            frm_View_Ticket_Purchasing VTP = new frm_View_Ticket_Purchasing();
            VTP.Show();
            this.Hide();
        }

        private void btn_User_Managemnt_Click(object sender, EventArgs e)
        {
            timer_User_Managemnt.Start();
        }

        

        private void btn_Report_Click(object sender, EventArgs e)
        {
            timer_Report.Start();
        }

        private void btn_Ticket_Purchasing_Report_Click(object sender, EventArgs e)
        {
            frm_Ticket_Purchasing_Report TPR = new frm_Ticket_Purchasing_Report();
            TPR.Show();
            this.Hide();
        }

        private void btn_Movie_Details_Report_Click(object sender, EventArgs e)
        {
            frm_Movie_Details_Report MD = new frm_Movie_Details_Report();
            this.Hide();
            MD.Show();
        }

        private void frm_MDI_Theatre_Management_System_Load(object sender, EventArgs e)
        {

        }

        private void btn_Charges_Report_Click(object sender, EventArgs e)
        {
            frm_Charges_Report CR = new frm_Charges_Report();
            CR.Show();
            this.Hide();
        }

        private void Pb_Image_Slider_Click(object sender, EventArgs e)
        {

        }

    }
}
