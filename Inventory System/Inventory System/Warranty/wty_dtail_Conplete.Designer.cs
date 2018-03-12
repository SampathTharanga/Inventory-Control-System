namespace Inventory_System
{
    partial class wty_dtail_Conplete
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
            this.lbl_wtyCompleted = new System.Windows.Forms.Label();
            this.dgv_wtycomplete = new System.Windows.Forms.DataGridView();
            this.lbl_itmm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_wtycomplete)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_wtyCompleted
            // 
            this.lbl_wtyCompleted.AutoSize = true;
            this.lbl_wtyCompleted.BackColor = System.Drawing.Color.Transparent;
            this.lbl_wtyCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wtyCompleted.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbl_wtyCompleted.Location = new System.Drawing.Point(30, 9);
            this.lbl_wtyCompleted.Name = "lbl_wtyCompleted";
            this.lbl_wtyCompleted.Size = new System.Drawing.Size(144, 18);
            this.lbl_wtyCompleted.TabIndex = 27;
            this.lbl_wtyCompleted.Text = "Warranty Completed";
            // 
            // dgv_wtycomplete
            // 
            this.dgv_wtycomplete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_wtycomplete.BackgroundColor = System.Drawing.Color.White;
            this.dgv_wtycomplete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_wtycomplete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_wtycomplete.GridColor = System.Drawing.Color.White;
            this.dgv_wtycomplete.Location = new System.Drawing.Point(22, 32);
            this.dgv_wtycomplete.Name = "dgv_wtycomplete";
            this.dgv_wtycomplete.Size = new System.Drawing.Size(707, 80);
            this.dgv_wtycomplete.TabIndex = 26;
            // 
            // lbl_itmm
            // 
            this.lbl_itmm.AutoSize = true;
            this.lbl_itmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_itmm.Location = new System.Drawing.Point(190, 9);
            this.lbl_itmm.Name = "lbl_itmm";
            this.lbl_itmm.Size = new System.Drawing.Size(0, 16);
            this.lbl_itmm.TabIndex = 28;
            // 
            // wty_dtail_Conplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 124);
            this.Controls.Add(this.lbl_itmm);
            this.Controls.Add(this.lbl_wtyCompleted);
            this.Controls.Add(this.dgv_wtycomplete);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wty_dtail_Conplete";
            this.Text = "wty_dtail_Conplete";
            this.Load += new System.EventHandler(this.wty_dtail_Conplete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_wtycomplete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_wtyCompleted;
        private System.Windows.Forms.DataGridView dgv_wtycomplete;
        private System.Windows.Forms.Label lbl_itmm;
    }
}