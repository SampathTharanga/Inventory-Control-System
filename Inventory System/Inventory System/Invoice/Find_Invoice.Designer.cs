namespace Inventory_System
{
    partial class Find_Invoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find_Invoice));
            this.dgv_Invoice = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_print = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFindInvoInvoNo = new System.Windows.Forms.TextBox();
            this.txtFindInvoBarcode = new System.Windows.Forms.TextBox();
            this.btnFindInvoCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_payComple = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip_Invoice = new System.Windows.Forms.ToolTip(this.components);
            this.tool_tip_emty = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Invoice
            // 
            this.dgv_Invoice.AllowUserToDeleteRows = false;
            this.dgv_Invoice.AllowUserToResizeColumns = false;
            this.dgv_Invoice.AllowUserToResizeRows = false;
            this.dgv_Invoice.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Invoice.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Invoice.Location = new System.Drawing.Point(22, 153);
            this.dgv_Invoice.Name = "dgv_Invoice";
            this.dgv_Invoice.Size = new System.Drawing.Size(722, 254);
            this.dgv_Invoice.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(354, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = " Invoice";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 487);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // btn_print
            // 
            this.btn_print.Image = global::Inventory_System.Properties.Resources.print;
            this.btn_print.Location = new System.Drawing.Point(303, 431);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(75, 24);
            this.btn_print.TabIndex = 25;
            this.btn_print.Text = "Print";
            this.btn_print.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(392, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 24);
            this.button2.TabIndex = 26;
            this.button2.Text = "Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_From.Location = new System.Drawing.Point(111, 18);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker_From.TabIndex = 0;
            this.dateTimePicker_From.ValueChanged += new System.EventHandler(this.dateTimePicker_From_ValueChanged);
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_to.Location = new System.Drawing.Point(114, 55);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker_to.TabIndex = 1;
            this.dateTimePicker_to.ValueChanged += new System.EventHandler(this.dateTimePicker_to_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To Date     : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(448, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ivoice No     : ";
            // 
            // txtFindInvoInvoNo
            // 
            this.txtFindInvoInvoNo.Location = new System.Drawing.Point(534, 19);
            this.txtFindInvoInvoNo.Name = "txtFindInvoInvoNo";
            this.txtFindInvoInvoNo.Size = new System.Drawing.Size(100, 20);
            this.txtFindInvoInvoNo.TabIndex = 4;
            this.txtFindInvoInvoNo.TextChanged += new System.EventHandler(this.txtFindInvoInvoNo_TextChanged);
            this.txtFindInvoInvoNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindInvoInvoNo_KeyPress);
            // 
            // txtFindInvoBarcode
            // 
            this.txtFindInvoBarcode.Location = new System.Drawing.Point(534, 49);
            this.txtFindInvoBarcode.Multiline = true;
            this.txtFindInvoBarcode.Name = "txtFindInvoBarcode";
            this.txtFindInvoBarcode.Size = new System.Drawing.Size(161, 41);
            this.txtFindInvoBarcode.TabIndex = 6;
            this.txtFindInvoBarcode.TextChanged += new System.EventHandler(this.txtFindInvoBarcode_TextChanged);
            this.txtFindInvoBarcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindInvoBarcode_KeyPress);
            // 
            // btnFindInvoCancel
            // 
            this.btnFindInvoCancel.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btnFindInvoCancel.Location = new System.Drawing.Point(263, 52);
            this.btnFindInvoCancel.Name = "btnFindInvoCancel";
            this.btnFindInvoCancel.Size = new System.Drawing.Size(72, 24);
            this.btnFindInvoCancel.TabIndex = 8;
            this.btnFindInvoCancel.Text = "Reset";
            this.btnFindInvoCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindInvoCancel.UseVisualStyleBackColor = true;
            this.btnFindInvoCancel.Click += new System.EventHandler(this.btnFindInvoCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(448, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description  : ";
            // 
            // cbx_payComple
            // 
            this.cbx_payComple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_payComple.FormattingEnabled = true;
            this.cbx_payComple.Items.AddRange(new object[] {
            "All Invoice",
            "Payment Complete",
            "Payment InComplete"});
            this.cbx_payComple.Location = new System.Drawing.Point(250, 21);
            this.cbx_payComple.Name = "cbx_payComple";
            this.cbx_payComple.Size = new System.Drawing.Size(114, 21);
            this.cbx_payComple.TabIndex = 10;
            this.cbx_payComple.Text = "All Invoice";
            this.cbx_payComple.SelectedIndexChanged += new System.EventHandler(this.cbx_payComple_SelectedIndexChanged);
            this.cbx_payComple.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_payComple_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cbx_payComple);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnFindInvoCancel);
            this.panel1.Controls.Add(this.txtFindInvoBarcode);
            this.panel1.Controls.Add(this.txtFindInvoInvoNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dateTimePicker_to);
            this.panel1.Controls.Add(this.dateTimePicker_From);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 105);
            this.panel1.TabIndex = 28;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // toolTip_Invoice
            // 
            this.toolTip_Invoice.IsBalloon = true;
            // 
            // tool_tip_emty
            // 
            this.tool_tip_emty.IsBalloon = true;
            // 
            // Find_Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_Invoice);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Find_Invoice";
            this.Text = "Find_Invoice";
            this.Load += new System.EventHandler(this.Find_Invoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Invoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFindInvoInvoNo;
        private System.Windows.Forms.TextBox txtFindInvoBarcode;
        private System.Windows.Forms.Button btnFindInvoCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_payComple;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip_Invoice;
        private System.Windows.Forms.ToolTip tool_tip_emty;
    }
}