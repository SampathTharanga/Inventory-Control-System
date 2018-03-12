namespace Inventory_System
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.timer_start = new System.Windows.Forms.Timer(this.components);
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_newuser = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.L_lbl_froget = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(97, 40);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(117, 20);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.Transparent;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(15, 40);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(82, 15);
            this.labelUserName.TabIndex = 13;
            this.labelUserName.Text = "User Name  : ";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = true;
            this.txtPassword.Location = new System.Drawing.Point(97, 70);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(117, 20);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(16, 72);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(79, 15);
            this.labelPassword.TabIndex = 12;
            this.labelPassword.Text = "Password     :";
            // 
            // btn_login
            // 
            this.btn_login.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_login.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_login.Location = new System.Drawing.Point(156, 99);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(64, 24);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "Login";
            this.btn_login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_newuser
            // 
            this.btn_newuser.Image = global::Inventory_System.Properties.Resources.new_user;
            this.btn_newuser.Location = new System.Drawing.Point(90, 99);
            this.btn_newuser.Name = "btn_newuser";
            this.btn_newuser.Size = new System.Drawing.Size(64, 24);
            this.btn_newuser.TabIndex = 15;
            this.btn_newuser.Text = "New";
            this.btn_newuser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_newuser.UseVisualStyleBackColor = true;
            this.btn_newuser.Click += new System.EventHandler(this.btn_newuser_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // L_lbl_froget
            // 
            this.L_lbl_froget.AutoSize = true;
            this.L_lbl_froget.BackColor = System.Drawing.Color.Transparent;
            this.L_lbl_froget.Location = new System.Drawing.Point(25, 105);
            this.L_lbl_froget.Name = "L_lbl_froget";
            this.L_lbl_froget.Size = new System.Drawing.Size(43, 13);
            this.L_lbl_froget.TabIndex = 17;
            this.L_lbl_froget.TabStop = true;
            this.L_lbl_froget.Text = "Froget?";
            this.L_lbl_froget.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.L_lbl_froget_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt)
                        | System.Windows.Forms.Keys.M)));
            this.adminToolStripMenuItem.ShowShortcutKeys = false;
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.adminToolStripMenuItem.Text = "admin";
            this.adminToolStripMenuItem.Visible = false;
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // toolTip2
            // 
            this.toolTip2.IsBalloon = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = global::Inventory_System.Properties.Resources._456;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(240, 135);
            this.Controls.Add(this.L_lbl_froget);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.btn_newuser);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer_start;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_newuser;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel L_lbl_froget;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

