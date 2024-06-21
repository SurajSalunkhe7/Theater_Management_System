namespace Theater_Management_System_
{
    partial class frm_Ticket_Purchasing_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ticket_Purchasing_Report));
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.pb_Back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).BeginInit();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1369, 679);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // pb_Back
            // 
            this.pb_Back.Image = ((System.Drawing.Image)(resources.GetObject("pb_Back.Image")));
            this.pb_Back.Location = new System.Drawing.Point(38, 73);
            this.pb_Back.Name = "pb_Back";
            this.pb_Back.Size = new System.Drawing.Size(115, 50);
            this.pb_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Back.TabIndex = 71;
            this.pb_Back.TabStop = false;
            this.pb_Back.Click += new System.EventHandler(this.pb_Back_Click);
            // 
            // frm_Ticket_Purchasing_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1369, 679);
            this.Controls.Add(this.pb_Back);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "frm_Ticket_Purchasing_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Ticket_Purchasing_Report";
            this.Load += new System.EventHandler(this.frm_Ticket_Purchasing_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Back)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.PictureBox pb_Back;
    }
}