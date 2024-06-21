namespace Theater_Management_System_
{
    partial class frm_Charges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Charges));
            this.lbl_Charges = new System.Windows.Forms.Label();
            this.lbl_Movie_Id = new System.Windows.Forms.Label();
            this.lbl_Movie_Name = new System.Windows.Forms.Label();
            this.tb_Movie_ID = new System.Windows.Forms.TextBox();
            this.tb_Movie_Name = new System.Windows.Forms.TextBox();
            this.gb_Pricing = new System.Windows.Forms.GroupBox();
            this.tb_Stall = new System.Windows.Forms.TextBox();
            this.tb_Delux = new System.Windows.Forms.TextBox();
            this.tb_Balcony = new System.Windows.Forms.TextBox();
            this.lbl_Stall = new System.Windows.Forms.Label();
            this.lbl_Delux = new System.Windows.Forms.Label();
            this.lbl_Balcony = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.pcb_Logout = new System.Windows.Forms.PictureBox();
            this.theater_Management_System_DBDataSet1 = new Theater_Management_System_.Theater_Management_System_DBDataSet();
            this.gb_Pricing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Logout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theater_Management_System_DBDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Charges
            // 
            this.lbl_Charges.AutoSize = true;
            this.lbl_Charges.Font = new System.Drawing.Font("Algerian", 50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Charges.Location = new System.Drawing.Point(278, 9);
            this.lbl_Charges.Name = "lbl_Charges";
            this.lbl_Charges.Size = new System.Drawing.Size(422, 94);
            this.lbl_Charges.TabIndex = 1;
            this.lbl_Charges.Text = "Charges";
            // 
            // lbl_Movie_Id
            // 
            this.lbl_Movie_Id.AutoSize = true;
            this.lbl_Movie_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Movie_Id.Location = new System.Drawing.Point(183, 146);
            this.lbl_Movie_Id.Name = "lbl_Movie_Id";
            this.lbl_Movie_Id.Size = new System.Drawing.Size(185, 48);
            this.lbl_Movie_Id.TabIndex = 1;
            this.lbl_Movie_Id.Text = "Movie ID";
            // 
            // lbl_Movie_Name
            // 
            this.lbl_Movie_Name.AutoSize = true;
            this.lbl_Movie_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Movie_Name.Location = new System.Drawing.Point(183, 261);
            this.lbl_Movie_Name.Name = "lbl_Movie_Name";
            this.lbl_Movie_Name.Size = new System.Drawing.Size(254, 48);
            this.lbl_Movie_Name.TabIndex = 2;
            this.lbl_Movie_Name.Text = "Movie Name";
            // 
            // tb_Movie_ID
            // 
            this.tb_Movie_ID.Enabled = false;
            this.tb_Movie_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Movie_ID.Location = new System.Drawing.Point(480, 151);
            this.tb_Movie_ID.Name = "tb_Movie_ID";
            this.tb_Movie_ID.Size = new System.Drawing.Size(313, 45);
            this.tb_Movie_ID.TabIndex = 4;
            this.tb_Movie_ID.TextChanged += new System.EventHandler(this.tb_Movie_ID_TextChanged);
            // 
            // tb_Movie_Name
            // 
            this.tb_Movie_Name.Enabled = false;
            this.tb_Movie_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Movie_Name.Location = new System.Drawing.Point(480, 266);
            this.tb_Movie_Name.Name = "tb_Movie_Name";
            this.tb_Movie_Name.Size = new System.Drawing.Size(313, 45);
            this.tb_Movie_Name.TabIndex = 5;
            // 
            // gb_Pricing
            // 
            this.gb_Pricing.Controls.Add(this.tb_Stall);
            this.gb_Pricing.Controls.Add(this.tb_Delux);
            this.gb_Pricing.Controls.Add(this.tb_Balcony);
            this.gb_Pricing.Controls.Add(this.lbl_Stall);
            this.gb_Pricing.Controls.Add(this.lbl_Delux);
            this.gb_Pricing.Controls.Add(this.lbl_Balcony);
            this.gb_Pricing.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Pricing.Location = new System.Drawing.Point(191, 383);
            this.gb_Pricing.Name = "gb_Pricing";
            this.gb_Pricing.Size = new System.Drawing.Size(602, 207);
            this.gb_Pricing.TabIndex = 3;
            this.gb_Pricing.TabStop = false;
            this.gb_Pricing.Text = "Pricing";
            // 
            // tb_Stall
            // 
            this.tb_Stall.Location = new System.Drawing.Point(426, 123);
            this.tb_Stall.Multiline = true;
            this.tb_Stall.Name = "tb_Stall";
            this.tb_Stall.Size = new System.Drawing.Size(126, 46);
            this.tb_Stall.TabIndex = 6;
            this.tb_Stall.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Delux
            // 
            this.tb_Delux.Location = new System.Drawing.Point(242, 123);
            this.tb_Delux.Multiline = true;
            this.tb_Delux.Name = "tb_Delux";
            this.tb_Delux.Size = new System.Drawing.Size(116, 46);
            this.tb_Delux.TabIndex = 5;
            this.tb_Delux.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Mumeric);
            // 
            // tb_Balcony
            // 
            this.tb_Balcony.Location = new System.Drawing.Point(44, 123);
            this.tb_Balcony.Multiline = true;
            this.tb_Balcony.Name = "tb_Balcony";
            this.tb_Balcony.Size = new System.Drawing.Size(116, 46);
            this.tb_Balcony.TabIndex = 4;
            this.tb_Balcony.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // lbl_Stall
            // 
            this.lbl_Stall.AutoSize = true;
            this.lbl_Stall.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stall.Location = new System.Drawing.Point(457, 57);
            this.lbl_Stall.Name = "lbl_Stall";
            this.lbl_Stall.Size = new System.Drawing.Size(67, 31);
            this.lbl_Stall.TabIndex = 3;
            this.lbl_Stall.Text = "Stall";
            // 
            // lbl_Delux
            // 
            this.lbl_Delux.AutoSize = true;
            this.lbl_Delux.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Delux.Location = new System.Drawing.Point(255, 57);
            this.lbl_Delux.Name = "lbl_Delux";
            this.lbl_Delux.Size = new System.Drawing.Size(83, 31);
            this.lbl_Delux.TabIndex = 2;
            this.lbl_Delux.Text = "Delux";
            // 
            // lbl_Balcony
            // 
            this.lbl_Balcony.AutoSize = true;
            this.lbl_Balcony.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balcony.Location = new System.Drawing.Point(38, 57);
            this.lbl_Balcony.Name = "lbl_Balcony";
            this.lbl_Balcony.Size = new System.Drawing.Size(111, 31);
            this.lbl_Balcony.TabIndex = 1;
            this.lbl_Balcony.Text = "Balcony";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.White;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_save.Location = new System.Drawing.Point(424, 633);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(116, 46);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pcb_Logout
            // 
            this.pcb_Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcb_Logout.Image = ((System.Drawing.Image)(resources.GetObject("pcb_Logout.Image")));
            this.pcb_Logout.Location = new System.Drawing.Point(25, 12);
            this.pcb_Logout.Name = "pcb_Logout";
            this.pcb_Logout.Size = new System.Drawing.Size(156, 62);
            this.pcb_Logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_Logout.TabIndex = 19;
            this.pcb_Logout.TabStop = false;
            this.pcb_Logout.Click += new System.EventHandler(this.pcb_Logout_Click);
            // 
            // theater_Management_System_DBDataSet1
            // 
            this.theater_Management_System_DBDataSet1.DataSetName = "Theater_Management_System_DBDataSet";
            this.theater_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frm_Charges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1004, 739);
            this.Controls.Add(this.pcb_Logout);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.gb_Pricing);
            this.Controls.Add(this.tb_Movie_Name);
            this.Controls.Add(this.tb_Movie_ID);
            this.Controls.Add(this.lbl_Movie_Name);
            this.Controls.Add(this.lbl_Movie_Id);
            this.Controls.Add(this.lbl_Charges);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Charges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.frm_Charges_Load);
            this.gb_Pricing.ResumeLayout(false);
            this.gb_Pricing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Logout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theater_Management_System_DBDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Charges;
        private System.Windows.Forms.Label lbl_Movie_Id;
        private System.Windows.Forms.Label lbl_Movie_Name;
        private System.Windows.Forms.TextBox tb_Movie_ID;
        private System.Windows.Forms.TextBox tb_Movie_Name;
        private System.Windows.Forms.GroupBox gb_Pricing;
        private System.Windows.Forms.TextBox tb_Delux;
        private System.Windows.Forms.TextBox tb_Balcony;
        private System.Windows.Forms.Label lbl_Stall;
        private System.Windows.Forms.Label lbl_Delux;
        private System.Windows.Forms.Label lbl_Balcony;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tb_Stall;
        private System.Windows.Forms.PictureBox pcb_Logout;
        private Theater_Management_System_DBDataSet theater_Management_System_DBDataSet1;
    }
}