namespace Inventory_System
{
    partial class Add_Items
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Items));
            this.cbx_wrty_duretion = new System.Windows.Forms.ComboBox();
            this.cbx_wrty_number = new System.Windows.Forms.ComboBox();
            this.cb_warnty = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_add_details = new System.Windows.Forms.Button();
            this.lbl_tp = new System.Windows.Forms.Label();
            this.cbxAddItemBrande = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_itemNo = new System.Windows.Forms.Label();
            this.txtAddItemSerial = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddItemBarcode = new System.Windows.Forms.TextBox();
            this.cbxAddItemSupplier = new System.Windows.Forms.ComboBox();
            this.cbxAddItemItemType = new System.Windows.Forms.ComboBox();
            this.cbxAddItemSubCatogory = new System.Windows.Forms.ComboBox();
            this.cbxAddItemCatogory = new System.Windows.Forms.ComboBox();
            this.txtAddItemDiscription = new System.Windows.Forms.TextBox();
            this.txtAddItemTaxRate = new System.Windows.Forms.TextBox();
            this.txtAddItemSalesPrice = new System.Windows.Forms.TextBox();
            this.txtAddItemItemName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddItemReset = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAddItemAddItem = new System.Windows.Forms.Button();
            this.btnAddItemCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ep_iname = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_isalePrz = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_ipuchsPriz = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_isupp = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_ictogry = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_isubCotory = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_ibrnd = new System.Windows.Forms.ErrorProvider(this.components);
            this.tp_seril_barcobe = new System.Windows.Forms.ToolTip(this.components);
            this.tp_required = new System.Windows.Forms.ToolTip(this.components);
            this.tp_ad_details = new System.Windows.Forms.ToolTip(this.components);
            this.ep_wanty = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.toolTip_check = new System.Windows.Forms.ToolTip(this.components);
            this.cbx_stok = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_add_qty = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_a_qty = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_p_piz = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_iname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_isalePrz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_ipuchsPriz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_isupp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_ictogry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_isubCotory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_ibrnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_wanty)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbx_wrty_duretion
            // 
            this.cbx_wrty_duretion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_wrty_duretion.Enabled = false;
            this.cbx_wrty_duretion.FormattingEnabled = true;
            this.cbx_wrty_duretion.Items.AddRange(new object[] {
            "Days",
            "Weeks",
            "Months",
            "Years"});
            this.cbx_wrty_duretion.Location = new System.Drawing.Point(189, 243);
            this.cbx_wrty_duretion.Name = "cbx_wrty_duretion";
            this.cbx_wrty_duretion.Size = new System.Drawing.Size(88, 21);
            this.cbx_wrty_duretion.TabIndex = 10;
            this.cbx_wrty_duretion.SelectedIndexChanged += new System.EventHandler(this.cbx_wrty_duretion_SelectedIndexChanged);
            // 
            // cbx_wrty_number
            // 
            this.cbx_wrty_number.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_wrty_number.Enabled = false;
            this.cbx_wrty_number.FormattingEnabled = true;
            this.cbx_wrty_number.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbx_wrty_number.Location = new System.Drawing.Point(139, 243);
            this.cbx_wrty_number.Name = "cbx_wrty_number";
            this.cbx_wrty_number.Size = new System.Drawing.Size(44, 21);
            this.cbx_wrty_number.TabIndex = 9;
            this.cbx_wrty_number.SelectedIndexChanged += new System.EventHandler(this.cbx_wrty_number_SelectedIndexChanged);
            // 
            // cb_warnty
            // 
            this.cb_warnty.AutoSize = true;
            this.cb_warnty.Location = new System.Drawing.Point(49, 245);
            this.cb_warnty.Name = "cb_warnty";
            this.cb_warnty.Size = new System.Drawing.Size(87, 17);
            this.cb_warnty.TabIndex = 8;
            this.cb_warnty.Text = "Warranty    : ";
            this.cb_warnty.UseVisualStyleBackColor = true;
            this.cb_warnty.CheckedChanged += new System.EventHandler(this.cb_warnty_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(575, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Recent Record";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_add_details
            // 
            this.btn_add_details.Location = new System.Drawing.Point(575, 50);
            this.btn_add_details.Name = "btn_add_details";
            this.btn_add_details.Size = new System.Drawing.Size(101, 21);
            this.btn_add_details.TabIndex = 31;
            this.btn_add_details.Text = "Add Detalis";
            this.btn_add_details.UseVisualStyleBackColor = true;
            this.btn_add_details.Click += new System.EventHandler(this.btn_add_details_Click);
            this.btn_add_details.MouseEnter += new System.EventHandler(this.btn_add_details_MouseEnter);
            this.btn_add_details.MouseLeave += new System.EventHandler(this.btn_add_details_MouseLeave);
            // 
            // lbl_tp
            // 
            this.lbl_tp.AutoSize = true;
            this.lbl_tp.Location = new System.Drawing.Point(256, 20);
            this.lbl_tp.Name = "lbl_tp";
            this.lbl_tp.Size = new System.Drawing.Size(0, 13);
            this.lbl_tp.TabIndex = 21;
            // 
            // cbxAddItemBrande
            // 
            this.cbxAddItemBrande.FormattingEnabled = true;
            this.cbxAddItemBrande.Location = new System.Drawing.Point(402, 142);
            this.cbxAddItemBrande.Name = "cbxAddItemBrande";
            this.cbxAddItemBrande.Size = new System.Drawing.Size(136, 21);
            this.cbxAddItemBrande.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(309, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Brande            : ";
            // 
            // lbl_itemNo
            // 
            this.lbl_itemNo.AutoSize = true;
            this.lbl_itemNo.Location = new System.Drawing.Point(144, 47);
            this.lbl_itemNo.Name = "lbl_itemNo";
            this.lbl_itemNo.Size = new System.Drawing.Size(0, 13);
            this.lbl_itemNo.TabIndex = 1;
            // 
            // txtAddItemSerial
            // 
            this.txtAddItemSerial.Location = new System.Drawing.Point(139, 77);
            this.txtAddItemSerial.Name = "txtAddItemSerial";
            this.txtAddItemSerial.Size = new System.Drawing.Size(136, 20);
            this.txtAddItemSerial.TabIndex = 2;
            this.txtAddItemSerial.TextChanged += new System.EventHandler(this.txtAddItemSerial_TextChanged);
            this.txtAddItemSerial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddItemSerial_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(44, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Serial No           : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Barcode No    : ";
            // 
            // txtAddItemBarcode
            // 
            this.txtAddItemBarcode.Location = new System.Drawing.Point(400, 43);
            this.txtAddItemBarcode.Name = "txtAddItemBarcode";
            this.txtAddItemBarcode.Size = new System.Drawing.Size(136, 20);
            this.txtAddItemBarcode.TabIndex = 0;
            // 
            // cbxAddItemSupplier
            // 
            this.cbxAddItemSupplier.FormattingEnabled = true;
            this.cbxAddItemSupplier.Location = new System.Drawing.Point(94, 19);
            this.cbxAddItemSupplier.Name = "cbxAddItemSupplier";
            this.cbxAddItemSupplier.Size = new System.Drawing.Size(121, 21);
            this.cbxAddItemSupplier.TabIndex = 7;
            this.cbxAddItemSupplier.SelectedIndexChanged += new System.EventHandler(this.cbxAddItemSupplier_SelectedIndexChanged);
            this.cbxAddItemSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxAddItemSupplier_KeyPress);
            // 
            // cbxAddItemItemType
            // 
            this.cbxAddItemItemType.FormattingEnabled = true;
            this.cbxAddItemItemType.Location = new System.Drawing.Point(403, 174);
            this.cbxAddItemItemType.Name = "cbxAddItemItemType";
            this.cbxAddItemItemType.Size = new System.Drawing.Size(136, 21);
            this.cbxAddItemItemType.TabIndex = 14;
            this.cbxAddItemItemType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxAddItemItemType_KeyPress);
            // 
            // cbxAddItemSubCatogory
            // 
            this.cbxAddItemSubCatogory.FormattingEnabled = true;
            this.cbxAddItemSubCatogory.Location = new System.Drawing.Point(402, 108);
            this.cbxAddItemSubCatogory.Name = "cbxAddItemSubCatogory";
            this.cbxAddItemSubCatogory.Size = new System.Drawing.Size(136, 21);
            this.cbxAddItemSubCatogory.TabIndex = 12;
            this.cbxAddItemSubCatogory.TextChanged += new System.EventHandler(this.cbxAddItemSubCatogory_TextChanged);
            // 
            // cbxAddItemCatogory
            // 
            this.cbxAddItemCatogory.FormattingEnabled = true;
            this.cbxAddItemCatogory.Location = new System.Drawing.Point(402, 75);
            this.cbxAddItemCatogory.Name = "cbxAddItemCatogory";
            this.cbxAddItemCatogory.Size = new System.Drawing.Size(136, 21);
            this.cbxAddItemCatogory.TabIndex = 11;
            this.cbxAddItemCatogory.SelectedIndexChanged += new System.EventHandler(this.cbxAddItemCatogory_SelectedIndexChanged);
            this.cbxAddItemCatogory.TextChanged += new System.EventHandler(this.cbxAddItemCatogory_TextChanged);
            // 
            // txtAddItemDiscription
            // 
            this.txtAddItemDiscription.Location = new System.Drawing.Point(402, 211);
            this.txtAddItemDiscription.Multiline = true;
            this.txtAddItemDiscription.Name = "txtAddItemDiscription";
            this.txtAddItemDiscription.Size = new System.Drawing.Size(165, 78);
            this.txtAddItemDiscription.TabIndex = 15;
            this.txtAddItemDiscription.TextChanged += new System.EventHandler(this.txtAddItemDiscription_TextChanged);
            this.txtAddItemDiscription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddItemDiscription_KeyPress);
            // 
            // txtAddItemTaxRate
            // 
            this.txtAddItemTaxRate.Location = new System.Drawing.Point(141, 207);
            this.txtAddItemTaxRate.Name = "txtAddItemTaxRate";
            this.txtAddItemTaxRate.Size = new System.Drawing.Size(136, 20);
            this.txtAddItemTaxRate.TabIndex = 6;
            this.txtAddItemTaxRate.TextChanged += new System.EventHandler(this.txtAddItemTaxRate_TextChanged);
            this.txtAddItemTaxRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddItemTaxRate_KeyPress);
            // 
            // txtAddItemSalesPrice
            // 
            this.txtAddItemSalesPrice.Location = new System.Drawing.Point(141, 175);
            this.txtAddItemSalesPrice.Name = "txtAddItemSalesPrice";
            this.txtAddItemSalesPrice.Size = new System.Drawing.Size(136, 20);
            this.txtAddItemSalesPrice.TabIndex = 4;
            this.txtAddItemSalesPrice.TextChanged += new System.EventHandler(this.txtAddItemSalesPrice_TextChanged);
            this.txtAddItemSalesPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddItemSalesPrice_KeyPress);
            // 
            // txtAddItemItemName
            // 
            this.txtAddItemItemName.Location = new System.Drawing.Point(140, 111);
            this.txtAddItemItemName.Name = "txtAddItemItemName";
            this.txtAddItemItemName.Size = new System.Drawing.Size(136, 20);
            this.txtAddItemItemName.TabIndex = 3;
            this.txtAddItemItemName.TextChanged += new System.EventHandler(this.txtAddItemItemName_TextChanged);
            this.txtAddItemItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddItemItemName_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(39, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Supplier  : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Discription       : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Tax Rate          : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Item Type        : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Purchase Price : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Sub-Catogory  : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sales Price        : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(309, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Catogory         : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Item Name        : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Item No             : ";
            // 
            // btnAddItemReset
            // 
            this.btnAddItemReset.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btnAddItemReset.Location = new System.Drawing.Point(345, 463);
            this.btnAddItemReset.Name = "btnAddItemReset";
            this.btnAddItemReset.Size = new System.Drawing.Size(80, 24);
            this.btnAddItemReset.TabIndex = 35;
            this.btnAddItemReset.Text = "Reset";
            this.btnAddItemReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItemReset.UseVisualStyleBackColor = true;
            this.btnAddItemReset.Click += new System.EventHandler(this.btnAddItemReset_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(340, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 18);
            this.label11.TabIndex = 33;
            this.label11.Text = "Add Items";
            // 
            // btnAddItemAddItem
            // 
            this.btnAddItemAddItem.Image = global::Inventory_System.Properties.Resources.ok;
            this.btnAddItemAddItem.Location = new System.Drawing.Point(237, 463);
            this.btnAddItemAddItem.Name = "btnAddItemAddItem";
            this.btnAddItemAddItem.Size = new System.Drawing.Size(80, 24);
            this.btnAddItemAddItem.TabIndex = 30;
            this.btnAddItemAddItem.Text = "Add ";
            this.btnAddItemAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItemAddItem.UseVisualStyleBackColor = true;
            this.btnAddItemAddItem.Click += new System.EventHandler(this.btnAddItemAddItem_Click);
            // 
            // btnAddItemCancel
            // 
            this.btnAddItemCancel.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btnAddItemCancel.Location = new System.Drawing.Point(453, 463);
            this.btnAddItemCancel.Name = "btnAddItemCancel";
            this.btnAddItemCancel.Size = new System.Drawing.Size(80, 24);
            this.btnAddItemCancel.TabIndex = 36;
            this.btnAddItemCancel.Text = "Cancel";
            this.btnAddItemCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddItemCancel.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 493);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ep_iname
            // 
            this.ep_iname.BlinkRate = 160;
            this.ep_iname.ContainerControl = this;
            this.ep_iname.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_iname.Icon")));
            // 
            // ep_isalePrz
            // 
            this.ep_isalePrz.BlinkRate = 160;
            this.ep_isalePrz.ContainerControl = this;
            this.ep_isalePrz.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_isalePrz.Icon")));
            // 
            // ep_ipuchsPriz
            // 
            this.ep_ipuchsPriz.BlinkRate = 160;
            this.ep_ipuchsPriz.ContainerControl = this;
            this.ep_ipuchsPriz.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_ipuchsPriz.Icon")));
            // 
            // ep_isupp
            // 
            this.ep_isupp.BlinkRate = 160;
            this.ep_isupp.ContainerControl = this;
            this.ep_isupp.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_isupp.Icon")));
            // 
            // ep_ictogry
            // 
            this.ep_ictogry.BlinkRate = 160;
            this.ep_ictogry.ContainerControl = this;
            this.ep_ictogry.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_ictogry.Icon")));
            // 
            // ep_isubCotory
            // 
            this.ep_isubCotory.BlinkRate = 160;
            this.ep_isubCotory.ContainerControl = this;
            this.ep_isubCotory.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_isubCotory.Icon")));
            // 
            // ep_ibrnd
            // 
            this.ep_ibrnd.BlinkRate = 160;
            this.ep_ibrnd.ContainerControl = this;
            this.ep_ibrnd.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_ibrnd.Icon")));
            // 
            // tp_seril_barcobe
            // 
            this.tp_seril_barcobe.IsBalloon = true;
            this.tp_seril_barcobe.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Error;
            this.tp_seril_barcobe.ToolTipTitle = "Enter Serial or Barcode";
            this.tp_seril_barcobe.Popup += new System.Windows.Forms.PopupEventHandler(this.tp_seril_barcobe_Popup);
            // 
            // tp_required
            // 
            this.tp_required.AutomaticDelay = 50;
            this.tp_required.AutoPopDelay = 4000;
            this.tp_required.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.tp_required.InitialDelay = 50;
            this.tp_required.ReshowDelay = 10;
            this.tp_required.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.tp_required.ToolTipTitle = "Item";
            // 
            // tp_ad_details
            // 
            this.tp_ad_details.AutomaticDelay = 50;
            // 
            // ep_wanty
            // 
            this.ep_wanty.ContainerControl = this;
            this.ep_wanty.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_wanty.Icon")));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lbl_p_piz);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cbx_wrty_duretion);
            this.panel1.Controls.Add(this.cbx_wrty_number);
            this.panel1.Controls.Add(this.cb_warnty);
            this.panel1.Controls.Add(this.lbl_tp);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbxAddItemBrande);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.btn_add_details);
            this.panel1.Controls.Add(this.lbl_itemNo);
            this.panel1.Controls.Add(this.txtAddItemSerial);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtAddItemBarcode);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbxAddItemItemType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbxAddItemSubCatogory);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cbxAddItemCatogory);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAddItemDiscription);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtAddItemTaxRate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtAddItemSalesPrice);
            this.panel1.Controls.Add(this.txtAddItemItemName);
            this.panel1.Location = new System.Drawing.Point(27, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 344);
            this.panel1.TabIndex = 32;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(575, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 21);
            this.button2.TabIndex = 33;
            this.button2.Text = "Manage Detalis";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toolTip_check
            // 
            this.toolTip_check.AutomaticDelay = 50;
            this.toolTip_check.AutoPopDelay = 4000;
            this.toolTip_check.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.toolTip_check.InitialDelay = 50;
            this.toolTip_check.IsBalloon = true;
            this.toolTip_check.ReshowDelay = 10;
            // 
            // cbx_stok
            // 
            this.cbx_stok.FormattingEnabled = true;
            this.cbx_stok.Location = new System.Drawing.Point(278, 19);
            this.cbx_stok.Name = "cbx_stok";
            this.cbx_stok.Size = new System.Drawing.Size(237, 21);
            this.cbx_stok.TabIndex = 39;
            this.cbx_stok.SelectedIndexChanged += new System.EventHandler(this.cbx_stok_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(226, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(50, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Stock   : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lbl_add_qty);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.lbl_a_qty);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cbx_stok);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbxAddItemSupplier);
            this.groupBox1.Location = new System.Drawing.Point(8, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 53);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Stock";
            // 
            // lbl_add_qty
            // 
            this.lbl_add_qty.AutoSize = true;
            this.lbl_add_qty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add_qty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_add_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add_qty.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_add_qty.Location = new System.Drawing.Point(697, 20);
            this.lbl_add_qty.Name = "lbl_add_qty";
            this.lbl_add_qty.Size = new System.Drawing.Size(2, 17);
            this.lbl_add_qty.TabIndex = 48;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Location = new System.Drawing.Point(639, 22);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 13);
            this.label19.TabIndex = 47;
            this.label19.Text = "Added  : ";
            // 
            // lbl_a_qty
            // 
            this.lbl_a_qty.AutoSize = true;
            this.lbl_a_qty.BackColor = System.Drawing.Color.Transparent;
            this.lbl_a_qty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_a_qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_a_qty.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbl_a_qty.Location = new System.Drawing.Point(583, 20);
            this.lbl_a_qty.Name = "lbl_a_qty";
            this.lbl_a_qty.Size = new System.Drawing.Size(2, 17);
            this.lbl_a_qty.TabIndex = 46;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(525, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Quntity  : ";
            // 
            // lbl_p_piz
            // 
            this.lbl_p_piz.Location = new System.Drawing.Point(140, 143);
            this.lbl_p_piz.Name = "lbl_p_piz";
            this.lbl_p_piz.Size = new System.Drawing.Size(135, 20);
            this.lbl_p_piz.TabIndex = 34;
            this.lbl_p_piz.TextChanged += new System.EventHandler(this.lbl_p_piz_TextChanged);
            this.lbl_p_piz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbl_p_piz_KeyPress);
            // 
            // Add_Items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddItemReset);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddItemAddItem);
            this.Controls.Add(this.btnAddItemCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Items";
            this.Text = "Add_Items";
            this.Load += new System.EventHandler(this.Add_Items_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Add_Items_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_iname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_isalePrz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_ipuchsPriz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_isupp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_ictogry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_isubCotory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_ibrnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_wanty)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxAddItemSupplier;
        private System.Windows.Forms.ComboBox cbxAddItemItemType;
        private System.Windows.Forms.ComboBox cbxAddItemSubCatogory;
        private System.Windows.Forms.ComboBox cbxAddItemCatogory;
        private System.Windows.Forms.TextBox txtAddItemDiscription;
        private System.Windows.Forms.TextBox txtAddItemTaxRate;
        private System.Windows.Forms.TextBox txtAddItemSalesPrice;
        private System.Windows.Forms.TextBox txtAddItemBarcode;
        private System.Windows.Forms.TextBox txtAddItemItemName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddItemReset;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAddItemAddItem;
        private System.Windows.Forms.Button btnAddItemCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtAddItemSerial;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_itemNo;
        private System.Windows.Forms.ComboBox cbxAddItemBrande;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider ep_iname;
        private System.Windows.Forms.ErrorProvider ep_isalePrz;
        private System.Windows.Forms.ErrorProvider ep_ipuchsPriz;
        private System.Windows.Forms.ErrorProvider ep_isupp;
        private System.Windows.Forms.ErrorProvider ep_ictogry;
        private System.Windows.Forms.ErrorProvider ep_isubCotory;
        private System.Windows.Forms.ErrorProvider ep_ibrnd;
        private System.Windows.Forms.ToolTip tp_seril_barcobe;
        private System.Windows.Forms.Label lbl_tp;
        private System.Windows.Forms.ToolTip tp_required;
        private System.Windows.Forms.Button btn_add_details;
        private System.Windows.Forms.ToolTip tp_ad_details;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbx_wrty_duretion;
        private System.Windows.Forms.ComboBox cbx_wrty_number;
        private System.Windows.Forms.CheckBox cb_warnty;
        private System.Windows.Forms.ErrorProvider ep_wanty;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip_check;
        private System.Windows.Forms.ComboBox cbx_stok;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_add_qty;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_a_qty;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox lbl_p_piz;
    }
}