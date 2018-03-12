namespace Inventory_System
{
    partial class Get_Sallery
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
            this.pnl_get_sal = new System.Windows.Forms.Panel();
            this.btn_histy = new System.Windows.Forms.Button();
            this.btn_month = new System.Windows.Forms.Button();
            this.lbl_m = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnl_get_sal
            // 
            this.pnl_get_sal.BackColor = System.Drawing.Color.Transparent;
            this.pnl_get_sal.Location = new System.Drawing.Point(3, 48);
            this.pnl_get_sal.Name = "pnl_get_sal";
            this.pnl_get_sal.Size = new System.Drawing.Size(761, 531);
            this.pnl_get_sal.TabIndex = 0;
            // 
            // btn_histy
            // 
            this.btn_histy.Image = global::Inventory_System.Properties.Resources.Actions_view_history_icon;
            this.btn_histy.Location = new System.Drawing.Point(93, 1);
            this.btn_histy.Name = "btn_histy";
            this.btn_histy.Size = new System.Drawing.Size(75, 24);
            this.btn_histy.TabIndex = 3;
            this.btn_histy.Text = "History";
            this.btn_histy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_histy.UseVisualStyleBackColor = true;
            this.btn_histy.Click += new System.EventHandler(this.btn_histy_Click);
            // 
            // btn_month
            // 
            this.btn_month.Image = global::Inventory_System.Properties.Resources.Ocean_Blue_History;
            this.btn_month.Location = new System.Drawing.Point(12, 1);
            this.btn_month.Name = "btn_month";
            this.btn_month.Size = new System.Drawing.Size(75, 24);
            this.btn_month.TabIndex = 2;
            this.btn_month.Text = "Month";
            this.btn_month.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_month.UseVisualStyleBackColor = true;
            this.btn_month.Click += new System.EventHandler(this.btn_month_Click);
            // 
            // lbl_m
            // 
            this.lbl_m.AutoSize = true;
            this.lbl_m.BackColor = System.Drawing.Color.Transparent;
            this.lbl_m.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_m.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_m.Location = new System.Drawing.Point(289, 9);
            this.lbl_m.Name = "lbl_m";
            this.lbl_m.Size = new System.Drawing.Size(129, 18);
            this.lbl_m.TabIndex = 4;
            this.lbl_m.Text = "Received Salary";
            // 
            // Get_Sallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 584);
            this.Controls.Add(this.lbl_m);
            this.Controls.Add(this.btn_histy);
            this.Controls.Add(this.btn_month);
            this.Controls.Add(this.pnl_get_sal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Get_Sallery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Get_Sallery";
            this.Load += new System.EventHandler(this.Get_Sallery_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_get_sal;
        private System.Windows.Forms.Button btn_histy;
        private System.Windows.Forms.Button btn_month;
        private System.Windows.Forms.Label lbl_m;
    }
}