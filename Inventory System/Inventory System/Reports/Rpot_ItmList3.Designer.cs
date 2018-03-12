namespace Inventory_System
{
    partial class Rpot_ItmList3
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
            this.rpot_viewr_itm3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSet_Rpot_ItmList3 = new Inventory_System.DSet_Rpot_ItmList3();
            this.tbl_Add_ItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Add_ItemsTableAdapter = new Inventory_System.DSet_Rpot_ItmList3TableAdapters.tbl_Add_ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_ItmList3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Add_ItemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpot_viewr_itm3
            // 
            this.rpot_viewr_itm3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_Add_ItemsBindingSource;
            this.rpot_viewr_itm3.LocalReport.DataSources.Add(reportDataSource1);
            this.rpot_viewr_itm3.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_ItmList3.rdlc";
            this.rpot_viewr_itm3.Location = new System.Drawing.Point(0, 0);
            this.rpot_viewr_itm3.Name = "rpot_viewr_itm3";
            this.rpot_viewr_itm3.Size = new System.Drawing.Size(626, 538);
            this.rpot_viewr_itm3.TabIndex = 2;
            // 
            // DSet_Rpot_ItmList3
            // 
            this.DSet_Rpot_ItmList3.DataSetName = "DSet_Rpot_ItmList3";
            this.DSet_Rpot_ItmList3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Add_ItemsBindingSource
            // 
            this.tbl_Add_ItemsBindingSource.DataMember = "tbl_Add_Items";
            this.tbl_Add_ItemsBindingSource.DataSource = this.DSet_Rpot_ItmList3;
            // 
            // tbl_Add_ItemsTableAdapter
            // 
            this.tbl_Add_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_ItmList3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 538);
            this.Controls.Add(this.rpot_viewr_itm3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_ItmList3";
            this.Text = "Rpot_ItmList3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_ItmList3_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_ItmList3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_ItmList3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Add_ItemsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpot_viewr_itm3;
        private System.Windows.Forms.BindingSource tbl_Add_ItemsBindingSource;
        private DSet_Rpot_ItmList3 DSet_Rpot_ItmList3;
        private DSet_Rpot_ItmList3TableAdapters.tbl_Add_ItemsTableAdapter tbl_Add_ItemsTableAdapter;
    }
}