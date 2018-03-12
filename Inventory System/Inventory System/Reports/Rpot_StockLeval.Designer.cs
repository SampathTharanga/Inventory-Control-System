namespace Inventory_System
{
    partial class Rpot_StockLeval
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
            this.tbl_Item_QuntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSet_Rpot_List = new Inventory_System.DSet_Rpot_List();
            this.Rpot_view_StokLeval = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_Item_QuntityTableAdapter = new Inventory_System.DSet_Rpot_ListTableAdapters.tbl_Item_QuntityTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Item_QuntityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_List)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Item_QuntityBindingSource
            // 
            this.tbl_Item_QuntityBindingSource.DataMember = "tbl_Item_Quntity";
            this.tbl_Item_QuntityBindingSource.DataSource = this.DSet_Rpot_List;
            // 
            // DSet_Rpot_List
            // 
            this.DSet_Rpot_List.DataSetName = "DSet_Rpot_List";
            this.DSet_Rpot_List.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rpot_view_StokLeval
            // 
            this.Rpot_view_StokLeval.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_Item_QuntityBindingSource;
            this.Rpot_view_StokLeval.LocalReport.DataSources.Add(reportDataSource1);
            this.Rpot_view_StokLeval.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_StokLeval.rdlc";
            this.Rpot_view_StokLeval.Location = new System.Drawing.Point(0, 5);
            this.Rpot_view_StokLeval.Name = "Rpot_view_StokLeval";
            this.Rpot_view_StokLeval.Size = new System.Drawing.Size(632, 575);
            this.Rpot_view_StokLeval.TabIndex = 59;
            // 
            // tbl_Item_QuntityTableAdapter
            // 
            this.tbl_Item_QuntityTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_StockLeval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 582);
            this.Controls.Add(this.Rpot_view_StokLeval);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_StockLeval";
            this.Text = "Rpot_StockLeval";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_StockLeval_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_StockLeval_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Item_QuntityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpot_view_StokLeval;
        private System.Windows.Forms.BindingSource tbl_Item_QuntityBindingSource;
        private DSet_Rpot_List DSet_Rpot_List;
        private DSet_Rpot_ListTableAdapters.tbl_Item_QuntityTableAdapter tbl_Item_QuntityTableAdapter;
    }
}