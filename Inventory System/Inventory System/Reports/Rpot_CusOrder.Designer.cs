namespace Inventory_System
{
    partial class Rpot_CusOrder
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tbl_Customer_OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSet_Rpot_List = new Inventory_System.DSet_Rpot_List();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.Rpot_cusodr = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btn_view = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.tbl_Customer_OrderTableAdapter = new Inventory_System.DSet_Rpot_ListTableAdapters.tbl_Customer_OrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Customer_OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_List)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Customer_OrderBindingSource
            // 
            this.tbl_Customer_OrderBindingSource.DataMember = "tbl_Customer_Order";
            this.tbl_Customer_OrderBindingSource.DataSource = this.DSet_Rpot_List;
            // 
            // DSet_Rpot_List
            // 
            this.DSet_Rpot_List.DataSetName = "DSet_Rpot_List";
            this.DSet_Rpot_List.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(194, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "To Date  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "From Date  : ";
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_to.Location = new System.Drawing.Point(252, 20);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker_to.TabIndex = 71;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_From.Location = new System.Drawing.Point(66, 20);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker_From.TabIndex = 70;
            // 
            // Rpot_cusodr
            // 
            this.Rpot_cusodr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_Customer_OrderBindingSource;
            this.Rpot_cusodr.LocalReport.DataSources.Add(reportDataSource1);
            this.Rpot_cusodr.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_CusOder.rdlc";
            this.Rpot_cusodr.Location = new System.Drawing.Point(0, 60);
            this.Rpot_cusodr.Name = "Rpot_cusodr";
            this.Rpot_cusodr.Size = new System.Drawing.Size(632, 521);
            this.Rpot_cusodr.TabIndex = 69;
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(479, 14);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(67, 23);
            this.btn_view.TabIndex = 76;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(553, 14);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(67, 23);
            this.btn_reset.TabIndex = 77;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // tbl_Customer_OrderTableAdapter
            // 
            this.tbl_Customer_OrderTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_CusOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 582);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.dateTimePicker_From);
            this.Controls.Add(this.Rpot_cusodr);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_CusOrder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_CusOrder_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_CusOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Customer_OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_List)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private Microsoft.Reporting.WinForms.ReportViewer Rpot_cusodr;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.BindingSource tbl_Customer_OrderBindingSource;
        private DSet_Rpot_List DSet_Rpot_List;
        private DSet_Rpot_ListTableAdapters.tbl_Customer_OrderTableAdapter tbl_Customer_OrderTableAdapter;
    }
}