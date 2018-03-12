namespace Inventory_System
{
    partial class Tget_settings
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_usernn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tgtrte = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ok_to_select = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_ok_to_all = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip_tgt = new System.Windows.Forms.ToolTip(this.components);
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.txt_userid);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cbx_usernn);
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(433, 65);
            this.panel4.TabIndex = 18;
            // 
            // txt_userid
            // 
            this.txt_userid.Location = new System.Drawing.Point(296, 23);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(112, 20);
            this.txt_userid.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "User ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "User Name";
            // 
            // cbx_usernn
            // 
            this.cbx_usernn.FormattingEnabled = true;
            this.cbx_usernn.Location = new System.Drawing.Point(95, 23);
            this.cbx_usernn.Name = "cbx_usernn";
            this.cbx_usernn.Size = new System.Drawing.Size(114, 21);
            this.cbx_usernn.TabIndex = 13;
            this.cbx_usernn.SelectedIndexChanged += new System.EventHandler(this.cbx_usernn_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Commission Rate :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(203, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 26);
            this.label4.TabIndex = 19;
            this.label4.Text = "Enter Target rate that ues to calculate extra salary\r\nwhen SaleRef completed own " +
                " Target";
            // 
            // txt_tgtrte
            // 
            this.txt_tgtrte.Location = new System.Drawing.Point(107, 95);
            this.txt_tgtrte.Name = "txt_tgtrte";
            this.txt_tgtrte.Size = new System.Drawing.Size(61, 20);
            this.txt_tgtrte.TabIndex = 20;
            this.txt_tgtrte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tgtrte_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "%";
            // 
            // btn_ok_to_select
            // 
            this.btn_ok_to_select.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_ok_to_select.Location = new System.Drawing.Point(21, 152);
            this.btn_ok_to_select.Name = "btn_ok_to_select";
            this.btn_ok_to_select.Size = new System.Drawing.Size(135, 23);
            this.btn_ok_to_select.TabIndex = 21;
            this.btn_ok_to_select.Text = "Set to Selected User";
            this.btn_ok_to_select.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ok_to_select.UseVisualStyleBackColor = true;
            this.btn_ok_to_select.Click += new System.EventHandler(this.btn_ok_to_select_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel5.Location = new System.Drawing.Point(-2, 130);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(470, 1);
            this.panel5.TabIndex = 55;
            // 
            // btn_ok_to_all
            // 
            this.btn_ok_to_all.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_ok_to_all.Location = new System.Drawing.Point(169, 151);
            this.btn_ok_to_all.Name = "btn_ok_to_all";
            this.btn_ok_to_all.Size = new System.Drawing.Size(135, 23);
            this.btn_ok_to_all.TabIndex = 56;
            this.btn_ok_to_all.Text = "Set to All User";
            this.btn_ok_to_all.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ok_to_all.UseVisualStyleBackColor = true;
            this.btn_ok_to_all.Click += new System.EventHandler(this.btn_ok_to_all_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Inventory_System.Properties.Resources.cancel;
            this.button2.Location = new System.Drawing.Point(376, 151);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 23);
            this.button2.TabIndex = 57;
            this.button2.Text = "Cancel";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip_tgt
            // 
            this.toolTip_tgt.IsBalloon = true;
            // 
            // Tget_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(467, 206);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ok_to_all);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btn_ok_to_select);
            this.Controls.Add(this.txt_tgtrte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Tget_settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Target settings";
            this.Load += new System.EventHandler(this.Tget_settings_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_usernn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tgtrte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ok_to_select;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_ok_to_all;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolTip toolTip_tgt;
    }
}