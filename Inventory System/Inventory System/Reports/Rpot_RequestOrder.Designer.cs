namespace Inventory_System
{
    partial class Rpot_RequestOrder
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
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.cbx_reqstrodr = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.pn_RqstOdr = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(553, 31);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(67, 23);
            this.btn_reset.TabIndex = 86;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(553, 2);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(67, 23);
            this.btn_view.TabIndex = 85;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // cbx_reqstrodr
            // 
            this.cbx_reqstrodr.FormattingEnabled = true;
            this.cbx_reqstrodr.Items.AddRange(new object[] {
            "Request",
            "Oder Received"});
            this.cbx_reqstrodr.Location = new System.Drawing.Point(424, 18);
            this.cbx_reqstrodr.Name = "cbx_reqstrodr";
            this.cbx_reqstrodr.Size = new System.Drawing.Size(98, 21);
            this.cbx_reqstrodr.TabIndex = 84;
            this.cbx_reqstrodr.SelectedIndexChanged += new System.EventHandler(this.cbx_reqstrodr_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(379, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 83;
            this.label10.Text = "Order   : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(194, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "To Date  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(0, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 82;
            this.label1.Text = "From Date  : ";
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_to.Location = new System.Drawing.Point(252, 19);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker_to.TabIndex = 80;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_From.Location = new System.Drawing.Point(66, 19);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker_From.TabIndex = 79;
            // 
            // pn_RqstOdr
            // 
            this.pn_RqstOdr.BackColor = System.Drawing.Color.Transparent;
            this.pn_RqstOdr.Location = new System.Drawing.Point(3, 60);
            this.pn_RqstOdr.Name = "pn_RqstOdr";
            this.pn_RqstOdr.Size = new System.Drawing.Size(617, 510);
            this.pn_RqstOdr.TabIndex = 87;
            // 
            // Rpot_RequestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 582);
            this.Controls.Add(this.pn_RqstOdr);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.cbx_reqstrodr);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.dateTimePicker_From);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_RequestOrder";
            this.Text = "Rpot_RequestOrder";
            this.Load += new System.EventHandler(this.Rpot_RequestOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.ComboBox cbx_reqstrodr;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.Panel pn_RqstOdr;
    }
}