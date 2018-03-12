namespace Inventory_System
{
    partial class Request_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Request_Order));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblOrderNo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dp_rest_odr = new System.Windows.Forms.DateTimePicker();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ep_sup = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_mob = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_dis = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.cbx_itmtype = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDiscription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_inme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbx_qty_Brand = new System.Windows.Forms.ComboBox();
            this.cbx_qty_S_ctgy = new System.Windows.Forms.ComboBox();
            this.cbx_qty_ctgy = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.lbl_mob = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_iq_Catagary = new System.Windows.Forms.Label();
            this.checkBox_msg = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider6 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ep_sup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_mob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_dis)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(329, 321);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btnClear.Location = new System.Drawing.Point(238, 321);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 24);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Request Order";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Inventory_System.Properties.Resources.ok;
            this.btnAdd.Location = new System.Drawing.Point(147, 321);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 24);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblOrderNo
            // 
            this.lblOrderNo.AutoSize = true;
            this.lblOrderNo.Location = new System.Drawing.Point(373, 27);
            this.lblOrderNo.Name = "lblOrderNo";
            this.lblOrderNo.Size = new System.Drawing.Size(0, 13);
            this.lblOrderNo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Supplier      :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order No    :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "E mail         :";
            // 
            // dp_rest_odr
            // 
            this.dp_rest_odr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_rest_odr.Location = new System.Drawing.Point(376, 49);
            this.dp_rest_odr.Name = "dp_rest_odr";
            this.dp_rest_odr.Size = new System.Drawing.Size(115, 20);
            this.dp_rest_odr.TabIndex = 20;
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(373, 83);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(129, 21);
            this.cbxSupplier.TabIndex = 19;
            this.cbxSupplier.SelectedIndexChanged += new System.EventHandler(this.cbxSupplier_SelectedIndexChanged);
            this.cbxSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxSupplier_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(302, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Order Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile        :";
            // 
            // ep_sup
            // 
            this.ep_sup.ContainerControl = this;
            this.ep_sup.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_sup.Icon")));
            // 
            // ep_mob
            // 
            this.ep_mob.ContainerControl = this;
            this.ep_mob.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_mob.Icon")));
            // 
            // ep_dis
            // 
            this.ep_dis.ContainerControl = this;
            this.ep_dis.Icon = ((System.Drawing.Icon)(resources.GetObject("ep_dis.Icon")));
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.cbx_itmtype);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtDiscription);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbxSupplier);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_inme);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.dp_rest_odr);
            this.panel1.Controls.Add(this.cbx_qty_Brand);
            this.panel1.Controls.Add(this.lblOrderNo);
            this.panel1.Controls.Add(this.cbx_qty_S_ctgy);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbx_qty_ctgy);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.lbl_mob);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.lbl_email);
            this.panel1.Controls.Add(this.txt_iq_Catagary);
            this.panel1.Location = new System.Drawing.Point(2, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 278);
            this.panel1.TabIndex = 24;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(119, 166);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(84, 20);
            this.numericUpDown1.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(27, 168);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(82, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "Quntity            : ";
            // 
            // cbx_itmtype
            // 
            this.cbx_itmtype.FormattingEnabled = true;
            this.cbx_itmtype.Location = new System.Drawing.Point(117, 138);
            this.cbx_itmtype.Name = "cbx_itmtype";
            this.cbx_itmtype.Size = new System.Drawing.Size(121, 21);
            this.cbx_itmtype.TabIndex = 45;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(28, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 13);
            this.label14.TabIndex = 44;
            this.label14.Text = "Item Type       : ";
            // 
            // txtDiscription
            // 
            this.txtDiscription.Location = new System.Drawing.Point(116, 192);
            this.txtDiscription.Multiline = true;
            this.txtDiscription.Name = "txtDiscription";
            this.txtDiscription.Size = new System.Drawing.Size(159, 60);
            this.txtDiscription.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(28, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Discription      :";
            // 
            // txt_inme
            // 
            this.txt_inme.Location = new System.Drawing.Point(117, 19);
            this.txt_inme.Multiline = true;
            this.txt_inme.Name = "txt_inme";
            this.txt_inme.Size = new System.Drawing.Size(121, 21);
            this.txt_inme.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(28, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Name               :";
            // 
            // cbx_qty_Brand
            // 
            this.cbx_qty_Brand.FormattingEnabled = true;
            this.cbx_qty_Brand.Location = new System.Drawing.Point(117, 108);
            this.cbx_qty_Brand.Name = "cbx_qty_Brand";
            this.cbx_qty_Brand.Size = new System.Drawing.Size(121, 21);
            this.cbx_qty_Brand.TabIndex = 39;
            // 
            // cbx_qty_S_ctgy
            // 
            this.cbx_qty_S_ctgy.FormattingEnabled = true;
            this.cbx_qty_S_ctgy.Location = new System.Drawing.Point(117, 79);
            this.cbx_qty_S_ctgy.Name = "cbx_qty_S_ctgy";
            this.cbx_qty_S_ctgy.Size = new System.Drawing.Size(121, 21);
            this.cbx_qty_S_ctgy.TabIndex = 38;
            // 
            // cbx_qty_ctgy
            // 
            this.cbx_qty_ctgy.FormattingEnabled = true;
            this.cbx_qty_ctgy.Location = new System.Drawing.Point(117, 50);
            this.cbx_qty_ctgy.Name = "cbx_qty_ctgy";
            this.cbx_qty_ctgy.Size = new System.Drawing.Size(121, 21);
            this.cbx_qty_ctgy.TabIndex = 37;
            this.cbx_qty_ctgy.SelectedIndexChanged += new System.EventHandler(this.cbx_qty_ctgy_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(28, 111);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 13);
            this.label22.TabIndex = 36;
            this.label22.Text = "Brand              : ";
            // 
            // lbl_mob
            // 
            this.lbl_mob.AutoSize = true;
            this.lbl_mob.Location = new System.Drawing.Point(373, 112);
            this.lbl_mob.Name = "lbl_mob";
            this.lbl_mob.Size = new System.Drawing.Size(0, 13);
            this.lbl_mob.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(28, 86);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(83, 13);
            this.label21.TabIndex = 35;
            this.label21.Text = "Sub Catagary  : ";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Location = new System.Drawing.Point(374, 145);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(0, 13);
            this.lbl_email.TabIndex = 23;
            // 
            // txt_iq_Catagary
            // 
            this.txt_iq_Catagary.AutoSize = true;
            this.txt_iq_Catagary.Location = new System.Drawing.Point(28, 54);
            this.txt_iq_Catagary.Name = "txt_iq_Catagary";
            this.txt_iq_Catagary.Size = new System.Drawing.Size(85, 13);
            this.txt_iq_Catagary.TabIndex = 34;
            this.txt_iq_Catagary.Text = "Catagary          : ";
            // 
            // checkBox_msg
            // 
            this.checkBox_msg.AutoSize = true;
            this.checkBox_msg.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_msg.Location = new System.Drawing.Point(36, 326);
            this.checkBox_msg.Name = "checkBox_msg";
            this.checkBox_msg.Size = new System.Drawing.Size(79, 17);
            this.checkBox_msg.TabIndex = 48;
            this.checkBox_msg.Text = "Send Email";
            this.checkBox_msg.UseVisualStyleBackColor = false;
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
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            this.errorProvider4.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider4.Icon")));
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            this.errorProvider5.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider5.Icon")));
            // 
            // errorProvider6
            // 
            this.errorProvider6.ContainerControl = this;
            this.errorProvider6.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider6.Icon")));
            // 
            // Request_Order
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources._02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(550, 356);
            this.Controls.Add(this.checkBox_msg);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Request_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sharp Creations";
            this.Load += new System.EventHandler(this.Request_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep_sup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_mob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_dis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblOrderNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.DateTimePicker dp_rest_odr;
        private System.Windows.Forms.ErrorProvider ep_sup;
        private System.Windows.Forms.ErrorProvider ep_mob;
        private System.Windows.Forms.ErrorProvider ep_dis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_mob;
        private System.Windows.Forms.ComboBox cbx_qty_Brand;
        private System.Windows.Forms.ComboBox cbx_qty_S_ctgy;
        private System.Windows.Forms.ComboBox cbx_qty_ctgy;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label txt_iq_Catagary;
        private System.Windows.Forms.TextBox txt_inme;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbx_itmtype;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDiscription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.ErrorProvider errorProvider6;
        private System.Windows.Forms.CheckBox checkBox_msg;
    }
}