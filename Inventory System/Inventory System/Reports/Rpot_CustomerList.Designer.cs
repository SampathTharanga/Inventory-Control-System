namespace Inventory_System
{
    partial class Rpot_CustomerList
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
            this.tbl_Add_CustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSet_Rpot_List = new Inventory_System.DSet_Rpot_List();
            this.Rpot_view_Customer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tbl_Add_CustomerTableAdapter = new Inventory_System.DSet_Rpot_ListTableAdapters.tbl_Add_CustomerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Add_CustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_List)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_Add_CustomerBindingSource
            // 
            this.tbl_Add_CustomerBindingSource.DataMember = "tbl_Add_Customer";
            this.tbl_Add_CustomerBindingSource.DataSource = this.DSet_Rpot_List;
            // 
            // DSet_Rpot_List
            // 
            this.DSet_Rpot_List.DataSetName = "DSet_Rpot_List";
            this.DSet_Rpot_List.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Rpot_view_Customer
            // 
            this.Rpot_view_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Rpot_view_Customer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.tbl_Add_CustomerBindingSource;
            this.Rpot_view_Customer.LocalReport.DataSources.Add(reportDataSource1);
            this.Rpot_view_Customer.LocalReport.ReportEmbeddedResource = "Inventory_System.Rpot_Customer.rdlc";
            this.Rpot_view_Customer.Location = new System.Drawing.Point(0, 0);
            this.Rpot_view_Customer.Name = "Rpot_view_Customer";
            this.Rpot_view_Customer.Size = new System.Drawing.Size(632, 582);
            this.Rpot_view_Customer.TabIndex = 89;
            // 
            // tbl_Add_CustomerTableAdapter
            // 
            this.tbl_Add_CustomerTableAdapter.ClearBeforeFill = true;
            // 
            // Rpot_CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 582);
            this.Controls.Add(this.Rpot_view_Customer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_CustomerList";
            this.Text = "Rpot_CustomerList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_CustomerList_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_Add_CustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSet_Rpot_List)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpot_view_Customer;
        private System.Windows.Forms.BindingSource tbl_Add_CustomerBindingSource;
        private DSet_Rpot_List DSet_Rpot_List;
        private DSet_Rpot_ListTableAdapters.tbl_Add_CustomerTableAdapter tbl_Add_CustomerTableAdapter;
    }
}