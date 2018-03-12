namespace Inventory_System
{
    partial class Froget_Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_Security_Answer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_security_question = new System.Windows.Forms.ComboBox();
            this.panel_fget = new System.Windows.Forms.Panel();
            this.lbl_error = new System.Windows.Forms.Label();
            this.txt_unme = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_recvr = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel_fget.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Froget Your Deatils?";
            // 
            // btn_ok
            // 
            this.btn_ok.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_ok.Location = new System.Drawing.Point(231, 193);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(64, 24);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "OK";
            this.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_close.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btn_close.Location = new System.Drawing.Point(311, 193);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(64, 24);
            this.btn_close.TabIndex = 8;
            this.btn_close.Text = "Cancel";
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // txt_Security_Answer
            // 
            this.txt_Security_Answer.Location = new System.Drawing.Point(87, 87);
            this.txt_Security_Answer.Name = "txt_Security_Answer";
            this.txt_Security_Answer.Size = new System.Drawing.Size(224, 20);
            this.txt_Security_Answer.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Answer   :";
            // 
            // cbx_security_question
            // 
            this.cbx_security_question.FormattingEnabled = true;
            this.cbx_security_question.Items.AddRange(new object[] {
            "My best friend Name is?",
            "My mother Name is?",
            "My favorites teacher?"});
            this.cbx_security_question.Location = new System.Drawing.Point(87, 57);
            this.cbx_security_question.Name = "cbx_security_question";
            this.cbx_security_question.Size = new System.Drawing.Size(224, 21);
            this.cbx_security_question.TabIndex = 10;
            this.cbx_security_question.Text = "   -------------------Select your question-------------------------";
            this.cbx_security_question.Click += new System.EventHandler(this.cbx_security_question_Click);
            // 
            // panel_fget
            // 
            this.panel_fget.BackColor = System.Drawing.Color.Transparent;
            this.panel_fget.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel_fget.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_fget.Controls.Add(this.lbl_error);
            this.panel_fget.Controls.Add(this.txt_unme);
            this.panel_fget.Controls.Add(this.cbx_security_question);
            this.panel_fget.Controls.Add(this.label7);
            this.panel_fget.Controls.Add(this.label6);
            this.panel_fget.Controls.Add(this.label2);
            this.panel_fget.Controls.Add(this.txt_Security_Answer);
            this.panel_fget.Location = new System.Drawing.Point(35, 36);
            this.panel_fget.Name = "panel_fget";
            this.panel_fget.Size = new System.Drawing.Size(344, 148);
            this.panel_fget.TabIndex = 19;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(80, 119);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(231, 13);
            this.lbl_error.TabIndex = 20;
            this.lbl_error.Text = "User Name, Question, Awnser, does not match.";
            this.lbl_error.Visible = false;
            // 
            // txt_unme
            // 
            this.txt_unme.Location = new System.Drawing.Point(87, 25);
            this.txt_unme.Name = "txt_unme";
            this.txt_unme.Size = new System.Drawing.Size(114, 20);
            this.txt_unme.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "User name  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Question :";
            // 
            // btn_recvr
            // 
            this.btn_recvr.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_recvr.Location = new System.Drawing.Point(231, 193);
            this.btn_recvr.Name = "btn_recvr";
            this.btn_recvr.Size = new System.Drawing.Size(74, 24);
            this.btn_recvr.TabIndex = 20;
            this.btn_recvr.Text = "Recover";
            this.btn_recvr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_recvr.UseVisualStyleBackColor = true;
            this.btn_recvr.Visible = false;
            this.btn_recvr.Click += new System.EventHandler(this.btn_recvr_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Froget_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_close;
            this.ClientSize = new System.Drawing.Size(409, 229);
            this.Controls.Add(this.panel_fget);
            this.Controls.Add(this.btn_recvr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_close);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Froget_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Froget_Login";
            this.Load += new System.EventHandler(this.Froget_Login_Load);
            this.panel_fget.ResumeLayout(false);
            this.panel_fget.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cbx_security_question;
        private System.Windows.Forms.TextBox txt_Security_Answer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_fget;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_unme;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.Button btn_recvr;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}