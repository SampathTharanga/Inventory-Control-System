namespace Inventory_System
{
    partial class Add_Warranty
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Warranty));
            this.txt_barcode = new System.Windows.Forms.TextBox();
            this.txt_invoNo = new System.Windows.Forms.TextBox();
            this.txt_serial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_itmnme = new System.Windows.Forms.TextBox();
            this.btnFindItemReset = new System.Windows.Forms.Button();
            this.btnFindItemSearch = new System.Windows.Forms.Button();
            this.dgv_addwarty = new System.Windows.Forms.DataGridView();
            this.lbl_invoNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_itmNme = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_supp = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_itmNo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_wrtyFrom = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lbl_wrtyTo = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_warty = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cusMob = new System.Windows.Forms.TextBox();
            this.txt_cusNm = new System.Windows.Forms.TextBox();
            this.lbl_wExp = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tp_itmeeror = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_type = new System.Windows.Forms.ComboBox();
            this.txt_descript = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip_check = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addwarty)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_barcode
            // 
            this.txt_barcode.Location = new System.Drawing.Point(340, 71);
            this.txt_barcode.Name = "txt_barcode";
            this.txt_barcode.Size = new System.Drawing.Size(144, 20);
            this.txt_barcode.TabIndex = 11;
            this.txt_barcode.TextChanged += new System.EventHandler(this.txt_barcode_TextChanged);
            // 
            // txt_invoNo
            // 
            this.txt_invoNo.Location = new System.Drawing.Point(113, 41);
            this.txt_invoNo.Name = "txt_invoNo";
            this.txt_invoNo.Size = new System.Drawing.Size(111, 20);
            this.txt_invoNo.TabIndex = 13;
            this.txt_invoNo.TextChanged += new System.EventHandler(this.txt_invoNo_TextChanged);
            this.txt_invoNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_invoNo_KeyPress);
            // 
            // txt_serial
            // 
            this.txt_serial.Location = new System.Drawing.Point(340, 42);
            this.txt_serial.Name = "txt_serial";
            this.txt_serial.Size = new System.Drawing.Size(144, 20);
            this.txt_serial.TabIndex = 12;
            this.txt_serial.TextChanged += new System.EventHandler(this.txt_serial_TextChanged);
            this.txt_serial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_serial_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(41, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(275, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Barcode   :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(41, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Invoice No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(275, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Serial No  :";
            // 
            // txt_itmnme
            // 
            this.txt_itmnme.Location = new System.Drawing.Point(113, 72);
            this.txt_itmnme.Name = "txt_itmnme";
            this.txt_itmnme.Size = new System.Drawing.Size(111, 20);
            this.txt_itmnme.TabIndex = 14;
            this.txt_itmnme.TextChanged += new System.EventHandler(this.txt_itmnme_TextChanged);
            this.txt_itmnme.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_itmnme_KeyPress);
            // 
            // btnFindItemReset
            // 
            this.btnFindItemReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItemReset.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btnFindItemReset.Location = new System.Drawing.Point(544, 68);
            this.btnFindItemReset.Name = "btnFindItemReset";
            this.btnFindItemReset.Size = new System.Drawing.Size(81, 24);
            this.btnFindItemReset.TabIndex = 16;
            this.btnFindItemReset.Text = "Reset";
            this.btnFindItemReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindItemReset.UseVisualStyleBackColor = true;
            // 
            // btnFindItemSearch
            // 
            this.btnFindItemSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItemSearch.Image = global::Inventory_System.Properties.Resources.find;
            this.btnFindItemSearch.Location = new System.Drawing.Point(544, 39);
            this.btnFindItemSearch.Name = "btnFindItemSearch";
            this.btnFindItemSearch.Size = new System.Drawing.Size(81, 24);
            this.btnFindItemSearch.TabIndex = 15;
            this.btnFindItemSearch.Text = "Search";
            this.btnFindItemSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindItemSearch.UseVisualStyleBackColor = true;
            // 
            // dgv_addwarty
            // 
            this.dgv_addwarty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_addwarty.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_addwarty.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_addwarty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_addwarty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_addwarty.Location = new System.Drawing.Point(15, 108);
            this.dgv_addwarty.Name = "dgv_addwarty";
            this.dgv_addwarty.Size = new System.Drawing.Size(630, 154);
            this.dgv_addwarty.TabIndex = 17;
            this.dgv_addwarty.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_addwarty_CellClick);
            // 
            // lbl_invoNo
            // 
            this.lbl_invoNo.AutoSize = true;
            this.lbl_invoNo.Location = new System.Drawing.Point(83, 18);
            this.lbl_invoNo.Name = "lbl_invoNo";
            this.lbl_invoNo.Size = new System.Drawing.Size(0, 13);
            this.lbl_invoNo.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Invoice No : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Mobile        : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Name         : ";
            // 
            // lbl_itmNme
            // 
            this.lbl_itmNme.AutoSize = true;
            this.lbl_itmNme.Location = new System.Drawing.Point(278, 40);
            this.lbl_itmNme.Name = "lbl_itmNme";
            this.lbl_itmNme.Size = new System.Drawing.Size(0, 13);
            this.lbl_itmNme.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Item Name : ";
            // 
            // lbl_supp
            // 
            this.lbl_supp.AutoSize = true;
            this.lbl_supp.Location = new System.Drawing.Point(279, 62);
            this.lbl_supp.Name = "lbl_supp";
            this.lbl_supp.Size = new System.Drawing.Size(0, 13);
            this.lbl_supp.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(213, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Supplier     : ";
            // 
            // lbl_itmNo
            // 
            this.lbl_itmNo.AutoSize = true;
            this.lbl_itmNo.Location = new System.Drawing.Point(278, 17);
            this.lbl_itmNo.Name = "lbl_itmNo";
            this.lbl_itmNo.Size = new System.Drawing.Size(0, 13);
            this.lbl_itmNo.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(211, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Item No      : ";
            // 
            // lbl_wrtyFrom
            // 
            this.lbl_wrtyFrom.AutoSize = true;
            this.lbl_wrtyFrom.Location = new System.Drawing.Point(460, 40);
            this.lbl_wrtyFrom.Name = "lbl_wrtyFrom";
            this.lbl_wrtyFrom.Size = new System.Drawing.Size(0, 13);
            this.lbl_wrtyFrom.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(403, 40);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "From      : ";
            // 
            // lbl_wrtyTo
            // 
            this.lbl_wrtyTo.AutoSize = true;
            this.lbl_wrtyTo.Location = new System.Drawing.Point(461, 62);
            this.lbl_wrtyTo.Name = "lbl_wrtyTo";
            this.lbl_wrtyTo.Size = new System.Drawing.Size(0, 13);
            this.lbl_wrtyTo.TabIndex = 33;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(405, 62);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 13);
            this.label19.TabIndex = 32;
            this.label19.Text = "To         : ";
            // 
            // lbl_warty
            // 
            this.lbl_warty.AutoSize = true;
            this.lbl_warty.ForeColor = System.Drawing.Color.DarkBlue;
            this.lbl_warty.Location = new System.Drawing.Point(460, 16);
            this.lbl_warty.Name = "lbl_warty";
            this.lbl_warty.Size = new System.Drawing.Size(0, 13);
            this.lbl_warty.TabIndex = 31;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(403, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "warranty : ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_cusMob);
            this.groupBox1.Controls.Add(this.txt_cusNm);
            this.groupBox1.Controls.Add(this.lbl_wExp);
            this.groupBox1.Controls.Add(this.lbl_wrtyFrom);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.lbl_wrtyTo);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.lbl_warty);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.lbl_itmNme);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbl_supp);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lbl_itmNo);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_invoNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(13, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 88);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            // 
            // txt_cusMob
            // 
            this.txt_cusMob.Location = new System.Drawing.Point(78, 60);
            this.txt_cusMob.Name = "txt_cusMob";
            this.txt_cusMob.Size = new System.Drawing.Size(111, 20);
            this.txt_cusMob.TabIndex = 50;
            this.txt_cusMob.TextChanged += new System.EventHandler(this.txt_cusMob_TextChanged);
            this.txt_cusMob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cusMob_KeyPress);
            // 
            // txt_cusNm
            // 
            this.txt_cusNm.Location = new System.Drawing.Point(78, 37);
            this.txt_cusNm.Name = "txt_cusNm";
            this.txt_cusNm.Size = new System.Drawing.Size(111, 20);
            this.txt_cusNm.TabIndex = 46;
            this.txt_cusNm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cusNm_KeyPress);
            // 
            // lbl_wExp
            // 
            this.lbl_wExp.AutoSize = true;
            this.lbl_wExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wExp.ForeColor = System.Drawing.Color.Red;
            this.lbl_wExp.Location = new System.Drawing.Point(528, 14);
            this.lbl_wExp.Name = "lbl_wExp";
            this.lbl_wExp.Size = new System.Drawing.Size(74, 15);
            this.lbl_wExp.TabIndex = 49;
            this.lbl_wExp.Text = "( Expired )";
            this.lbl_wExp.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btn_cancel.Location = new System.Drawing.Point(565, 373);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 23);
            this.btn_cancel.TabIndex = 38;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_ok.Location = new System.Drawing.Point(470, 373);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 40;
            this.btn_ok.Text = "Ok";
            this.btn_ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tp_itmeeror
            // 
            this.tp_itmeeror.AutoPopDelay = 2500;
            this.tp_itmeeror.InitialDelay = 500;
            this.tp_itmeeror.ReshowDelay = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(302, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 18);
            this.label6.TabIndex = 43;
            this.label6.Text = "Warranty";
            // 
            // cbx_type
            // 
            this.cbx_type.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbx_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_type.FormattingEnabled = true;
            this.cbx_type.Items.AddRange(new object[] {
            "Change",
            "Warranty"});
            this.cbx_type.Location = new System.Drawing.Point(330, 373);
            this.cbx_type.Name = "cbx_type";
            this.cbx_type.Size = new System.Drawing.Size(120, 21);
            this.cbx_type.TabIndex = 44;
            this.cbx_type.SelectedIndexChanged += new System.EventHandler(this.cbx_type_SelectedIndexChanged);
            this.cbx_type.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_type_KeyPress);
            // 
            // txt_descript
            // 
            this.txt_descript.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descript.Location = new System.Drawing.Point(15, 369);
            this.txt_descript.Multiline = true;
            this.txt_descript.Name = "txt_descript";
            this.txt_descript.Size = new System.Drawing.Size(270, 47);
            this.txt_descript.TabIndex = 45;
            this.txt_descript.Text = "  Enter Warranty Description........";
            this.txt_descript.Visible = false;
            this.txt_descript.Click += new System.EventHandler(this.txt_descript_Click);
            this.txt_descript.TextChanged += new System.EventHandler(this.txt_descript_TextChanged);
            this.txt_descript.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descript_KeyPress);
            this.txt_descript.MouseLeave += new System.EventHandler(this.txt_descript_MouseLeave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 50;
            this.toolTip1.AutoPopDelay = 3500;
            this.toolTip1.InitialDelay = 50;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 10;
            // 
            // toolTip2
            // 
            this.toolTip2.AutomaticDelay = 50;
            this.toolTip2.AutoPopDelay = 3500;
            this.toolTip2.InitialDelay = 50;
            this.toolTip2.IsBalloon = true;
            this.toolTip2.ReshowDelay = 10;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // toolTip_check
            // 
            this.toolTip_check.AutomaticDelay = 50;
            this.toolTip_check.AutoPopDelay = 3500;
            this.toolTip_check.InitialDelay = 50;
            this.toolTip_check.IsBalloon = true;
            this.toolTip_check.ReshowDelay = 10;
            // 
            // Add_Warranty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources._02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(667, 435);
            this.Controls.Add(this.txt_descript);
            this.Controls.Add(this.cbx_type);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv_addwarty);
            this.Controls.Add(this.btnFindItemReset);
            this.Controls.Add(this.btnFindItemSearch);
            this.Controls.Add(this.txt_itmnme);
            this.Controls.Add(this.txt_barcode);
            this.Controls.Add(this.txt_invoNo);
            this.Controls.Add(this.txt_serial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Add_Warranty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sharp Creation";
            this.Load += new System.EventHandler(this.Add_Warranty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_addwarty)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_barcode;
        private System.Windows.Forms.TextBox txt_invoNo;
        private System.Windows.Forms.TextBox txt_serial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_itmnme;
        private System.Windows.Forms.Button btnFindItemReset;
        private System.Windows.Forms.Button btnFindItemSearch;
        private System.Windows.Forms.DataGridView dgv_addwarty;
        private System.Windows.Forms.Label lbl_invoNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_itmNme;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_supp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_itmNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_wrtyFrom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lbl_wrtyTo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_warty;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lbl_wExp;
        private System.Windows.Forms.ToolTip tp_itmeeror;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_type;
        private System.Windows.Forms.TextBox txt_descript;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox txt_cusMob;
        private System.Windows.Forms.TextBox txt_cusNm;
        private System.Windows.Forms.ToolTip toolTip_check;
    }
}