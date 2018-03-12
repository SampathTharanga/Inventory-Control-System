namespace Inventory_System
{
    partial class Rpot_ReturnItem
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
            this.tbl_Return_itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dset_Rpot_ReturnI = new Inventory_System.Dset_Rpot_ReturnI();
            this.Rpot_Returnitm = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_Return_itemsTableAdapter = new Inventory_System.Dset_Rpot_ReturnITableAdapters.tbl_Return_itemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Return_itemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dset_Rpot_ReturnI)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Return_itemsBindingSource
            // 
            this.tbl_Return_itemsBindingSource.DataMember = "tbl_Return_items";
            this.tbl_Return_itemsBindingSource.DataSource = this.Dset_Rpot_ReturnI;
            // 
            // Dset_Rpot_ReturnI
            // 
            this.Dset_Rpot_ReturnI.DataSetName = "Dset_Rpot_ReturnI";
            this.Dset_Rpot_ReturnI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rpot_Returnitm
            // 
            this.Rpot_Returnitm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Rpot_Returnitm.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_Return_itemsBindingSource;
            this.Rpot_Returnitm.LocalReport.DataSources.Add(reportDataSource1);
            this.Rpot_Returnitm.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_RetunI.rdlc";
            this.Rpot_Returnitm.Location = new System.Drawing.Point(0, 0);
            this.Rpot_Returnitm.Name = "Rpot_Returnitm";
            this.Rpot_Returnitm.Size = new System.Drawing.Size(632, 582);
            this.Rpot_Returnitm.TabIndex = 78;
            // 
            // tbl_Return_itemsTableAdapter
            // 
            this.tbl_Return_itemsTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_ReturnItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 582);
            this.Controls.Add(this.Rpot_Returnitm);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_ReturnItem";
            this.Text = "Rpot_ReturnItem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_ReturnItem_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_ReturnItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Return_itemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dset_Rpot_ReturnI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpot_Returnitm;
        private System.Windows.Forms.BindingSource tbl_Return_itemsBindingSource;
        private Dset_Rpot_ReturnI Dset_Rpot_ReturnI;
        private Dset_Rpot_ReturnITableAdapters.tbl_Return_itemsTableAdapter tbl_Return_itemsTableAdapter;
    }
}