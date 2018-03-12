namespace Inventory_System
{
    partial class Rpot_Sales3
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
            this.tbl_Invoice_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSet_Rpot_Sales3 = new Inventory_System.DSet_Rpot_Sales3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_Invoice_detailsTableAdapter = new Inventory_System.DSet_Rpot_Sales3TableAdapters.tbl_Invoice_detailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Invoice_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_Sales3)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Invoice_detailsBindingSource
            // 
            this.tbl_Invoice_detailsBindingSource.DataMember = "tbl_Invoice_details";
            this.tbl_Invoice_detailsBindingSource.DataSource = this.DSet_Rpot_Sales3;
            // 
            // DSet_Rpot_Sales3
            // 
            this.DSet_Rpot_Sales3.DataSetName = "DSet_Rpot_Sales3";
            this.DSet_Rpot_Sales3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_Invoice_detailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_Sales3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(630, 506);
            this.reportViewer1.TabIndex = 1;
            // 
            // tbl_Invoice_detailsTableAdapter
            // 
            this.tbl_Invoice_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_Sales3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 518);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_Sales3";
            this.Text = "Rpot_Sales3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_Sales3_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_Sales3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Invoice_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_Sales3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_Invoice_detailsBindingSource;
        private DSet_Rpot_Sales3 DSet_Rpot_Sales3;
        private DSet_Rpot_Sales3TableAdapters.tbl_Invoice_detailsTableAdapter tbl_Invoice_detailsTableAdapter;
    }
}