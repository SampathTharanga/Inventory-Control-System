namespace Inventory_System
{
    partial class Rpot_Income
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
            this.pnl_Rpot_Invoice = new System.Windows.Forms.Panel();
            this.cbx_payComple = new System.Windows.Forms.ComboBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // pnl_Rpot_Invoice
            // 
            this.pnl_Rpot_Invoice.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Rpot_Invoice.Location = new System.Drawing.Point(1, 37);
            this.pnl_Rpot_Invoice.Name = "pnl_Rpot_Invoice";
            this.pnl_Rpot_Invoice.Size = new System.Drawing.Size(630, 540);
            this.pnl_Rpot_Invoice.TabIndex = 72;
            // 
            // cbx_payComple
            // 
            this.cbx_payComple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_payComple.FormattingEnabled = true;
            this.cbx_payComple.Items.AddRange(new object[] {
            "All Invoice",
            "Complete",
            "Not Complete"});
            this.cbx_payComple.Location = new System.Drawing.Point(386, 6);
            this.cbx_payComple.Name = "cbx_payComple";
            this.cbx_payComple.Size = new System.Drawing.Size(92, 21);
            this.cbx_payComple.TabIndex = 71;
            this.cbx_payComple.SelectedIndexChanged += new System.EventHandler(this.cbx_payComple_SelectedIndexChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_reset.Location = new System.Drawing.Point(540, 6);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(66, 24);
            this.btn_reset.TabIndex = 70;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(202, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "To Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "From Date  :";
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_to.Location = new System.Drawing.Point(256, 8);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker_to.TabIndex = 67;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_From.Location = new System.Drawing.Point(66, 8);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker_From.TabIndex = 66;
            // 
            // Rpot_Income
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 582);
            this.Controls.Add(this.pnl_Rpot_Invoice);
            this.Controls.Add(this.cbx_payComple);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.dateTimePicker_From);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_Income";
            this.Text = "Rpot_Income";
            this.Load += new System.EventHandler(this.Rpot_Income_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Rpot_Invoice;
        private System.Windows.Forms.ComboBox cbx_payComple;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
    }
}