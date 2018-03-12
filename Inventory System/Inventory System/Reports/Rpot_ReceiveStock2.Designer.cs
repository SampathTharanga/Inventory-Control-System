namespace Inventory_System
{
    partial class Rpot_ReceiveStock2
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSet_Rpot_ReceiveStok2 = new Inventory_System.DSet_Rpot_ReceiveStok2();
            this.tbl_Recive_StockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Recive_StockTableAdapter = new Inventory_System.DSet_Rpot_ReceiveStok2TableAdapters.tbl_Recive_StockTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_ReceiveStok2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Recive_StockBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_Recive_StockBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_Receive_stok2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(623, 523);
            this.reportViewer1.TabIndex = 0;
            // 
            // DSet_Rpot_ReceiveStok2
            // 
            this.DSet_Rpot_ReceiveStok2.DataSetName = "DSet_Rpot_ReceiveStok2";
            this.DSet_Rpot_ReceiveStok2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Recive_StockBindingSource
            // 
            this.tbl_Recive_StockBindingSource.DataMember = "tbl_Recive_Stock";
            this.tbl_Recive_StockBindingSource.DataSource = this.DSet_Rpot_ReceiveStok2;
            // 
            // tbl_Recive_StockTableAdapter
            // 
            this.tbl_Recive_StockTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_ReceiveStock2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 523);
            this.Controls.Add(this.reportViewer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_ReceiveStock2";
            this.Text = "Rpot_ReceiveStock2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_ReceiveStock2_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_ReceiveStock2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_ReceiveStok2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Recive_StockBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource tbl_Recive_StockBindingSource;
        private DSet_Rpot_ReceiveStok2 DSet_Rpot_ReceiveStok2;
        private DSet_Rpot_ReceiveStok2TableAdapters.tbl_Recive_StockTableAdapter tbl_Recive_StockTableAdapter;

    }
}