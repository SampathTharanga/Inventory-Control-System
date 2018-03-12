namespace Inventory_System
{
    partial class wty_dtail_inconplete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wty_dtail_inconplete));
            this.btn_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_wtyCheck = new System.Windows.Forms.CheckBox();
            this.cbx_wrycond = new System.Windows.Forms.ComboBox();
            this.errorProvider_selet = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip_selet = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_selet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(544, 26);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 35;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-62, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Warraty  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 37;
            this.label1.Text = "Warranty Not Complete...!";
            // 
            // cbx_wtyCheck
            // 
            this.cbx_wtyCheck.AutoSize = true;
            this.cbx_wtyCheck.BackColor = System.Drawing.Color.Transparent;
            this.cbx_wtyCheck.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cbx_wtyCheck.Location = new System.Drawing.Point(244, 29);
            this.cbx_wtyCheck.Name = "cbx_wtyCheck";
            this.cbx_wtyCheck.Size = new System.Drawing.Size(95, 17);
            this.cbx_wtyCheck.TabIndex = 38;
            this.cbx_wtyCheck.Text = "Complete Now";
            this.cbx_wtyCheck.UseVisualStyleBackColor = false;
            this.cbx_wtyCheck.CheckedChanged += new System.EventHandler(this.cbx_wtyCheck_CheckedChanged);
            // 
            // cbx_wrycond
            // 
            this.cbx_wrycond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_wrycond.Enabled = false;
            this.cbx_wrycond.FormattingEnabled = true;
            this.cbx_wrycond.Items.AddRange(new object[] {
            "Item Rapaired",
            "New Item",
            "Another Item"});
            this.cbx_wrycond.Location = new System.Drawing.Point(379, 27);
            this.cbx_wrycond.Name = "cbx_wrycond";
            this.cbx_wrycond.Size = new System.Drawing.Size(121, 21);
            this.cbx_wrycond.TabIndex = 39;
            this.cbx_wrycond.SelectedIndexChanged += new System.EventHandler(this.cbx_wrycond_SelectedIndexChanged);
            // 
            // errorProvider_selet
            // 
            this.errorProvider_selet.ContainerControl = this;
            this.errorProvider_selet.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_selet.Icon")));
            // 
            // toolTip_selet
            // 
            this.toolTip_selet.IsBalloon = true;
            // 
            // wty_dtail_inconplete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(753, 109);
            this.Controls.Add(this.cbx_wrycond);
            this.Controls.Add(this.cbx_wtyCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "wty_dtail_inconplete";
            this.Text = "wty_dtail_inconplete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.wty_dtail_inconplete_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.wty_dtail_inconplete_FormClosed);
            this.Load += new System.EventHandler(this.wty_dtail_inconplete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_selet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbx_wtyCheck;
        private System.Windows.Forms.ComboBox cbx_wrycond;
        private System.Windows.Forms.ErrorProvider errorProvider_selet;
        private System.Windows.Forms.ToolTip toolTip_selet;
    }
}