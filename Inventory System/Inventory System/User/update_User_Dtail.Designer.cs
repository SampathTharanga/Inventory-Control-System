namespace Inventory_System
{
    partial class update_User_Dtail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_User_Dtail));
            this.cbx_security_q = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.checkBoxPolicy = new System.Windows.Forms.CheckBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_AddLine2 = new System.Windows.Forms.TextBox();
            this.txt_AddLine1 = new System.Windows.Forms.TextBox();
            this.txt_Mobile = new System.Windows.Forms.TextBox();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.btn_update = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_sec_answer = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip_unm = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_pas = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_mail = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider_fnme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_lnme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_mob = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_add1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_add2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_utype = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_unme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_pass = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_conform = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_ans = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_qus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_email = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_nic = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip_Nic = new System.Windows.Forms.ToolTip(this.components);
            this.btn_ret = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fnme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_lnme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_add1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_add2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_utype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_unme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_pass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_conform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_qus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nic)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_security_q
            // 
            this.cbx_security_q.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_security_q.FormattingEnabled = true;
            this.cbx_security_q.Items.AddRange(new object[] {
            "My best friend Name is?",
            "My mother Name is?",
            "My favorites teacher?"});
            this.cbx_security_q.Location = new System.Drawing.Point(128, 138);
            this.cbx_security_q.Name = "cbx_security_q";
            this.cbx_security_q.Size = new System.Drawing.Size(249, 21);
            this.cbx_security_q.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Security Question :";
            // 
            // cbxUserType
            // 
            this.cbxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "Administrator",
            "Standard User"});
            this.cbxUserType.Location = new System.Drawing.Point(128, 41);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(135, 21);
            this.cbxUserType.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "User Type            :";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(117, 51);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(135, 20);
            this.txtLastName.TabIndex = 16;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Last Name   :";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(117, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(135, 20);
            this.txtFirstName.TabIndex = 13;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "First Name  :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.Location = new System.Drawing.Point(304, 209);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Privacy Policy";
            // 
            // btn_ok
            // 
            this.btn_ok.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btn_ok.Location = new System.Drawing.Point(611, 339);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 9;
            this.btn_ok.Text = "Cancel";
            this.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // checkBoxPolicy
            // 
            this.checkBoxPolicy.AutoSize = true;
            this.checkBoxPolicy.Location = new System.Drawing.Point(24, 207);
            this.checkBoxPolicy.Name = "checkBoxPolicy";
            this.checkBoxPolicy.Size = new System.Drawing.Size(274, 17);
            this.checkBoxPolicy.TabIndex = 8;
            this.checkBoxPolicy.Text = "I agree Mars Computer System Terms of Service and";
            this.checkBoxPolicy.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(128, 106);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(135, 20);
            this.txtConfirmPassword.TabIndex = 5;
            this.txtConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfirmPassword_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Confirm Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password             :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Name          :";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(128, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(135, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(117, 206);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(135, 20);
            this.txt_Email.TabIndex = 64;
            this.txt_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Email_KeyPress);
            // 
            // txt_AddLine2
            // 
            this.txt_AddLine2.Location = new System.Drawing.Point(117, 176);
            this.txt_AddLine2.Name = "txt_AddLine2";
            this.txt_AddLine2.Size = new System.Drawing.Size(135, 20);
            this.txt_AddLine2.TabIndex = 63;
            this.txt_AddLine2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AddLine2_KeyPress);
            // 
            // txt_AddLine1
            // 
            this.txt_AddLine1.Location = new System.Drawing.Point(117, 144);
            this.txt_AddLine1.Name = "txt_AddLine1";
            this.txt_AddLine1.Size = new System.Drawing.Size(135, 20);
            this.txt_AddLine1.TabIndex = 62;
            this.txt_AddLine1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_AddLine1_KeyPress);
            // 
            // txt_Mobile
            // 
            this.txt_Mobile.Location = new System.Drawing.Point(117, 113);
            this.txt_Mobile.Name = "txt_Mobile";
            this.txt_Mobile.Size = new System.Drawing.Size(135, 20);
            this.txt_Mobile.TabIndex = 61;
            this.txt_Mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Mobile_KeyPress);
            // 
            // txt_NIC
            // 
            this.txt_NIC.Location = new System.Drawing.Point(117, 81);
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(135, 20);
            this.txt_NIC.TabIndex = 59;
            this.txt_NIC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_NIC_KeyPress);
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.AutoSize = true;
            this.lbl_User_Name.Location = new System.Drawing.Point(128, 19);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(0, 13);
            this.lbl_User_Name.TabIndex = 69;
            // 
            // btn_update
            // 
            this.btn_update.Image = global::Inventory_System.Properties.Resources.update;
            this.btn_update.Location = new System.Drawing.Point(519, 339);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 68;
            this.btn_update.Text = "Update";
            this.btn_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 86);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 53;
            this.label15.Text = "NIC      :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 213);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 48;
            this.label14.Text = "Email             :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 176);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Address Line 2 :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Mobile :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Address Line1 :";
            // 
            // txt_sec_answer
            // 
            this.txt_sec_answer.Location = new System.Drawing.Point(128, 171);
            this.txt_sec_answer.Name = "txt_sec_answer";
            this.txt_sec_answer.Size = new System.Drawing.Size(249, 20);
            this.txt_sec_answer.TabIndex = 33;
            this.txt_sec_answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sec_answer_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Answer                :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(268, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Update user Account";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.txt_AddLine2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_AddLine1);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txt_Mobile);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_NIC);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Location = new System.Drawing.Point(6, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 278);
            this.panel1.TabIndex = 70;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.lbl_User_Name);
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Controls.Add(this.txt_sec_answer);
            this.panel2.Controls.Add(this.checkBoxPolicy);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.cbx_security_q);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.cbxUserType);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtConfirmPassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Location = new System.Drawing.Point(305, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 278);
            this.panel2.TabIndex = 71;
            // 
            // toolTip_unm
            // 
            this.toolTip_unm.IsBalloon = true;
            // 
            // toolTip_pas
            // 
            this.toolTip_pas.IsBalloon = true;
            // 
            // toolTip_mail
            // 
            this.toolTip_mail.IsBalloon = true;
            // 
            // errorProvider_fnme
            // 
            this.errorProvider_fnme.ContainerControl = this;
            this.errorProvider_fnme.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_fnme.Icon")));
            // 
            // errorProvider_lnme
            // 
            this.errorProvider_lnme.ContainerControl = this;
            this.errorProvider_lnme.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_lnme.Icon")));
            // 
            // errorProvider_mob
            // 
            this.errorProvider_mob.ContainerControl = this;
            this.errorProvider_mob.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_mob.Icon")));
            // 
            // errorProvider_add1
            // 
            this.errorProvider_add1.ContainerControl = this;
            this.errorProvider_add1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_add1.Icon")));
            // 
            // errorProvider_add2
            // 
            this.errorProvider_add2.ContainerControl = this;
            this.errorProvider_add2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_add2.Icon")));
            // 
            // errorProvider_utype
            // 
            this.errorProvider_utype.ContainerControl = this;
            this.errorProvider_utype.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_utype.Icon")));
            // 
            // errorProvider_unme
            // 
            this.errorProvider_unme.ContainerControl = this;
            this.errorProvider_unme.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_unme.Icon")));
            // 
            // errorProvider_pass
            // 
            this.errorProvider_pass.ContainerControl = this;
            this.errorProvider_pass.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_pass.Icon")));
            // 
            // errorProvider_conform
            // 
            this.errorProvider_conform.ContainerControl = this;
            this.errorProvider_conform.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_conform.Icon")));
            // 
            // errorProvider_ans
            // 
            this.errorProvider_ans.ContainerControl = this;
            this.errorProvider_ans.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_ans.Icon")));
            // 
            // errorProvider_qus
            // 
            this.errorProvider_qus.ContainerControl = this;
            this.errorProvider_qus.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_qus.Icon")));
            // 
            // errorProvider_email
            // 
            this.errorProvider_email.ContainerControl = this;
            this.errorProvider_email.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_email.Icon")));
            // 
            // errorProvider_nic
            // 
            this.errorProvider_nic.ContainerControl = this;
            this.errorProvider_nic.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_nic.Icon")));
            // 
            // toolTip_Nic
            // 
            this.toolTip_Nic.IsBalloon = true;
            // 
            // btn_ret
            // 
            this.btn_ret.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btn_ret.Location = new System.Drawing.Point(427, 339);
            this.btn_ret.Name = "btn_ret";
            this.btn_ret.Size = new System.Drawing.Size(75, 23);
            this.btn_ret.TabIndex = 72;
            this.btn_ret.Text = "Reset";
            this.btn_ret.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ret.UseVisualStyleBackColor = true;
            this.btn_ret.Click += new System.EventHandler(this.btn_ret_Click);
            // 
            // update_User_Dtail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(725, 384);
            this.Controls.Add(this.btn_ret);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "update_User_Dtail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "update_User_Dtail";
            this.Load += new System.EventHandler(this.update_User_Dtail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_fnme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_lnme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_add1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_add2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_utype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_unme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_pass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_conform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_qus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_security_q;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxUserType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.CheckBox checkBoxPolicy;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_AddLine2;
        private System.Windows.Forms.TextBox txt_AddLine1;
        private System.Windows.Forms.TextBox txt_Mobile;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_sec_answer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip_unm;
        private System.Windows.Forms.ToolTip toolTip_pas;
        private System.Windows.Forms.ToolTip toolTip_mail;
        private System.Windows.Forms.ErrorProvider errorProvider_fnme;
        private System.Windows.Forms.ErrorProvider errorProvider_lnme;
        private System.Windows.Forms.ErrorProvider errorProvider_mob;
        private System.Windows.Forms.ErrorProvider errorProvider_add1;
        private System.Windows.Forms.ErrorProvider errorProvider_add2;
        private System.Windows.Forms.ErrorProvider errorProvider_utype;
        private System.Windows.Forms.ErrorProvider errorProvider_unme;
        private System.Windows.Forms.ErrorProvider errorProvider_pass;
        private System.Windows.Forms.ErrorProvider errorProvider_conform;
        private System.Windows.Forms.ErrorProvider errorProvider_ans;
        private System.Windows.Forms.ErrorProvider errorProvider_qus;
        private System.Windows.Forms.ErrorProvider errorProvider_email;
        private System.Windows.Forms.ErrorProvider errorProvider_nic;
        private System.Windows.Forms.ToolTip toolTip_Nic;
        private System.Windows.Forms.Button btn_ret;
    }
}