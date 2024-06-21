namespace Theater_Management_System_
{
    partial class frm_View_Ticket_Purchasing
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
            this.lbl_View_Ticket_Purchasing = new System.Windows.Forms.Label();
            this.ticketPurchasingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theater_Management_System_DBDataSet1 = new Theater_Management_System_.Theater_Management_System_DBDataSet1();
            this.btn_back = new System.Windows.Forms.Button();
            this.ticket_PurchasingTableAdapter = new Theater_Management_System_.Theater_Management_System_DBDataSet1TableAdapters.Ticket_PurchasingTableAdapter();
            this.theater_Management_System_DBDataSet2 = new Theater_Management_System_.Theater_Management_System_DBDataSet2();
            this.dgv_View_Ticket_Purchasing = new System.Windows.Forms.DataGridView();
            this.theater_Management_System_DBDataSet3 = new Theater_Management_System_.Theater_Management_System_DBDataSet3();
            this.ticketPurchasingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ticket_PurchasingTableAdapter1 = new Theater_Management_System_.Theater_Management_System_DBDataSet3TableAdapters.Ticket_PurchasingTableAdapter();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.movieNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatFromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seatToDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showTimingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ticketPurchasingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theater_Management_System_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theater_Management_System_DBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Ticket_Purchasing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theater_Management_System_DBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketPurchasingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_View_Ticket_Purchasing
            // 
            this.lbl_View_Ticket_Purchasing.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_View_Ticket_Purchasing.AutoSize = true;
            this.lbl_View_Ticket_Purchasing.Font = new System.Drawing.Font("Wide Latin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Ticket_Purchasing.Location = new System.Drawing.Point(34, 21);
            this.lbl_View_Ticket_Purchasing.Name = "lbl_View_Ticket_Purchasing";
            this.lbl_View_Ticket_Purchasing.Size = new System.Drawing.Size(1271, 74);
            this.lbl_View_Ticket_Purchasing.TabIndex = 3;
            this.lbl_View_Ticket_Purchasing.Text = "View Ticket Purchasing";
            // 
            // ticketPurchasingBindingSource
            // 
            this.ticketPurchasingBindingSource.DataMember = "Ticket_Purchasing";
            this.ticketPurchasingBindingSource.DataSource = this.theater_Management_System_DBDataSet1;
            // 
            // theater_Management_System_DBDataSet1
            // 
            this.theater_Management_System_DBDataSet1.DataSetName = "Theater_Management_System_DBDataSet1";
            this.theater_Management_System_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.OrangeRed;
            this.btn_back.Location = new System.Drawing.Point(611, 687);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(248, 70);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // ticket_PurchasingTableAdapter
            // 
            this.ticket_PurchasingTableAdapter.ClearBeforeFill = true;
            // 
            // theater_Management_System_DBDataSet2
            // 
            this.theater_Management_System_DBDataSet2.DataSetName = "Theater_Management_System_DBDataSet2";
            this.theater_Management_System_DBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgv_View_Ticket_Purchasing
            // 
            this.dgv_View_Ticket_Purchasing.AllowUserToAddRows = false;
            this.dgv_View_Ticket_Purchasing.AllowUserToDeleteRows = false;
            this.dgv_View_Ticket_Purchasing.AutoGenerateColumns = false;
            this.dgv_View_Ticket_Purchasing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_View_Ticket_Purchasing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_View_Ticket_Purchasing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIDDataGridViewTextBoxColumn,
            this.movieNameDataGridViewTextBoxColumn,
            this.screenDataGridViewTextBoxColumn,
            this.seatTypeDataGridViewTextBoxColumn,
            this.seatFromDataGridViewTextBoxColumn,
            this.seatToDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.showTimingDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn});
            this.dgv_View_Ticket_Purchasing.DataSource = this.ticketPurchasingBindingSource1;
            this.dgv_View_Ticket_Purchasing.Location = new System.Drawing.Point(12, 121);
            this.dgv_View_Ticket_Purchasing.Name = "dgv_View_Ticket_Purchasing";
            this.dgv_View_Ticket_Purchasing.ReadOnly = true;
            this.dgv_View_Ticket_Purchasing.RowTemplate.Height = 24;
            this.dgv_View_Ticket_Purchasing.Size = new System.Drawing.Size(1516, 560);
            this.dgv_View_Ticket_Purchasing.TabIndex = 22;
            // 
            // theater_Management_System_DBDataSet3
            // 
            this.theater_Management_System_DBDataSet3.DataSetName = "Theater_Management_System_DBDataSet3";
            this.theater_Management_System_DBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketPurchasingBindingSource1
            // 
            this.ticketPurchasingBindingSource1.DataMember = "Ticket_Purchasing";
            this.ticketPurchasingBindingSource1.DataSource = this.theater_Management_System_DBDataSet3;
            // 
            // ticket_PurchasingTableAdapter1
            // 
            this.ticket_PurchasingTableAdapter1.ClearBeforeFill = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movieNameDataGridViewTextBoxColumn
            // 
            this.movieNameDataGridViewTextBoxColumn.DataPropertyName = "Movie_Name";
            this.movieNameDataGridViewTextBoxColumn.HeaderText = "Movie_Name";
            this.movieNameDataGridViewTextBoxColumn.Name = "movieNameDataGridViewTextBoxColumn";
            this.movieNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // screenDataGridViewTextBoxColumn
            // 
            this.screenDataGridViewTextBoxColumn.DataPropertyName = "Screen";
            this.screenDataGridViewTextBoxColumn.HeaderText = "Screen";
            this.screenDataGridViewTextBoxColumn.Name = "screenDataGridViewTextBoxColumn";
            this.screenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seatTypeDataGridViewTextBoxColumn
            // 
            this.seatTypeDataGridViewTextBoxColumn.DataPropertyName = "Seat_Type";
            this.seatTypeDataGridViewTextBoxColumn.HeaderText = "Seat_Type";
            this.seatTypeDataGridViewTextBoxColumn.Name = "seatTypeDataGridViewTextBoxColumn";
            this.seatTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seatFromDataGridViewTextBoxColumn
            // 
            this.seatFromDataGridViewTextBoxColumn.DataPropertyName = "Seat_From";
            this.seatFromDataGridViewTextBoxColumn.HeaderText = "Seat_From";
            this.seatFromDataGridViewTextBoxColumn.Name = "seatFromDataGridViewTextBoxColumn";
            this.seatFromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seatToDataGridViewTextBoxColumn
            // 
            this.seatToDataGridViewTextBoxColumn.DataPropertyName = "Seat_To";
            this.seatToDataGridViewTextBoxColumn.HeaderText = "Seat_To";
            this.seatToDataGridViewTextBoxColumn.Name = "seatToDataGridViewTextBoxColumn";
            this.seatToDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // showTimingDataGridViewTextBoxColumn
            // 
            this.showTimingDataGridViewTextBoxColumn.DataPropertyName = "Show_Timing";
            this.showTimingDataGridViewTextBoxColumn.HeaderText = "Show_Timing";
            this.showTimingDataGridViewTextBoxColumn.Name = "showTimingDataGridViewTextBoxColumn";
            this.showTimingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_Ticket_Purchasing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1540, 769);
            this.Controls.Add(this.dgv_View_Ticket_Purchasing);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_View_Ticket_Purchasing);
            this.Name = "frm_View_Ticket_Purchasing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_View_Ticket_Purchasing";
            this.Load += new System.EventHandler(this.frm_View_Ticket_Purchasing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ticketPurchasingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theater_Management_System_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theater_Management_System_DBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_View_Ticket_Purchasing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.theater_Management_System_DBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketPurchasingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_View_Ticket_Purchasing;
        private System.Windows.Forms.Button btn_back;
        private Theater_Management_System_DBDataSet1 theater_Management_System_DBDataSet1;
        private System.Windows.Forms.BindingSource ticketPurchasingBindingSource;
        private Theater_Management_System_DBDataSet1TableAdapters.Ticket_PurchasingTableAdapter ticket_PurchasingTableAdapter;
        private Theater_Management_System_DBDataSet2 theater_Management_System_DBDataSet2;
        private System.Windows.Forms.DataGridView dgv_View_Ticket_Purchasing;
        private Theater_Management_System_DBDataSet3 theater_Management_System_DBDataSet3;
        private System.Windows.Forms.BindingSource ticketPurchasingBindingSource1;
        private Theater_Management_System_DBDataSet3TableAdapters.Ticket_PurchasingTableAdapter ticket_PurchasingTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn movieNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatFromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatToDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showTimingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
    }
}