namespace Inventory_System
{
    partial class Invoice_Details
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
            this.btn_addPayment = new System.Windows.Forms.Button();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel_nPmt = new System.Windows.Forms.Panel();
            this.txt_newPay = new System.Windows.Forms.TextBox();
            this.lbl_newPyment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_wrtyComplte = new System.Windows.Forms.Label();
            this.lbl_Newbalce = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Newpaid = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_invoNo = new System.Windows.Forms.Label();
            this.lbl_fstNme = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_invoDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Invo_details = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_LstNme = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_mob = new System.Windows.Forms.Label();
            this.lbl_tax = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_balce = new System.Windows.Forms.Label();
            this.lbl_tot = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lbl_Dis = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.lbl_paid = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_grndT = new System.Windows.Forms.Label();
            this.tp_itmeeror = new System.Windows.Forms.ToolTip(this.components);
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_Ok = new System.Windows.Forms.Button();
            this.btn_addWarrty = new System.Windows.Forms.Button();
            this.lbl_return = new System.Windows.Forms.Label();
            this.lbl_chge = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.panel_nPmt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invo_details)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_addPayment
            // 
            this.btn_addPayment.Image = global::Inventory_System.Properties.Resources.add;
            this.btn_addPayment.Location = new System.Drawing.Point(175, 12);
            this.btn_addPayment.Name = "btn_addPayment";
            this.btn_addPayment.Size = new System.Drawing.Size(56, 23);
            this.btn_addPayment.TabIndex = 14;
            this.btn_addPayment.Text = "Add";
            this.btn_addPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addPayment.UseVisualStyleBackColor = true;
            this.btn_addPayment.Click += new System.EventHandler(this.btn_addPayment_Click);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(3, 16);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(48, 13);
            this.label32.TabIndex = 12;
            this.label32.Text = "Payment";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.panel_nPmt);
            this.groupBox3.Controls.Add(this.lbl_newPyment);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbl_wrtyComplte);
            this.groupBox3.Controls.Add(this.lbl_Newbalce);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lbl_Newpaid);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(475, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 170);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Payment";
            // 
            // panel_nPmt
            // 
            this.panel_nPmt.Controls.Add(this.btn_addPayment);
            this.panel_nPmt.Controls.Add(this.label32);
            this.panel_nPmt.Controls.Add(this.txt_newPay);
            this.panel_nPmt.Location = new System.Drawing.Point(3, 21);
            this.panel_nPmt.Name = "panel_nPmt";
            this.panel_nPmt.Size = new System.Drawing.Size(246, 43);
            this.panel_nPmt.TabIndex = 22;
            // 
            // txt_newPay
            // 
            this.txt_newPay.Location = new System.Drawing.Point(57, 13);
            this.txt_newPay.Name = "txt_newPay";
            this.txt_newPay.Size = new System.Drawing.Size(107, 20);
            this.txt_newPay.TabIndex = 0;
            this.txt_newPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_newPay_KeyPress);
            // 
            // lbl_newPyment
            // 
            this.lbl_newPyment.AutoSize = true;
            this.lbl_newPyment.ForeColor = System.Drawing.Color.Blue;
            this.lbl_newPyment.Location = new System.Drawing.Point(73, 83);
            this.lbl_newPyment.Name = "lbl_newPyment";
            this.lbl_newPyment.Size = new System.Drawing.Size(0, 13);
            this.lbl_newPyment.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "New Paid   : ";
            // 
            // lbl_wrtyComplte
            // 
            this.lbl_wrtyComplte.AutoSize = true;
            this.lbl_wrtyComplte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wrtyComplte.ForeColor = System.Drawing.Color.Green;
            this.lbl_wrtyComplte.Location = new System.Drawing.Point(153, 94);
            this.lbl_wrtyComplte.Name = "lbl_wrtyComplte";
            this.lbl_wrtyComplte.Size = new System.Drawing.Size(76, 30);
            this.lbl_wrtyComplte.TabIndex = 19;
            this.lbl_wrtyComplte.Text = "  Payment \r\nCompleted";
            this.lbl_wrtyComplte.Visible = false;
            // 
            // lbl_Newbalce
            // 
            this.lbl_Newbalce.AutoSize = true;
            this.lbl_Newbalce.ForeColor = System.Drawing.Color.Red;
            this.lbl_Newbalce.Location = new System.Drawing.Point(73, 129);
            this.lbl_Newbalce.Name = "lbl_Newbalce";
            this.lbl_Newbalce.Size = new System.Drawing.Size(0, 13);
            this.lbl_Newbalce.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Balance     : ";
            // 
            // lbl_Newpaid
            // 
            this.lbl_Newpaid.AutoSize = true;
            this.lbl_Newpaid.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Newpaid.Location = new System.Drawing.Point(73, 107);
            this.lbl_Newpaid.Name = "lbl_Newpaid";
            this.lbl_Newpaid.Size = new System.Drawing.Size(0, 13);
            this.lbl_Newpaid.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total Paid  : ";
            // 
            // lbl_invoNo
            // 
            this.lbl_invoNo.AutoSize = true;
            this.lbl_invoNo.Location = new System.Drawing.Point(97, 17);
            this.lbl_invoNo.Name = "lbl_invoNo";
            this.lbl_invoNo.Size = new System.Drawing.Size(0, 13);
            this.lbl_invoNo.TabIndex = 11;
            // 
            // lbl_fstNme
            // 
            this.lbl_fstNme.AutoSize = true;
            this.lbl_fstNme.Location = new System.Drawing.Point(97, 60);
            this.lbl_fstNme.Name = "lbl_fstNme";
            this.lbl_fstNme.Size = new System.Drawing.Size(0, 13);
            this.lbl_fstNme.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Invoice Date  : ";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(97, 132);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(0, 13);
            this.lbl_email.TabIndex = 15;
            // 
            // lbl_invoDate
            // 
            this.lbl_invoDate.AutoSize = true;
            this.lbl_invoDate.Location = new System.Drawing.Point(97, 36);
            this.lbl_invoDate.Name = "lbl_invoDate";
            this.lbl_invoDate.Size = new System.Drawing.Size(0, 13);
            this.lbl_invoDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No     : ";
            // 
            // dgv_Invo_details
            // 
            this.dgv_Invo_details.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_Invo_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Invo_details.Location = new System.Drawing.Point(15, 194);
            this.dgv_Invo_details.Name = "dgv_Invo_details";
            this.dgv_Invo_details.Size = new System.Drawing.Size(710, 199);
            this.dgv_Invo_details.TabIndex = 28;
            this.dgv_Invo_details.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Invo_details_CellClick);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(15, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 13);
            this.label22.TabIndex = 18;
            this.label22.Text = "Mobile           : ";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(15, 132);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(77, 13);
            this.label24.TabIndex = 19;
            this.label24.Text = "Email             : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(15, 60);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "First Name     : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Last Name     : ";
            // 
            // lbl_LstNme
            // 
            this.lbl_LstNme.AutoSize = true;
            this.lbl_LstNme.Location = new System.Drawing.Point(97, 84);
            this.lbl_LstNme.Name = "lbl_LstNme";
            this.lbl_LstNme.Size = new System.Drawing.Size(0, 13);
            this.lbl_LstNme.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl_LstNme);
            this.groupBox1.Controls.Add(this.lbl_invoNo);
            this.groupBox1.Controls.Add(this.lbl_fstNme);
            this.groupBox1.Controls.Add(this.lbl_mob);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lbl_email);
            this.groupBox1.Controls.Add(this.lbl_invoDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 171);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // lbl_mob
            // 
            this.lbl_mob.AutoSize = true;
            this.lbl_mob.Location = new System.Drawing.Point(97, 108);
            this.lbl_mob.Name = "lbl_mob";
            this.lbl_mob.Size = new System.Drawing.Size(0, 13);
            this.lbl_mob.TabIndex = 12;
            // 
            // lbl_tax
            // 
            this.lbl_tax.AutoSize = true;
            this.lbl_tax.Location = new System.Drawing.Point(113, 64);
            this.lbl_tax.Name = "lbl_tax";
            this.lbl_tax.Size = new System.Drawing.Size(0, 13);
            this.lbl_tax.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tax                : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Total Price     : ";
            // 
            // lbl_balce
            // 
            this.lbl_balce.AutoSize = true;
            this.lbl_balce.ForeColor = System.Drawing.Color.Red;
            this.lbl_balce.Location = new System.Drawing.Point(113, 136);
            this.lbl_balce.Name = "lbl_balce";
            this.lbl_balce.Size = new System.Drawing.Size(0, 13);
            this.lbl_balce.TabIndex = 5;
            // 
            // lbl_tot
            // 
            this.lbl_tot.AutoSize = true;
            this.lbl_tot.ForeColor = System.Drawing.Color.Green;
            this.lbl_tot.Location = new System.Drawing.Point(113, 88);
            this.lbl_tot.Name = "lbl_tot";
            this.lbl_tot.Size = new System.Drawing.Size(0, 13);
            this.lbl_tot.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Balance         : ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(22, 40);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(79, 13);
            this.label26.TabIndex = 12;
            this.label26.Text = "Discount        : ";
            // 
            // lbl_Dis
            // 
            this.lbl_Dis.AutoSize = true;
            this.lbl_Dis.Location = new System.Drawing.Point(113, 40);
            this.lbl_Dis.Name = "lbl_Dis";
            this.lbl_Dis.Size = new System.Drawing.Size(0, 13);
            this.lbl_Dis.TabIndex = 11;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(22, 112);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(79, 13);
            this.label28.TabIndex = 14;
            this.label28.Text = "Paid               : ";
            // 
            // lbl_paid
            // 
            this.lbl_paid.AutoSize = true;
            this.lbl_paid.ForeColor = System.Drawing.Color.Blue;
            this.lbl_paid.Location = new System.Drawing.Point(113, 112);
            this.lbl_paid.Name = "lbl_paid";
            this.lbl_paid.Size = new System.Drawing.Size(0, 13);
            this.lbl_paid.TabIndex = 13;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(22, 16);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(81, 13);
            this.label30.TabIndex = 16;
            this.label30.Text = "Grande Total  : ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lbl_grndT);
            this.groupBox2.Controls.Add(this.label30);
            this.groupBox2.Controls.Add(this.lbl_paid);
            this.groupBox2.Controls.Add(this.label28);
            this.groupBox2.Controls.Add(this.lbl_Dis);
            this.groupBox2.Controls.Add(this.lbl_tot);
            this.groupBox2.Controls.Add(this.lbl_balce);
            this.groupBox2.Controls.Add(this.label26);
            this.groupBox2.Controls.Add(this.lbl_tax);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(260, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 171);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // lbl_grndT
            // 
            this.lbl_grndT.AutoSize = true;
            this.lbl_grndT.Location = new System.Drawing.Point(113, 16);
            this.lbl_grndT.Name = "lbl_grndT";
            this.lbl_grndT.Size = new System.Drawing.Size(0, 13);
            this.lbl_grndT.TabIndex = 15;
            // 
            // tp_itmeeror
            // 
            this.tp_itmeeror.AutoPopDelay = 3500;
            this.tp_itmeeror.InitialDelay = 500;
            this.tp_itmeeror.IsBalloon = true;
            this.tp_itmeeror.ReshowDelay = 100;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btn_cancel.Location = new System.Drawing.Point(642, 416);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(77, 23);
            this.btn_cancel.TabIndex = 41;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_Ok.Location = new System.Drawing.Point(550, 416);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(76, 23);
            this.btn_Ok.TabIndex = 42;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Ok.UseVisualStyleBackColor = true;
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // btn_addWarrty
            // 
            this.btn_addWarrty.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_addWarrty.Location = new System.Drawing.Point(442, 416);
            this.btn_addWarrty.Name = "btn_addWarrty";
            this.btn_addWarrty.Size = new System.Drawing.Size(86, 23);
            this.btn_addWarrty.TabIndex = 40;
            this.btn_addWarrty.Text = "Add warranty";
            this.btn_addWarrty.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_addWarrty.UseVisualStyleBackColor = false;
            // 
            // lbl_return
            // 
            this.lbl_return.AutoSize = true;
            this.lbl_return.BackColor = System.Drawing.Color.Transparent;
            this.lbl_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_return.ForeColor = System.Drawing.Color.Red;
            this.lbl_return.Location = new System.Drawing.Point(30, 416);
            this.lbl_return.Name = "lbl_return";
            this.lbl_return.Size = new System.Drawing.Size(144, 15);
            this.lbl_return.TabIndex = 43;
            this.lbl_return.Text = "This Item Was Return";
            this.lbl_return.Visible = false;
            // 
            // lbl_chge
            // 
            this.lbl_chge.AutoSize = true;
            this.lbl_chge.BackColor = System.Drawing.Color.Transparent;
            this.lbl_chge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chge.ForeColor = System.Drawing.Color.Red;
            this.lbl_chge.Location = new System.Drawing.Point(30, 416);
            this.lbl_chge.Name = "lbl_chge";
            this.lbl_chge.Size = new System.Drawing.Size(158, 15);
            this.lbl_chge.TabIndex = 44;
            this.lbl_chge.Text = "This Item Was Changed";
            this.lbl_chge.Visible = false;
            // 
            // Invoice_Details
            // 
            this.AcceptButton = this.btn_addPayment;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources._02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(743, 456);
            this.Controls.Add(this.lbl_chge);
            this.Controls.Add(this.lbl_return);
            this.Controls.Add(this.btn_addWarrty);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgv_Invo_details);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Invoice_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Invoice_Details_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel_nPmt.ResumeLayout(false);
            this.panel_nPmt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Invo_details)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addPayment;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_newPay;
        private System.Windows.Forms.Label lbl_invoNo;
        private System.Windows.Forms.Label lbl_fstNme;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_invoDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Invo_details;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_LstNme;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_mob;
        private System.Windows.Forms.Label lbl_tax;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl_balce;
        private System.Windows.Forms.Label lbl_tot;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lbl_Dis;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label lbl_paid;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_grndT;
        private System.Windows.Forms.Label lbl_wrtyComplte;
        private System.Windows.Forms.Label lbl_Newbalce;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Newpaid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip tp_itmeeror;
        private System.Windows.Forms.Label lbl_newPyment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_addWarrty;
        private System.Windows.Forms.Label lbl_return;
        private System.Windows.Forms.Label lbl_chge;
        private System.Windows.Forms.Panel panel_nPmt;
    }
}