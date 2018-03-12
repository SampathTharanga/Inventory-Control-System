namespace Inventory_System
{
    partial class Get_sal_history
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Get_sal_history));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_adition_reced = new System.Windows.Forms.Label();
            this.lbl_rest = new System.Windows.Forms.Label();
            this.lbl_reced_sal = new System.Windows.Forms.Label();
            this.lbl_tot_sal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_usernn = new System.Windows.Forms.ComboBox();
            this.dgv_get_histry = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_year = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_month = new System.Windows.Forms.ComboBox();
            this.errorProvider_Unme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_yer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_mon = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_get_histry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Unme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_yer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Inventory_System.Properties.Resources.fotter_soft;
            this.pictureBox1.Location = new System.Drawing.Point(3, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_adition_reced
            // 
            this.lbl_adition_reced.AutoSize = true;
            this.lbl_adition_reced.BackColor = System.Drawing.Color.Transparent;
            this.lbl_adition_reced.ForeColor = System.Drawing.Color.Red;
            this.lbl_adition_reced.Location = new System.Drawing.Point(512, 51);
            this.lbl_adition_reced.Name = "lbl_adition_reced";
            this.lbl_adition_reced.Size = new System.Drawing.Size(0, 13);
            this.lbl_adition_reced.TabIndex = 44;
            // 
            // lbl_rest
            // 
            this.lbl_rest.AutoSize = true;
            this.lbl_rest.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rest.ForeColor = System.Drawing.Color.Green;
            this.lbl_rest.Location = new System.Drawing.Point(512, 24);
            this.lbl_rest.Name = "lbl_rest";
            this.lbl_rest.Size = new System.Drawing.Size(0, 13);
            this.lbl_rest.TabIndex = 43;
            // 
            // lbl_reced_sal
            // 
            this.lbl_reced_sal.AutoSize = true;
            this.lbl_reced_sal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_reced_sal.ForeColor = System.Drawing.Color.Blue;
            this.lbl_reced_sal.Location = new System.Drawing.Point(221, 51);
            this.lbl_reced_sal.Name = "lbl_reced_sal";
            this.lbl_reced_sal.Size = new System.Drawing.Size(0, 13);
            this.lbl_reced_sal.TabIndex = 42;
            // 
            // lbl_tot_sal
            // 
            this.lbl_tot_sal.AutoSize = true;
            this.lbl_tot_sal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tot_sal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_tot_sal.Location = new System.Drawing.Point(221, 23);
            this.lbl_tot_sal.Name = "lbl_tot_sal";
            this.lbl_tot_sal.Size = new System.Drawing.Size(0, 13);
            this.lbl_tot_sal.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "User Name";
            // 
            // cbx_usernn
            // 
            this.cbx_usernn.FormattingEnabled = true;
            this.cbx_usernn.Location = new System.Drawing.Point(116, 21);
            this.cbx_usernn.Name = "cbx_usernn";
            this.cbx_usernn.Size = new System.Drawing.Size(114, 21);
            this.cbx_usernn.TabIndex = 33;
            this.cbx_usernn.SelectedIndexChanged += new System.EventHandler(this.cbx_usernn_SelectedIndexChanged);
            // 
            // dgv_get_histry
            // 
            this.dgv_get_histry.BackgroundColor = System.Drawing.Color.White;
            this.dgv_get_histry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_get_histry.Location = new System.Drawing.Point(94, 85);
            this.dgv_get_histry.Name = "dgv_get_histry";
            this.dgv_get_histry.Size = new System.Drawing.Size(572, 233);
            this.dgv_get_histry.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(258, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Year";
            // 
            // cbx_year
            // 
            this.cbx_year.FormattingEnabled = true;
            this.cbx_year.Location = new System.Drawing.Point(326, 21);
            this.cbx_year.Name = "cbx_year";
            this.cbx_year.Size = new System.Drawing.Size(114, 21);
            this.cbx_year.TabIndex = 47;
            this.cbx_year.SelectedIndexChanged += new System.EventHandler(this.cbx_year_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(475, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Month";
            // 
            // cbx_month
            // 
            this.cbx_month.FormattingEnabled = true;
            this.cbx_month.Location = new System.Drawing.Point(543, 21);
            this.cbx_month.Name = "cbx_month";
            this.cbx_month.Size = new System.Drawing.Size(114, 21);
            this.cbx_month.TabIndex = 49;
            this.cbx_month.SelectedIndexChanged += new System.EventHandler(this.cbx_month_SelectedIndexChanged);
            // 
            // errorProvider_Unme
            // 
            this.errorProvider_Unme.ContainerControl = this;
            this.errorProvider_Unme.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_Unme.Icon")));
            // 
            // errorProvider_yer
            // 
            this.errorProvider_yer.ContainerControl = this;
            this.errorProvider_yer.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_yer.Icon")));
            // 
            // errorProvider_mon
            // 
            this.errorProvider_mon.ContainerControl = this;
            this.errorProvider_mon.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_mon.Icon")));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbx_month);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbx_year);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbx_usernn);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 72);
            this.panel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbl_adition_reced);
            this.panel2.Controls.Add(this.lbl_rest);
            this.panel2.Controls.Add(this.lbl_reced_sal);
            this.panel2.Controls.Add(this.lbl_tot_sal);
            this.panel2.Location = new System.Drawing.Point(3, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 106);
            this.panel2.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(388, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Additional Received  : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(117, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Received salary   : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(388, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Remaining                 : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(116, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Total Salary          : ";
            // 
            // Get_sal_history
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(761, 531);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_get_histry);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Get_sal_history";
            this.Text = "Get_sal_history";
            this.Load += new System.EventHandler(this.Get_sal_history_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_get_histry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Unme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_yer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_adition_reced;
        private System.Windows.Forms.Label lbl_rest;
        private System.Windows.Forms.Label lbl_reced_sal;
        private System.Windows.Forms.Label lbl_tot_sal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_usernn;
        private System.Windows.Forms.DataGridView dgv_get_histry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_year;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_month;
        private System.Windows.Forms.ErrorProvider errorProvider_Unme;
        private System.Windows.Forms.ErrorProvider errorProvider_yer;
        private System.Windows.Forms.ErrorProvider errorProvider_mon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}