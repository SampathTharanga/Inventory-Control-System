namespace Inventory_System
{
    partial class Rpot_ItemList1
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
            this.tbl_Add_ItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSet_Rpot_List = new Inventory_System.DSet_Rpot_List();
            this.rpot_viewr_itm1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_Add_ItemsTableAdapter = new Inventory_System.DSet_Rpot_ListTableAdapters.tbl_Add_ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Add_ItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_List)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Add_ItemsBindingSource
            // 
            this.tbl_Add_ItemsBindingSource.DataMember = "tbl_Add_Items";
            this.tbl_Add_ItemsBindingSource.DataSource = this.DSet_Rpot_List;
            // 
            // DSet_Rpot_List
            // 
            this.DSet_Rpot_List.DataSetName = "DSet_Rpot_List";
            this.DSet_Rpot_List.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpot_viewr_itm1
            // 
            this.rpot_viewr_itm1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_Add_ItemsBindingSource;
            this.rpot_viewr_itm1.LocalReport.DataSources.Add(reportDataSource1);
            this.rpot_viewr_itm1.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_ItmList1.rdlc";
            this.rpot_viewr_itm1.Location = new System.Drawing.Point(0, 0);
            this.rpot_viewr_itm1.Name = "rpot_viewr_itm1";
            this.rpot_viewr_itm1.Size = new System.Drawing.Size(626, 538);
            this.rpot_viewr_itm1.TabIndex = 0;
            // 
            // tbl_Add_ItemsTableAdapter
            // 
            this.tbl_Add_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_ItemList1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 538);
            this.Controls.Add(this.rpot_viewr_itm1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_ItemList1";
            this.Text = "Rpot_ItemList1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_ItemList1_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_ItemList1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Add_ItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpot_viewr_itm1;
        private System.Windows.Forms.BindingSource tbl_Add_ItemsBindingSource;
        private DSet_Rpot_List DSet_Rpot_List;
        private DSet_Rpot_ListTableAdapters.tbl_Add_ItemsTableAdapter tbl_Add_ItemsTableAdapter;
    }
}