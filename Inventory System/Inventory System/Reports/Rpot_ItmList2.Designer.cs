namespace Inventory_System
{
    partial class Rpot_ItmList2
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
            this.rpot_viewr_itm2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_Add_ItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSet_Rpot_Itmlist2 = new Inventory_System.DSet_Rpot_Itmlist2();
            this.tbl_Add_ItemsTableAdapter = new Inventory_System.DSet_Rpot_Itmlist2TableAdapters.tbl_Add_ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Add_ItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_Itmlist2)).BeginInit();
            this.SuspendLayout();
            // 
            // rpot_viewr_itm2
            // 
            this.rpot_viewr_itm2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_Add_ItemsBindingSource;
            this.rpot_viewr_itm2.LocalReport.DataSources.Add(reportDataSource1);
            this.rpot_viewr_itm2.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_ItmList2.rdlc";
            this.rpot_viewr_itm2.Location = new System.Drawing.Point(0, 0);
            this.rpot_viewr_itm2.Name = "rpot_viewr_itm2";
            this.rpot_viewr_itm2.Size = new System.Drawing.Size(626, 538);
            this.rpot_viewr_itm2.TabIndex = 1;
            // 
            // tbl_Add_ItemsBindingSource
            // 
            this.tbl_Add_ItemsBindingSource.DataMember = "tbl_Add_Items";
            this.tbl_Add_ItemsBindingSource.DataSource = this.DSet_Rpot_Itmlist2;
            // 
            // DSet_Rpot_Itmlist2
            // 
            this.DSet_Rpot_Itmlist2.DataSetName = "DSet_Rpot_Itmlist2";
            this.DSet_Rpot_Itmlist2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_Add_ItemsTableAdapter
            // 
            this.tbl_Add_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_ItmList2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 538);
            this.Controls.Add(this.rpot_viewr_itm2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_ItmList2";
            this.Text = "Rpot_ItmList2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_ItmList2_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_ItmList2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Add_ItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_Itmlist2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpot_viewr_itm2;
        private System.Windows.Forms.BindingSource tbl_Add_ItemsBindingSource;
        private DSet_Rpot_Itmlist2 DSet_Rpot_Itmlist2;
        private DSet_Rpot_Itmlist2TableAdapters.tbl_Add_ItemsTableAdapter tbl_Add_ItemsTableAdapter;
    }
}