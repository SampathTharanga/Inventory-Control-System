namespace Inventory_System
{
    partial class Restor
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
            this.checkBox_custo = new System.Windows.Forms.CheckBox();
            this.checkBox_Detail = new System.Windows.Forms.CheckBox();
            this.checkBox_supp = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel_cb = new System.Windows.Forms.Panel();
            this.btn_rstor = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.panel_cb.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBox_custo
            // 
            this.checkBox_custo.AutoSize = true;
            this.checkBox_custo.Location = new System.Drawing.Point(35, 76);
            this.checkBox_custo.Name = "checkBox_custo";
            this.checkBox_custo.Size = new System.Drawing.Size(110, 17);
            this.checkBox_custo.TabIndex = 0;
            this.checkBox_custo.Text = "Customers Details";
            this.checkBox_custo.UseVisualStyleBackColor = true;
            // 
            // checkBox_Detail
            // 
            this.checkBox_Detail.AutoSize = true;
            this.checkBox_Detail.Location = new System.Drawing.Point(35, 24);
            this.checkBox_Detail.Name = "checkBox_Detail";
            this.checkBox_Detail.Size = new System.Drawing.Size(105, 17);
            this.checkBox_Detail.TabIndex = 6;
            this.checkBox_Detail.Text = "Inventory Details";
            this.checkBox_Detail.UseVisualStyleBackColor = true;
            // 
            // checkBox_supp
            // 
            this.checkBox_supp.AutoSize = true;
            this.checkBox_supp.Location = new System.Drawing.Point(35, 50);
            this.checkBox_supp.Name = "checkBox_supp";
            this.checkBox_supp.Size = new System.Drawing.Size(104, 17);
            this.checkBox_supp.TabIndex = 9;
            this.checkBox_supp.Text = "Suppliers Details";
            this.checkBox_supp.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Check All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Check None";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel_cb
            // 
            this.panel_cb.BackColor = System.Drawing.Color.Transparent;
            this.panel_cb.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel_cb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_cb.Controls.Add(this.checkBox4);
            this.panel_cb.Controls.Add(this.checkBox5);
            this.panel_cb.Controls.Add(this.checkBox1);
            this.panel_cb.Controls.Add(this.checkBox2);
            this.panel_cb.Controls.Add(this.checkBox3);
            this.panel_cb.Controls.Add(this.checkBox_supp);
            this.panel_cb.Controls.Add(this.checkBox_Detail);
            this.panel_cb.Controls.Add(this.checkBox_custo);
            this.panel_cb.Controls.Add(this.button2);
            this.panel_cb.Controls.Add(this.button1);
            this.panel_cb.Location = new System.Drawing.Point(4, 30);
            this.panel_cb.Name = "panel_cb";
            this.panel_cb.Size = new System.Drawing.Size(412, 143);
            this.panel_cb.TabIndex = 23;
            // 
            // btn_rstor
            // 
            this.btn_rstor.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btn_rstor.Location = new System.Drawing.Point(142, 188);
            this.btn_rstor.Name = "btn_rstor";
            this.btn_rstor.Size = new System.Drawing.Size(75, 24);
            this.btn_rstor.TabIndex = 24;
            this.btn_rstor.Text = "Restor";
            this.btn_rstor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rstor.UseVisualStyleBackColor = true;
            this.btn_rstor.Click += new System.EventHandler(this.btn_rstor_Click);
            // 
            // button4
            // 
            this.button4.Image = global::Inventory_System.Properties.Resources.cancel;
            this.button4.Location = new System.Drawing.Point(222, 188);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 24);
            this.button4.TabIndex = 25;
            this.button4.Text = "Cancel";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Select What are the details for Restor";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(170, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Stock Details";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(170, 25);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 17);
            this.checkBox2.TabIndex = 24;
            this.checkBox2.Text = "Items Details";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(170, 77);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(87, 17);
            this.checkBox3.TabIndex = 23;
            this.checkBox3.Text = "Order Details";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(170, 100);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(92, 17);
            this.checkBox4.TabIndex = 27;
            this.checkBox4.Text = "Payroll Details";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(35, 99);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(83, 17);
            this.checkBox5.TabIndex = 26;
            this.checkBox5.Text = "User Details";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // Restor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(428, 223);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_rstor);
            this.Controls.Add(this.panel_cb);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Restor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restor";
            this.panel_cb.ResumeLayout(false);
            this.panel_cb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_custo;
        private System.Windows.Forms.CheckBox checkBox_Detail;
        private System.Windows.Forms.CheckBox checkBox_supp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel_cb;
        private System.Windows.Forms.Button btn_rstor;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;

    }
}