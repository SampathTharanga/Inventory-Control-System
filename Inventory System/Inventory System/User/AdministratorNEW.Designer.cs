namespace Inventory_System
{
    partial class AdministratorNEW
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
            this.txt_AD_UserN = new System.Windows.Forms.TextBox();
            this.txt_AD_Pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txt_AD_UserN
            // 
            this.txt_AD_UserN.Location = new System.Drawing.Point(97, 40);
            this.txt_AD_UserN.Name = "txt_AD_UserN";
            this.txt_AD_UserN.Size = new System.Drawing.Size(117, 20);
            this.txt_AD_UserN.TabIndex = 0;
            this.txt_AD_UserN.TextChanged += new System.EventHandler(this.txt_AD_UserN_TextChanged);
            this.txt_AD_UserN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AD_UserN_KeyPress);
            // 
            // txt_AD_Pass
            // 
            this.txt_AD_Pass.Location = new System.Drawing.Point(97, 70);
            this.txt_AD_Pass.Name = "txt_AD_Pass";
            this.txt_AD_Pass.PasswordChar = '*';
            this.txt_AD_Pass.Size = new System.Drawing.Size(117, 20);
            this.txt_AD_Pass.TabIndex = 1;
            this.txt_AD_Pass.TextChanged += new System.EventHandler(this.txt_AD_Pass_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(27, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Administrator Deatilas";
            // 
            // button1
            // 
            this.button1.Image = global::Inventory_System.Properties.Resources.ok;
            this.button1.Location = new System.Drawing.Point(156, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Image = global::Inventory_System.Properties.Resources.back1;
            this.button2.Location = new System.Drawing.Point(90, 99);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(64, 24);
            this.button2.TabIndex = 6;
            this.button2.Text = "Back";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(15, 40);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(82, 15);
            this.labelUserName.TabIndex = 15;
            this.labelUserName.Text = "User Name  : ";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(16, 72);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(82, 15);
            this.labelPassword.TabIndex = 14;
            this.labelPassword.Text = "Password     : ";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            // 
            // toolTip3
            // 
            this.toolTip3.IsBalloon = true;
            // 
            // AdministratorNEW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.adminlog;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(240, 135);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_AD_Pass);
            this.Controls.Add(this.txt_AD_UserN);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdministratorNEW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "User Account";
            this.Load += new System.EventHandler(this.AdministratorNEW_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_AD_UserN;
        private System.Windows.Forms.TextBox txt_AD_Pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
    }
}