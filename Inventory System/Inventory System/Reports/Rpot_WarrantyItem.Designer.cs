namespace Inventory_System
{
    partial class Rpot_WarrantyItem
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
            this.tbl_warrnty_found_ItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Dset_Rpot_warrntyI = new Inventory_System.Dset_Rpot_warrntyI();
            this.Rpot_view_Warrnty = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_warrnty_found_ItemTableAdapter = new Inventory_System.Dset_Rpot_warrntyITableAdapters.tbl_warrnty_found_ItemTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_warrnty_found_ItemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dset_Rpot_warrntyI)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_warrnty_found_ItemBindingSource
            // 
            this.tbl_warrnty_found_ItemBindingSource.DataMember = "tbl_warrnty_found_Item";
            this.tbl_warrnty_found_ItemBindingSource.DataSource = this.Dset_Rpot_warrntyI;
            // 
            // Dset_Rpot_warrntyI
            // 
            this.Dset_Rpot_warrntyI.DataSetName = "Dset_Rpot_warrntyI";
            this.Dset_Rpot_warrntyI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rpot_view_Warrnty
            // 
            this.Rpot_view_Warrnty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Rpot_view_Warrnty.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_warrnty_found_ItemBindingSource;
            this.Rpot_view_Warrnty.LocalReport.DataSources.Add(reportDataSource1);
            this.Rpot_view_Warrnty.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_warrntyI.rdlc";
            this.Rpot_view_Warrnty.Location = new System.Drawing.Point(0, 0);
            this.Rpot_view_Warrnty.Name = "Rpot_view_Warrnty";
            this.Rpot_view_Warrnty.Size = new System.Drawing.Size(632, 582);
            this.Rpot_view_Warrnty.TabIndex = 87;
            // 
            // tbl_warrnty_found_ItemTableAdapter
            // 
            this.tbl_warrnty_found_ItemTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_WarrantyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 582);
            this.Controls.Add(this.Rpot_view_Warrnty);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_WarrantyItem";
            this.Text = "Rpot_WarrantyItem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_WarrantyItem_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_WarrantyItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_warrnty_found_ItemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dset_Rpot_warrntyI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpot_view_Warrnty;
        private System.Windows.Forms.BindingSource tbl_warrnty_found_ItemBindingSource;
        private Dset_Rpot_warrntyI Dset_Rpot_warrntyI;
        private Dset_Rpot_warrntyITableAdapters.tbl_warrnty_found_ItemTableAdapter tbl_warrnty_found_ItemTableAdapter;
    }
}