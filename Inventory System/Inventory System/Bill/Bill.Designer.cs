namespace Inventory_System
{
    partial class Bill
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
            this.tbl_Invoice_billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSet_Rpot_Bill = new Inventory_System.DSet_Rpot_Bill();
            this.reportViewer_invo = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_Invoice_billTableAdapter = new Inventory_System.DSet_Rpot_BillTableAdapters.tbl_Invoice_billTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Invoice_billBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_Bill)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Invoice_billBindingSource
            // 
            this.tbl_Invoice_billBindingSource.DataMember = "tbl_Invoice_bill";
            this.tbl_Invoice_billBindingSource.DataSource = this.DSet_Rpot_Bill;
            // 
            // DSet_Rpot_Bill
            // 
            this.DSet_Rpot_Bill.DataSetName = "DSet_Rpot_Bill";
            this.DSet_Rpot_Bill.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer_invo
            // 
            this.reportViewer_invo.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_Invoice_billBindingSource;
            this.reportViewer_invo.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_invo.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_Bill.rdlc";
            this.reportViewer_invo.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_invo.Margin = new System.Windows.Forms.Padding(0);
            this.reportViewer_invo.Name = "reportViewer_invo";
            this.reportViewer_invo.Size = new System.Drawing.Size(644, 712);
            this.reportViewer_invo.TabIndex = 0;
            // 
            // tbl_Invoice_billTableAdapter
            // 
            this.tbl_Invoice_billTableAdapter.ClearBeforeFill = true;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 712);
            this.Controls.Add(this.reportViewer_invo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(650, 740);
            this.MinimumSize = new System.Drawing.Size(650, 726);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sharp Creations";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bill_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Bill_FormClosed);
            this.Load += new System.EventHandler(this.Bill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Invoice_billBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_Bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_invo;
        private System.Windows.Forms.BindingSource tbl_Invoice_billBindingSource;
        private DSet_Rpot_Bill DSet_Rpot_Bill;
        private DSet_Rpot_BillTableAdapters.tbl_Invoice_billTableAdapter tbl_Invoice_billTableAdapter;

    }
}