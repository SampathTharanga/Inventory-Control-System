﻿namespace Inventory_System
{
    partial class Rpot_Income1
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
            this.tbl_InvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSet_Rpot_Incom1 = new Inventory_System.DSet_Rpot_Incom1();
            this.Rpot_viewr_Invoice1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_InvoiceTableAdapter = new Inventory_System.DSet_Rpot_Incom1TableAdapters.tbl_InvoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_InvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_Incom1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_InvoiceBindingSource
            // 
            this.tbl_InvoiceBindingSource.DataMember = "tbl_Invoice";
            this.tbl_InvoiceBindingSource.DataSource = this.DSet_Rpot_Incom1;
            // 
            // DSet_Rpot_Incom1
            // 
            this.DSet_Rpot_Incom1.DataSetName = "DSet_Rpot_Incom1";
            this.DSet_Rpot_Incom1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rpot_viewr_Invoice1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_InvoiceBindingSource;
            this.Rpot_viewr_Invoice1.LocalReport.DataSources.Add(reportDataSource1);
            this.Rpot_viewr_Invoice1.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_Incom1.rdlc";
            this.Rpot_viewr_Invoice1.Location = new System.Drawing.Point(0, 0);
            this.Rpot_viewr_Invoice1.Name = "Rpot_viewr_Invoice1";
            this.Rpot_viewr_Invoice1.Size = new System.Drawing.Size(630, 537);
            this.Rpot_viewr_Invoice1.TabIndex = 1;
            // 
            // tbl_InvoiceTableAdapter
            // 
            this.tbl_InvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_Income1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 540);
            this.Controls.Add(this.Rpot_viewr_Invoice1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_Income1";
            this.Text = "Rpot_Income1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_Income1_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_Income1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_InvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_Incom1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpot_viewr_Invoice1;
        private System.Windows.Forms.BindingSource tbl_InvoiceBindingSource;
        private DSet_Rpot_Incom1 DSet_Rpot_Incom1;
        private DSet_Rpot_Incom1TableAdapters.tbl_InvoiceTableAdapter tbl_InvoiceTableAdapter;
    }
}