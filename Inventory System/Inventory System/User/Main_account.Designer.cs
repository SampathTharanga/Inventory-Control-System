namespace Inventory_System
{
    partial class Main_account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_account));
            this.pnl_acc_main = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_User_Name = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Con_Password = new System.Windows.Forms.TextBox();
            this.txt_Sec_q_Ans = new System.Windows.Forms.TextBox();
            this.cbx_security_q = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_check = new System.Windows.Forms.ToolTip(this.components);
            this.pnl_acc_main.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_acc_main
            // 
            this.pnl_acc_main.BackColor = System.Drawing.Color.Transparent;
            this.pnl_acc_main.Controls.Add(this.label7);
            this.pnl_acc_main.Controls.Add(this.label1);
            this.pnl_acc_main.Controls.Add(this.panel1);
            this.pnl_acc_main.Controls.Add(this.btn_Clear);
            this.pnl_acc_main.Controls.Add(this.btn_OK);
            this.pnl_acc_main.Controls.Add(this.btn_Cancel);
            this.pnl_acc_main.Location = new System.Drawing.Point(278, 1);
            this.pnl_acc_main.Name = "pnl_acc_main";
            this.pnl_acc_main.Size = new System.Drawing.Size(368, 367);
            this.pnl_acc_main.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 48);
            this.label7.TabIndex = 69;
            this.label7.Text = "Welcome to the Inventory Control System \r\nThis is First use of Inventory control." +
                " Create\r\nOwner Account to handel the System.  ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(127, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 57;
            this.label1.Text = "Owner Account";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txt_User_Name);
            this.panel1.Controls.Add(this.txt_Password);
            this.panel1.Controls.Add(this.txt_Con_Password);
            this.panel1.Controls.Add(this.txt_Sec_q_Ans);
            this.panel1.Controls.Add(this.cbx_security_q);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(39, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 180);
            this.panel1.TabIndex = 68;
            // 
            // txt_User_Name
            // 
            this.txt_User_Name.Location = new System.Drawing.Point(123, 15);
            this.txt_User_Name.Name = "txt_User_Name";
            this.txt_User_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_User_Name.TabIndex = 0;
            this.txt_User_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_User_Name_KeyPress);
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(123, 46);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Password.TabIndex = 2;
            this.txt_Password.UseSystemPasswordChar = true;
            this.txt_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Password_KeyPress);
            // 
            // txt_Con_Password
            // 
            this.txt_Con_Password.Location = new System.Drawing.Point(123, 76);
            this.txt_Con_Password.Name = "txt_Con_Password";
            this.txt_Con_Password.PasswordChar = '*';
            this.txt_Con_Password.Size = new System.Drawing.Size(100, 20);
            this.txt_Con_Password.TabIndex = 3;
            this.txt_Con_Password.UseSystemPasswordChar = true;
            this.txt_Con_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Con_Password_KeyPress);
            // 
            // txt_Sec_q_Ans
            // 
            this.txt_Sec_q_Ans.Location = new System.Drawing.Point(123, 136);
            this.txt_Sec_q_Ans.Name = "txt_Sec_q_Ans";
            this.txt_Sec_q_Ans.Size = new System.Drawing.Size(147, 20);
            this.txt_Sec_q_Ans.TabIndex = 5;
            this.txt_Sec_q_Ans.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Sec_q_Ans_KeyPress);
            // 
            // cbx_security_q
            // 
            this.cbx_security_q.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_security_q.FormattingEnabled = true;
            this.cbx_security_q.Items.AddRange(new object[] {
            "My best friend Name is?",
            "My mother Name is?",
            "My favorites teacher?"});
            this.cbx_security_q.Location = new System.Drawing.Point(123, 105);
            this.cbx_security_q.Name = "cbx_security_q";
            this.cbx_security_q.Size = new System.Drawing.Size(147, 21);
            this.cbx_security_q.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(24, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Answer                 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(24, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "Security Question :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(24, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Confirm Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(24, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Password              :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(24, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "User Name           :";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btn_Clear.Location = new System.Drawing.Point(66, 314);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 24);
            this.btn_Clear.TabIndex = 56;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_OK.Location = new System.Drawing.Point(154, 314);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 24);
            this.btn_OK.TabIndex = 1;
            this.btn_OK.Text = "OK";
            this.btn_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(242, 314);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 24);
            this.btn_Cancel.TabIndex = 54;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider3.Icon")));
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            this.errorProvider4.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider4.Icon")));
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            this.errorProvider5.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider5.Icon")));
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // toolTip_check
            // 
            this.toolTip_check.IsBalloon = true;
            // 
            // Main_account
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.account_main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(647, 368);
            this.Controls.Add(this.pnl_acc_main);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main_account";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Creations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_account_FormClosed);
            this.Load += new System.EventHandler(this.Main_account_Load);
            this.pnl_acc_main.ResumeLayout(false);
            this.pnl_acc_main.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_acc_main;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_User_Name;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Con_Password;
        private System.Windows.Forms.TextBox txt_Sec_q_Ans;
        private System.Windows.Forms.ComboBox cbx_security_q;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip_check;

    }
}