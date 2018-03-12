namespace Inventory_System
{
    partial class Rpot_SalesRefList
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
            this.Rpot_view_SaleRef = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // Rpot_view_SaleRef
            // 
            this.Rpot_view_SaleRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Rpot_view_SaleRef.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rpot_view_SaleRef.Location = new System.Drawing.Point(0, 0);
            this.Rpot_view_SaleRef.Name = "Rpot_view_SaleRef";
            this.Rpot_view_SaleRef.Size = new System.Drawing.Size(632, 582);
            this.Rpot_view_SaleRef.TabIndex = 89;
            // 
            // Rpot_SalesRefList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 582);
            this.Controls.Add(this.Rpot_view_SaleRef);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_SalesRefList";
            this.Text = "Rpot_SalesRefList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_SalesRefList_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer Rpot_view_SaleRef;
    }
}