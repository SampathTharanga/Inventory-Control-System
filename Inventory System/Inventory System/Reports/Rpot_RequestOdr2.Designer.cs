namespace Inventory_System
{
    partial class Rpot_RequestOdr2
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
            this.tbl_Request_OrderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSet_Rpot_RequestOdr2 = new Inventory_System.DSet_Rpot_RequestOdr2();
            this.Rpot_vewer_reqstodr2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_Request_OrderTableAdapter = new Inventory_System.DSet_Rpot_RequestOdr2TableAdapters.tbl_Request_OrderTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Request_OrderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_RequestOdr2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Request_OrderBindingSource
            // 
            this.tbl_Request_OrderBindingSource.DataMember = "tbl_Request_Order";
            this.tbl_Request_OrderBindingSource.DataSource = this.DSet_Rpot_RequestOdr2;
            // 
            // DSet_Rpot_RequestOdr2
            // 
            this.DSet_Rpot_RequestOdr2.DataSetName = "DSet_Rpot_RequestOdr2";
            this.DSet_Rpot_RequestOdr2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rpot_vewer_reqstodr2
            // 
            this.Rpot_vewer_reqstodr2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_Request_OrderBindingSource;
            this.Rpot_vewer_reqstodr2.LocalReport.DataSources.Add(reportDataSource1);
            this.Rpot_vewer_reqstodr2.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_RequetOdr2.rdlc";
            this.Rpot_vewer_reqstodr2.Location = new System.Drawing.Point(0, 0);
            this.Rpot_vewer_reqstodr2.Name = "Rpot_vewer_reqstodr2";
            this.Rpot_vewer_reqstodr2.Size = new System.Drawing.Size(616, 510);
            this.Rpot_vewer_reqstodr2.TabIndex = 1;
            // 
            // tbl_Request_OrderTableAdapter
            // 
            this.tbl_Request_OrderTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_RequestOdr2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(616, 510);
            this.Controls.Add(this.Rpot_vewer_reqstodr2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_RequestOdr2";
            this.Text = "Rpot_RequestOdr2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_RequestOdr2_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_RequestOdr2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Request_OrderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_RequestOdr2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpot_vewer_reqstodr2;
        private System.Windows.Forms.BindingSource tbl_Request_OrderBindingSource;
        private DSet_Rpot_RequestOdr2 DSet_Rpot_RequestOdr2;
        private DSet_Rpot_RequestOdr2TableAdapters.tbl_Request_OrderTableAdapter tbl_Request_OrderTableAdapter;
    }
}