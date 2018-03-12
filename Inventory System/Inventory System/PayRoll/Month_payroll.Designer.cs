namespace Inventory_System
{
    partial class Month_payroll
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
            this.panel_payroll = new System.Windows.Forms.Panel();
            this.btn_month = new System.Windows.Forms.Button();
            this.btn_histy = new System.Windows.Forms.Button();
            this.lbl_now_d = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel_payroll
            // 
            this.panel_payroll.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.panel_payroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_payroll.Location = new System.Drawing.Point(0, 28);
            this.panel_payroll.Name = "panel_payroll";
            this.panel_payroll.Size = new System.Drawing.Size(768, 553);
            this.panel_payroll.TabIndex = 0;
            // 
            // btn_month
            // 
            this.btn_month.Image = global::Inventory_System.Properties.Resources.Ocean_Blue_History;
            this.btn_month.Location = new System.Drawing.Point(0, 1);
            this.btn_month.Name = "btn_month";
            this.btn_month.Size = new System.Drawing.Size(79, 24);
            this.btn_month.TabIndex = 0;
            this.btn_month.Text = "Month";
            this.btn_month.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_month.UseVisualStyleBackColor = true;
            this.btn_month.Click += new System.EventHandler(this.btn_month_Click);
            // 
            // btn_histy
            // 
            this.btn_histy.Image = global::Inventory_System.Properties.Resources.Actions_view_history_icon;
            this.btn_histy.Location = new System.Drawing.Point(94, 1);
            this.btn_histy.Name = "btn_histy";
            this.btn_histy.Size = new System.Drawing.Size(79, 24);
            this.btn_histy.TabIndex = 1;
            this.btn_histy.Text = "History";
            this.btn_histy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_histy.UseVisualStyleBackColor = true;
            this.btn_histy.Click += new System.EventHandler(this.btn_histy_Click);
            // 
            // lbl_now_d
            // 
            this.lbl_now_d.AutoSize = true;
            this.lbl_now_d.BackColor = System.Drawing.Color.Transparent;
            this.lbl_now_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.55F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_now_d.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_now_d.Location = new System.Drawing.Point(274, 9);
            this.lbl_now_d.Name = "lbl_now_d";
            this.lbl_now_d.Size = new System.Drawing.Size(0, 16);
            this.lbl_now_d.TabIndex = 2;
            // 
            // Month_payroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 584);
            this.Controls.Add(this.lbl_now_d);
            this.Controls.Add(this.btn_histy);
            this.Controls.Add(this.panel_payroll);
            this.Controls.Add(this.btn_month);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Month_payroll";
            this.Text = "Month_payroll";
            this.Load += new System.EventHandler(this.Month_payroll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_payroll;
        private System.Windows.Forms.Button btn_month;
        private System.Windows.Forms.Button btn_histy;
        private System.Windows.Forms.Label lbl_now_d;

    }
}