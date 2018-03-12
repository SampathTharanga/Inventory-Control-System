namespace Inventory_System
{
    partial class Rpot_ReceivedStock
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
            this.btn_view = new System.Windows.Forms.Button();
            this.pnl_Rpot_ReceiveS = new System.Windows.Forms.Panel();
            this.cbxAddItemSupplier = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(356, 11);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(63, 23);
            this.btn_view.TabIndex = 78;
            this.btn_view.Text = "View ";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // pnl_Rpot_ReceiveS
            // 
            this.pnl_Rpot_ReceiveS.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Rpot_ReceiveS.Location = new System.Drawing.Point(7, 48);
            this.pnl_Rpot_ReceiveS.Name = "pnl_Rpot_ReceiveS";
            this.pnl_Rpot_ReceiveS.Size = new System.Drawing.Size(623, 523);
            this.pnl_Rpot_ReceiveS.TabIndex = 77;
            // 
            // cbxAddItemSupplier
            // 
            this.cbxAddItemSupplier.FormattingEnabled = true;
            this.cbxAddItemSupplier.Location = new System.Drawing.Point(504, 15);
            this.cbxAddItemSupplier.Name = "cbxAddItemSupplier";
            this.cbxAddItemSupplier.Size = new System.Drawing.Size(121, 21);
            this.cbxAddItemSupplier.TabIndex = 76;
            this.cbxAddItemSupplier.SelectedIndexChanged += new System.EventHandler(this.cbxAddItemSupplier_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(445, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 75;
            this.label10.Text = "Supplier : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(187, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "To Date  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "From Date  : ";
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_to.Location = new System.Drawing.Point(246, 14);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(95, 20);
            this.dateTimePicker_to.TabIndex = 72;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_From.Location = new System.Drawing.Point(72, 14);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker_From.TabIndex = 71;
            // 
            // Rpot_ReceivedStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 582);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.pnl_Rpot_ReceiveS);
            this.Controls.Add(this.cbxAddItemSupplier);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_to);
            this.Controls.Add(this.dateTimePicker_From);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_ReceivedStock";
            this.Text = "Rpot_ReceivedStock";
            this.Load += new System.EventHandler(this.Rpot_ReceivedStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Panel pnl_Rpot_ReceiveS;
        private System.Windows.Forms.ComboBox cbxAddItemSupplier;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;

    }
}