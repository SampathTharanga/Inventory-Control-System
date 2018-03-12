namespace Inventory_System
{
    partial class Warranty_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Warranty_Details));
            this.txt_itmnme = new System.Windows.Forms.TextBox();
            this.txt_cusnnm = new System.Windows.Forms.TextBox();
            this.txt_invoNo = new System.Windows.Forms.TextBox();
            this.txt_serial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_viewWarty = new System.Windows.Forms.DataGridView();
            this.pnl_wtyDtail = new System.Windows.Forms.Panel();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.errorProvider_save = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewWarty)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_save)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_itmnme
            // 
            this.txt_itmnme.Location = new System.Drawing.Point(107, 53);
            this.txt_itmnme.Name = "txt_itmnme";
            this.txt_itmnme.Size = new System.Drawing.Size(111, 20);
            this.txt_itmnme.TabIndex = 22;
            this.txt_itmnme.TextChanged += new System.EventHandler(this.txt_itmnme_TextChanged);
            this.txt_itmnme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_itmnme_KeyPress);
            // 
            // txt_cusnnm
            // 
            this.txt_cusnnm.Location = new System.Drawing.Point(334, 52);
            this.txt_cusnnm.Name = "txt_cusnnm";
            this.txt_cusnnm.Size = new System.Drawing.Size(144, 20);
            this.txt_cusnnm.TabIndex = 20;
            this.txt_cusnnm.TextChanged += new System.EventHandler(this.txt_cusnnm_TextChanged);
            this.txt_cusnnm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cusnnm_KeyPress);
            // 
            // txt_invoNo
            // 
            this.txt_invoNo.Location = new System.Drawing.Point(107, 22);
            this.txt_invoNo.Name = "txt_invoNo";
            this.txt_invoNo.Size = new System.Drawing.Size(111, 20);
            this.txt_invoNo.TabIndex = 21;
            this.txt_invoNo.TextChanged += new System.EventHandler(this.txt_invoNo_TextChanged);
            this.txt_invoNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_invoNo_KeyPress);
            // 
            // txt_serial
            // 
            this.txt_serial.Location = new System.Drawing.Point(334, 23);
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(144, 20);
            this.txt_serial.TabIndex = 19;
            this.txt_serial.TextChanged += new System.EventHandler(this.txt_serial_TextChanged);
            this.txt_serial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_serial_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(35, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Item Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(269, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Customer  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(35, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Invoice No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(269, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Serial No  :";
            // 
            // dgv_viewWarty
            // 
            this.dgv_viewWarty.BackgroundColor = System.Drawing.Color.White;
            this.dgv_viewWarty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_viewWarty.Location = new System.Drawing.Point(12, 95);
            this.dgv_viewWarty.Name = "dgv_viewWarty";
            this.dgv_viewWarty.Size = new System.Drawing.Size(737, 217);
            this.dgv_viewWarty.TabIndex = 23;
            this.dgv_viewWarty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_viewWarty_CellClick);
            // 
            // pnl_wtyDtail
            // 
            this.pnl_wtyDtail.BackColor = System.Drawing.Color.Transparent;
            this.pnl_wtyDtail.Location = new System.Drawing.Point(1, 316);
            this.pnl_wtyDtail.Name = "pnl_wtyDtail";
            this.pnl_wtyDtail.Size = new System.Drawing.Size(761, 124);
            this.pnl_wtyDtail.TabIndex = 32;
            // 
            // btn_ok
            // 
            this.btn_ok.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_ok.Location = new System.Drawing.Point(289, 451);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 33;
            this.btn_ok.Text = "Ok";
            this.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btn_cancel.Location = new System.Drawing.Point(398, 451);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 34;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_itmnme);
            this.panel1.Controls.Add(this.txt_cusnnm);
            this.panel1.Controls.Add(this.txt_invoNo);
            this.panel1.Controls.Add(this.txt_serial);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 87);
            this.panel1.TabIndex = 35;
            // 
            // btn_reset
            // 
            this.btn_reset.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btn_reset.Location = new System.Drawing.Point(588, 49);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 24);
            this.btn_reset.TabIndex = 24;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Inventory_System.Properties.Resources.find;
            this.button1.Location = new System.Drawing.Point(588, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "search";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // errorProvider_save
            // 
            this.errorProvider_save.ContainerControl = this;
            this.errorProvider_save.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_save.Icon")));
            // 
            // Warranty_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(762, 487);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.pnl_wtyDtail);
            this.Controls.Add(this.dgv_viewWarty);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Warranty_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sharp Creation";
            this.Load += new System.EventHandler(this.Warranty_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_viewWarty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_save)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_itmnme;
        private System.Windows.Forms.TextBox txt_cusnnm;
        private System.Windows.Forms.TextBox txt_invoNo;
        private System.Windows.Forms.TextBox txt_serial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_viewWarty;
        private System.Windows.Forms.Panel pnl_wtyDtail;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider_save;
    }
}