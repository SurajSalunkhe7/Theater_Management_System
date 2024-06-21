namespace Theater_Management_System_
{
    partial class frm_Screen_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Screen_2));
            this.lbl_Movie_Name = new System.Windows.Forms.Label();
            this.lbl_Movie_ID = new System.Windows.Forms.Label();
            this.lbl_Screen_1 = new System.Windows.Forms.Label();
            this.pb_Photograph = new System.Windows.Forms.PictureBox();
            this.tb_M_Name = new System.Windows.Forms.TextBox();
            this.tb_M_ID = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photograph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Movie_Name
            // 
            this.lbl_Movie_Name.AutoSize = true;
            this.lbl_Movie_Name.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Movie_Name.Location = new System.Drawing.Point(192, 263);
            this.lbl_Movie_Name.Name = "lbl_Movie_Name";
            this.lbl_Movie_Name.Size = new System.Drawing.Size(213, 45);
            this.lbl_Movie_Name.TabIndex = 61;
            this.lbl_Movie_Name.Text = "Movie Name";
            // 
            // lbl_Movie_ID
            // 
            this.lbl_Movie_ID.AutoSize = true;
            this.lbl_Movie_ID.Font = new System.Drawing.Font("Yu Gothic UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Movie_ID.Location = new System.Drawing.Point(192, 131);
            this.lbl_Movie_ID.Name = "lbl_Movie_ID";
            this.lbl_Movie_ID.Size = new System.Drawing.Size(158, 45);
            this.lbl_Movie_ID.TabIndex = 59;
            this.lbl_Movie_ID.Text = "Movie ID";
            // 
            // lbl_Screen_1
            // 
            this.lbl_Screen_1.AutoSize = true;
            this.lbl_Screen_1.BackColor = System.Drawing.Color.AliceBlue;
            this.lbl_Screen_1.Font = new System.Drawing.Font("Wide Latin", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Screen_1.Location = new System.Drawing.Point(259, 9);
            this.lbl_Screen_1.Name = "lbl_Screen_1";
            this.lbl_Screen_1.Size = new System.Drawing.Size(424, 59);
            this.lbl_Screen_1.TabIndex = 58;
            this.lbl_Screen_1.Text = "Screen _ 2";
            // 
            // pb_Photograph
            // 
            this.pb_Photograph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Photograph.Location = new System.Drawing.Point(86, 339);
            this.pb_Photograph.Name = "pb_Photograph";
            this.pb_Photograph.Size = new System.Drawing.Size(825, 430);
            this.pb_Photograph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Photograph.TabIndex = 63;
            this.pb_Photograph.TabStop = false;
            // 
            // tb_M_Name
            // 
            this.tb_M_Name.Enabled = false;
            this.tb_M_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_M_Name.Location = new System.Drawing.Point(450, 262);
            this.tb_M_Name.Name = "tb_M_Name";
            this.tb_M_Name.Size = new System.Drawing.Size(247, 41);
            this.tb_M_Name.TabIndex = 69;
            // 
            // tb_M_ID
            // 
            this.tb_M_ID.Enabled = false;
            this.tb_M_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_M_ID.Location = new System.Drawing.Point(450, 135);
            this.tb_M_ID.Name = "tb_M_ID";
            this.tb_M_ID.Size = new System.Drawing.Size(247, 41);
            this.tb_M_ID.TabIndex = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_Screen_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(976, 781);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tb_M_Name);
            this.Controls.Add(this.tb_M_ID);
            this.Controls.Add(this.pb_Photograph);
            this.Controls.Add(this.lbl_Movie_Name);
            this.Controls.Add(this.lbl_Movie_ID);
            this.Controls.Add(this.lbl_Screen_1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Screen_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frm_Screen_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Photograph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Movie_Name;
        private System.Windows.Forms.Label lbl_Movie_ID;
        private System.Windows.Forms.Label lbl_Screen_1;
        private System.Windows.Forms.PictureBox pb_Photograph;
        private System.Windows.Forms.TextBox tb_M_Name;
        private System.Windows.Forms.TextBox tb_M_ID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}