namespace Inventory_System
{
    partial class Uc_recovary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_comPass = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_unnmm = new System.Windows.Forms.Label();
            this.cbx_security_question = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Security_Answer = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txt_comPass
            // 
            this.txt_comPass.Location = new System.Drawing.Point(104, 58);
            this.txt_comPass.Name = "txt_comPass";
            this.txt_comPass.Size = new System.Drawing.Size(178, 20);
            this.txt_comPass.TabIndex = 27;
            this.txt_comPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_comPass_KeyPress);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(104, 28);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(178, 20);
            this.txt_pass.TabIndex = 25;
            this.txt_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_pass_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "New Password   :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Conform             :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "User Name         :";
            // 
            // lbl_unnmm
            // 
            this.lbl_unnmm.AutoSize = true;
            this.lbl_unnmm.Location = new System.Drawing.Point(101, 7);
            this.lbl_unnmm.Name = "lbl_unnmm";
            this.lbl_unnmm.Size = new System.Drawing.Size(69, 13);
            this.lbl_unnmm.TabIndex = 29;
            this.lbl_unnmm.Text = "User Name   ";
            // 
            // cbx_security_question
            // 
            this.cbx_security_question.FormattingEnabled = true;
            this.cbx_security_question.Items.AddRange(new object[] {
            "My best friend Name is?",
            "My mother Name is?",
            "My favorites teacher?"});
            this.cbx_security_question.Location = new System.Drawing.Point(104, 84);
            this.cbx_security_question.Name = "cbx_security_question";
            this.cbx_security_question.Size = new System.Drawing.Size(224, 21);
            this.cbx_security_question.TabIndex = 30;
            this.cbx_security_question.Text = "   -------------------Select your question-------------------------";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Question            :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Answer              :";
            // 
            // txt_Security_Answer
            // 
            this.txt_Security_Answer.Location = new System.Drawing.Point(104, 113);
            this.txt_Security_Answer.Name = "txt_Security_Answer";
            this.txt_Security_Answer.Size = new System.Drawing.Size(224, 20);
            this.txt_Security_Answer.TabIndex = 33;
            this.txt_Security_Answer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Security_Answer_KeyPress);
            // 
            // btn_ok
            // 
            this.btn_ok.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_ok.Location = new System.Drawing.Point(195, 148);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(64, 24);
            this.btn_ok.TabIndex = 34;
            this.btn_ok.Text = "OK";
            this.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_close
            // 
            this.btn_close.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btn_close.Location = new System.Drawing.Point(265, 148);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(64, 24);
            this.btn_close.TabIndex = 35;
            this.btn_close.Text = "Cancel";
            this.btn_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Uc_recovary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.cbx_security_question);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Security_Answer);
            this.Controls.Add(this.lbl_unnmm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_comPass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Name = "Uc_recovary";
            this.Size = new System.Drawing.Size(344, 181);
            this.Load += new System.EventHandler(this.Uc_recovary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_comPass;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_unnmm;
        private System.Windows.Forms.ComboBox cbx_security_question;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Security_Answer;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ToolTip toolTip1;

    }
}
