namespace Theater_Management_System_
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.pb_Login = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(999, 398);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(282, 45);
            this.tb_Password.TabIndex = 43;
            this.tb_Password.TextChanged += new System.EventHandler(this.tb_Password_TextChanged);
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(999, 264);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(282, 45);
            this.tb_Username.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(689, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 51);
            this.label1.TabIndex = 50;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 51);
            this.label2.TabIndex = 49;
            this.label2.Text = "Username";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Login.Font = new System.Drawing.Font("Microsoft Tai Le", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Red;
            this.lbl_Login.Location = new System.Drawing.Point(887, 143);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(171, 68);
            this.lbl_Login.TabIndex = 48;
            this.lbl_Login.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(294, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(694, 89);
            this.label3.TabIndex = 42;
            this.label3.Text = "DREAM Theater";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.White;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_Save.Location = new System.Drawing.Point(861, 529);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(197, 57);
            this.btn_Save.TabIndex = 44;
            this.btn_Save.Text = "Login";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // pb_Login
            // 
            this.pb_Login.Image = ((System.Drawing.Image)(resources.GetObject("pb_Login.Image")));
            this.pb_Login.Location = new System.Drawing.Point(27, 143);
            this.pb_Login.Name = "pb_Login";
            this.pb_Login.Size = new System.Drawing.Size(636, 452);
            this.pb_Login.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Login.TabIndex = 46;
            this.pb_Login.TabStop = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1305, 639);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.pb_Login);
            this.Controls.Add(this.label3);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pb_Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.PictureBox pb_Login;
    }
}