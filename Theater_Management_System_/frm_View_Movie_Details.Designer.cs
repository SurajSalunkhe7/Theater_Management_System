namespace Theater_Management_System_
{
    partial class frm_View_Movie_Details
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_View_Movie_Details = new System.Windows.Forms.DataGridView();
            this.movieIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showTimingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.castDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addMovieDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theater_Management_System_DBDataSet = new Theater_Management_System_.Theater_Management_System_DBDataSet();
            this.lbl_Update = new System.Windows.Forms.Label();
            this.add_Movie_DetailsTableAdapter = new Theater_Management_System_.Theater_Management_System_DBDataSetTableAdapters.Add_Movie_DetailsTableAdapter();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Movie_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMovieDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theater_Management_System_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_View_Movie_Details
            // 
            this.dgv_View_Movie_Details.AllowUserToAddRows = false;
            this.dgv_View_Movie_Details.AllowUserToDeleteRows = false;
            this.dgv_View_Movie_Details.AutoGenerateColumns = false;
            this.dgv_View_Movie_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_View_Movie_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_View_Movie_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Movie_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.movieIDDataGridViewTextBoxColumn,
            this.movieNameDataGridViewTextBoxColumn,
            this.showTimingDataGridViewTextBoxColumn,
            this.castDataGridViewTextBoxColumn,
            this.screenDataGridViewTextBoxColumn,
            this.releDateDataGridViewTextBoxColumn,
            this.languageDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgv_View_Movie_Details.DataSource = this.addMovieDetailsBindingSource;
            this.dgv_View_Movie_Details.Location = new System.Drawing.Point(12, 121);
            this.dgv_View_Movie_Details.Name = "dgv_View_Movie_Details";
            this.dgv_View_Movie_Details.ReadOnly = true;
            this.dgv_View_Movie_Details.RowTemplate.Height = 24;
            this.dgv_View_Movie_Details.Size = new System.Drawing.Size(1289, 517);
            this.dgv_View_Movie_Details.TabIndex = 0;
            this.dgv_View_Movie_Details.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_View_Movie_Details_CellContentClick);
            // 
            // movieIDDataGridViewTextBoxColumn
            // 
            this.movieIDDataGridViewTextBoxColumn.DataPropertyName = "Movie_ID";
            this.movieIDDataGridViewTextBoxColumn.HeaderText = "Movie_ID";
            this.movieIDDataGridViewTextBoxColumn.Name = "movieIDDataGridViewTextBoxColumn";
            this.movieIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieNameDataGridViewTextBoxColumn
            // 
            this.movieNameDataGridViewTextBoxColumn.DataPropertyName = "Movie_Name";
            this.movieNameDataGridViewTextBoxColumn.HeaderText = "Movie_Name";
            this.movieNameDataGridViewTextBoxColumn.Name = "movieNameDataGridViewTextBoxColumn";
            this.movieNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // showTimingDataGridViewTextBoxColumn
            // 
            this.showTimingDataGridViewTextBoxColumn.DataPropertyName = "Show_Timing";
            this.showTimingDataGridViewTextBoxColumn.HeaderText = "Show_Timing";
            this.showTimingDataGridViewTextBoxColumn.Name = "showTimingDataGridViewTextBoxColumn";
            this.showTimingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // castDataGridViewTextBoxColumn
            // 
            this.castDataGridViewTextBoxColumn.DataPropertyName = "Cast";
            this.castDataGridViewTextBoxColumn.HeaderText = "Cast";
            this.castDataGridViewTextBoxColumn.Name = "castDataGridViewTextBoxColumn";
            this.castDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // screenDataGridViewTextBoxColumn
            // 
            this.screenDataGridViewTextBoxColumn.DataPropertyName = "Screen";
            this.screenDataGridViewTextBoxColumn.HeaderText = "Screen";
            this.screenDataGridViewTextBoxColumn.Name = "screenDataGridViewTextBoxColumn";
            this.screenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releDateDataGridViewTextBoxColumn
            // 
            this.releDateDataGridViewTextBoxColumn.DataPropertyName = "Rele_Date";
            this.releDateDataGridViewTextBoxColumn.HeaderText = "Rele_Date";
            this.releDateDataGridViewTextBoxColumn.Name = "releDateDataGridViewTextBoxColumn";
            this.releDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "Language";
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addMovieDetailsBindingSource
            // 
            this.addMovieDetailsBindingSource.DataMember = "Add_Movie_Details";
            this.addMovieDetailsBindingSource.DataSource = this.theater_Management_System_DBDataSet;
            // 
            // theater_Management_System_DBDataSet
            // 
            this.theater_Management_System_DBDataSet.DataSetName = "Theater_Management_System_DBDataSet";
            this.theater_Management_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl_Update
            // 
            this.lbl_Update.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Update.AutoSize = true;
            this.lbl_Update.Font = new System.Drawing.Font("Wide Latin", 40F, System.Drawing.FontStyle.Bold);
            this.lbl_Update.Location = new System.Drawing.Point(97, 18);
            this.lbl_Update.Name = "lbl_Update";
            this.lbl_Update.Size = new System.Drawing.Size(1144, 83);
            this.lbl_Update.TabIndex = 2;
            this.lbl_Update.Text = "View Movie Details";
            // 
            // add_Movie_DetailsTableAdapter
            // 
            this.add_Movie_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_back.Location = new System.Drawing.Point(545, 661);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(261, 70);
            this.btn_back.TabIndex = 20;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // frm_View_Movie_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1313, 743);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_Update);
            this.Controls.Add(this.dgv_View_Movie_Details);
            this.Name = "frm_View_Movie_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_Movie_Details";
            this.Load += new System.EventHandler(this.frm_View_Movie_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Movie_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addMovieDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theater_Management_System_DBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_View_Movie_Details;
        private System.Windows.Forms.Label lbl_Update;
        private Theater_Management_System_DBDataSet theater_Management_System_DBDataSet;
        private System.Windows.Forms.BindingSource addMovieDetailsBindingSource;
        private Theater_Management_System_DBDataSetTableAdapters.Add_Movie_DetailsTableAdapter add_Movie_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showTimingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn castDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_back;
    }
}