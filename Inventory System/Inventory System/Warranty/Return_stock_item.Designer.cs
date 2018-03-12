namespace Inventory_System
{
    partial class Return_stock_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Return_stock_item));
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_granTotal = new System.Windows.Forms.TextBox();
            this.cbx_payMethord = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_discount = new System.Windows.Forms.TextBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_balnce = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_paid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.TextBox();
            this.lbl_CurrentMoney = new System.Windows.Forms.Label();
            this.lbl_balnce = new System.Windows.Forms.Label();
            this.txt_bcrd = new System.Windows.Forms.TextBox();
            this.button_ResetItem = new System.Windows.Forms.Button();
            this.button_deleteitem = new System.Windows.Forms.Button();
            this.button_SearchItem = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_chnge = new System.Windows.Forms.Button();
            this.dgvFindItem = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip_tax = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_dis = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip_paid = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipselect = new System.Windows.Forms.ToolTip(this.components);
            this.cb_printi = new System.Windows.Forms.CheckBox();
            this.toolTip_barcode = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(300, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 16);
            this.label8.TabIndex = 35;
            this.label8.Text = "Return Item";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(23, 265);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 85;
            this.label16.Text = "Grand Total :";
            // 
            // txt_granTotal
            // 
            this.txt_granTotal.Location = new System.Drawing.Point(91, 262);
            this.txt_granTotal.Name = "txt_granTotal";
            this.txt_granTotal.Size = new System.Drawing.Size(164, 20);
            this.txt_granTotal.TabIndex = 86;
            // 
            // cbx_payMethord
            // 
            this.cbx_payMethord.FormattingEnabled = true;
            this.cbx_payMethord.Items.AddRange(new object[] {
            "Chash",
            "Cheque",
            "Credit card"});
            this.cbx_payMethord.Location = new System.Drawing.Point(369, 315);
            this.cbx_payMethord.Name = "cbx_payMethord";
            this.cbx_payMethord.Size = new System.Drawing.Size(130, 21);
            this.cbx_payMethord.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(284, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Method            : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(153, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 81;
            this.label13.Text = "Discount :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(23, 293);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 13);
            this.label14.TabIndex = 79;
            this.label14.Text = "Tax-Vat      :";
            // 
            // txt_discount
            // 
            this.txt_discount.Location = new System.Drawing.Point(211, 289);
            this.txt_discount.Name = "txt_discount";
            this.txt_discount.Size = new System.Drawing.Size(44, 20);
            this.txt_discount.TabIndex = 82;
            this.txt_discount.Click += new System.EventHandler(this.txt_discount_Click);
            this.txt_discount.TextChanged += new System.EventHandler(this.txt_discount_TextChanged);
            this.txt_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_discount_KeyPress);
            this.txt_discount.MouseLeave += new System.EventHandler(this.txt_discount_MouseLeave);
            // 
            // txt_tax
            // 
            this.txt_tax.Location = new System.Drawing.Point(91, 290);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(53, 20);
            this.txt_tax.TabIndex = 84;
            this.txt_tax.Click += new System.EventHandler(this.txt_tax_Click);
            this.txt_tax.TextChanged += new System.EventHandler(this.txt_tax_TextChanged);
            this.txt_tax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tax_KeyPress);
            this.txt_tax.MouseLeave += new System.EventHandler(this.txt_tax_MouseLeave);
            // 
            // txt_balnce
            // 
            this.txt_balnce.Enabled = false;
            this.txt_balnce.Location = new System.Drawing.Point(609, 286);
            this.txt_balnce.Name = "txt_balnce";
            this.txt_balnce.Size = new System.Drawing.Size(131, 20);
            this.txt_balnce.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(540, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 77;
            this.label5.Text = "Balance    : ";
            // 
            // txt_paid
            // 
            this.txt_paid.Enabled = false;
            this.txt_paid.Location = new System.Drawing.Point(609, 258);
            this.txt_paid.Name = "txt_paid";
            this.txt_paid.Size = new System.Drawing.Size(131, 20);
            this.txt_paid.TabIndex = 76;
            this.txt_paid.Click += new System.EventHandler(this.txt_paid_Click);
            this.txt_paid.TextChanged += new System.EventHandler(this.txt_paid_TextChanged);
            this.txt_paid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_paid_KeyPress);
            this.txt_paid.MouseLeave += new System.EventHandler(this.txt_paid_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(540, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 75;
            this.label6.Text = "New paid  :  ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(23, 321);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 15);
            this.label15.TabIndex = 73;
            this.label15.Text = "Total      :";
            // 
            // txt_Total
            // 
            this.txt_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Total.Location = new System.Drawing.Point(89, 321);
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.Size = new System.Drawing.Size(163, 21);
            this.txt_Total.TabIndex = 74;
            // 
            // lbl_CurrentMoney
            // 
            this.lbl_CurrentMoney.AutoSize = true;
            this.lbl_CurrentMoney.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CurrentMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CurrentMoney.ForeColor = System.Drawing.Color.Green;
            this.lbl_CurrentMoney.Location = new System.Drawing.Point(366, 261);
            this.lbl_CurrentMoney.Name = "lbl_CurrentMoney";
            this.lbl_CurrentMoney.Size = new System.Drawing.Size(0, 15);
            this.lbl_CurrentMoney.TabIndex = 72;
            // 
            // lbl_balnce
            // 
            this.lbl_balnce.AutoSize = true;
            this.lbl_balnce.BackColor = System.Drawing.Color.Transparent;
            this.lbl_balnce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_balnce.ForeColor = System.Drawing.Color.Red;
            this.lbl_balnce.Location = new System.Drawing.Point(366, 288);
            this.lbl_balnce.Name = "lbl_balnce";
            this.lbl_balnce.Size = new System.Drawing.Size(0, 15);
            this.lbl_balnce.TabIndex = 71;
            // 
            // txt_bcrd
            // 
            this.txt_bcrd.Location = new System.Drawing.Point(12, 40);
            this.txt_bcrd.Name = "txt_bcrd";
            this.txt_bcrd.Size = new System.Drawing.Size(146, 20);
            this.txt_bcrd.TabIndex = 70;
            this.txt_bcrd.Text = "Enter BarCode";
            this.txt_bcrd.Click += new System.EventHandler(this.txt_bcrd_Click);
            this.txt_bcrd.TextChanged += new System.EventHandler(this.txt_bcrd_TextChanged);
            // 
            // button_ResetItem
            // 
            this.button_ResetItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ResetItem.Image = global::Inventory_System.Properties.Resources.refresh;
            this.button_ResetItem.Location = new System.Drawing.Point(623, 37);
            this.button_ResetItem.Name = "button_ResetItem";
            this.button_ResetItem.Size = new System.Drawing.Size(88, 24);
            this.button_ResetItem.TabIndex = 69;
            this.button_ResetItem.Text = "Reset Item";
            this.button_ResetItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_ResetItem.UseVisualStyleBackColor = true;
            this.button_ResetItem.Click += new System.EventHandler(this.button_ResetItem_Click);
            // 
            // button_deleteitem
            // 
            this.button_deleteitem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_deleteitem.Image = global::Inventory_System.Properties.Resources.delete;
            this.button_deleteitem.Location = new System.Drawing.Point(529, 37);
            this.button_deleteitem.Name = "button_deleteitem";
            this.button_deleteitem.Size = new System.Drawing.Size(88, 24);
            this.button_deleteitem.TabIndex = 68;
            this.button_deleteitem.Text = "delete Item";
            this.button_deleteitem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_deleteitem.UseVisualStyleBackColor = true;
            this.button_deleteitem.Click += new System.EventHandler(this.button_deleteitem_Click);
            // 
            // button_SearchItem
            // 
            this.button_SearchItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_SearchItem.Location = new System.Drawing.Point(169, 37);
            this.button_SearchItem.Name = "button_SearchItem";
            this.button_SearchItem.Size = new System.Drawing.Size(95, 24);
            this.button_SearchItem.TabIndex = 67;
            this.button_SearchItem.Text = "Advance Search";
            this.button_SearchItem.UseVisualStyleBackColor = true;
            this.button_SearchItem.Click += new System.EventHandler(this.button_SearchItem_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(284, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Balance           : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(284, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 64;
            this.label9.Text = "Current Money : ";
            // 
            // btn_chnge
            // 
            this.btn_chnge.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_chnge.Location = new System.Drawing.Point(658, 321);
            this.btn_chnge.Name = "btn_chnge";
            this.btn_chnge.Size = new System.Drawing.Size(82, 23);
            this.btn_chnge.TabIndex = 63;
            this.btn_chnge.Text = "Ok";
            this.btn_chnge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_chnge.UseVisualStyleBackColor = true;
            this.btn_chnge.Click += new System.EventHandler(this.btn_chnge_Click);
            // 
            // dgvFindItem
            // 
            this.dgvFindItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvFindItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFindItem.Location = new System.Drawing.Point(12, 68);
            this.dgvFindItem.Name = "dgvFindItem";
            this.dgvFindItem.Size = new System.Drawing.Size(745, 175);
            this.dgvFindItem.TabIndex = 60;
            this.dgvFindItem.DataSourceChanged += new System.EventHandler(this.dgvFindItem_DataSourceChanged);
            this.dgvFindItem.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindItem_CellValueChanged);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Image = global::Inventory_System.Properties.Resources.cancel;
            this.button2.Location = new System.Drawing.Point(658, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 24);
            this.button2.TabIndex = 61;
            this.button2.Text = "Cancel";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            this.errorProvider3.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider3.Icon")));
            // 
            // toolTip_tax
            // 
            this.toolTip_tax.AutoPopDelay = 5000;
            this.toolTip_tax.InitialDelay = 100;
            this.toolTip_tax.IsBalloon = true;
            this.toolTip_tax.ReshowDelay = 100;
            // 
            // toolTip_dis
            // 
            this.toolTip_dis.AutoPopDelay = 5000;
            this.toolTip_dis.InitialDelay = 100;
            this.toolTip_dis.IsBalloon = true;
            this.toolTip_dis.ReshowDelay = 100;
            // 
            // toolTip_paid
            // 
            this.toolTip_paid.AutoPopDelay = 5000;
            this.toolTip_paid.InitialDelay = 100;
            this.toolTip_paid.IsBalloon = true;
            this.toolTip_paid.ReshowDelay = 100;
            // 
            // toolTipselect
            // 
            this.toolTipselect.AutoPopDelay = 5000;
            this.toolTipselect.InitialDelay = 100;
            this.toolTipselect.IsBalloon = true;
            this.toolTipselect.ReshowDelay = 100;
            // 
            // cb_printi
            // 
            this.cb_printi.AutoSize = true;
            this.cb_printi.BackColor = System.Drawing.Color.Transparent;
            this.cb_printi.Checked = true;
            this.cb_printi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_printi.Location = new System.Drawing.Point(543, 321);
            this.cb_printi.Name = "cb_printi";
            this.cb_printi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_printi.Size = new System.Drawing.Size(85, 17);
            this.cb_printi.TabIndex = 87;
            this.cb_printi.Text = "Print Invoice";
            this.cb_printi.UseVisualStyleBackColor = false;
            // 
            // toolTip_barcode
            // 
            this.toolTip_barcode.IsBalloon = true;
            // 
            // Return_stock_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(769, 376);
            this.Controls.Add(this.cb_printi);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_granTotal);
            this.Controls.Add(this.cbx_payMethord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_discount);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(this.txt_balnce);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_paid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.lbl_CurrentMoney);
            this.Controls.Add(this.lbl_balnce);
            this.Controls.Add(this.txt_bcrd);
            this.Controls.Add(this.button_ResetItem);
            this.Controls.Add(this.button_deleteitem);
            this.Controls.Add(this.button_SearchItem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_chnge);
            this.Controls.Add(this.dgvFindItem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(775, 400);
            this.MinimumSize = new System.Drawing.Size(775, 400);
            this.Name = "Return_stock_item";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sharp Creations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Return_stock_item_FormClosed);
            this.Load += new System.EventHandler(this.Return_stock_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_granTotal;
        private System.Windows.Forms.ComboBox cbx_payMethord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_discount;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_balnce;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_paid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_Total;
        private System.Windows.Forms.Label lbl_CurrentMoney;
        private System.Windows.Forms.Label lbl_balnce;
        private System.Windows.Forms.TextBox txt_bcrd;
        private System.Windows.Forms.Button button_ResetItem;
        private System.Windows.Forms.Button button_deleteitem;
        private System.Windows.Forms.Button button_SearchItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_chnge;
        private System.Windows.Forms.DataGridView dgvFindItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ToolTip toolTip_tax;
        private System.Windows.Forms.ToolTip toolTip_dis;
        private System.Windows.Forms.ToolTip toolTip_paid;
        private System.Windows.Forms.ToolTip toolTipselect;
        private System.Windows.Forms.CheckBox cb_printi;
        private System.Windows.Forms.ToolTip toolTip_barcode;
    }
}