namespace Inventory_System
{
    partial class Rpot_SupplierList
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
            this.tbl_AddS_SupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSet_Rpot_List = new Inventory_System.DSet_Rpot_List();
            this.Rpot_view_Supplier = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_AddS_SupplierTableAdapter = new Inventory_System.DSet_Rpot_ListTableAdapters.tbl_AddS_SupplierTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_AddS_SupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_List)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_AddS_SupplierBindingSource
            // 
            this.tbl_AddS_SupplierBindingSource.DataMember = "tbl_AddS_Supplier";
            this.tbl_AddS_SupplierBindingSource.DataSource = this.DSet_Rpot_List;
            // 
            // DSet_Rpot_List
            // 
            this.DSet_Rpot_List.DataSetName = "DSet_Rpot_List";
            this.DSet_Rpot_List.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rpot_view_Supplier
            // 
            this.Rpot_view_Supplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Rpot_view_Supplier.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_AddS_SupplierBindingSource;
            this.Rpot_view_Supplier.LocalReport.DataSources.Add(reportDataSource1);
            this.Rpot_view_Supplier.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_Supplier.rdlc";
            this.Rpot_view_Supplier.Location = new System.Drawing.Point(0, 0);
            this.Rpot_view_Supplier.Name = "Rpot_view_Supplier";
            this.Rpot_view_Supplier.Size = new System.Drawing.Size(632, 582);
            this.Rpot_view_Supplier.TabIndex = 88;
            // 
            // tbl_AddS_SupplierTableAdapter
            // 
            this.tbl_AddS_SupplierTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_SupplierList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 582);
            this.Controls.Add(this.Rpot_view_Supplier);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_SupplierList";
            this.Text = "Rpot_SupplierList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_SupplierList_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_SupplierList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_AddS_SupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpot_view_Supplier;
        private System.Windows.Forms.BindingSource tbl_AddS_SupplierBindingSource;
        private DSet_Rpot_List DSet_Rpot_List;
        private DSet_Rpot_ListTableAdapters.tbl_AddS_SupplierTableAdapter tbl_AddS_SupplierTableAdapter;
    }
}