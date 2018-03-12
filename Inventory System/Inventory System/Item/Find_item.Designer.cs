namespace Inventory_System
{
    partial class Find_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find_item));
            this.label8 = new System.Windows.Forms.Label();
            this.dgvFindItem = new System.Windows.Forms.DataGridView();
            this.btnFindItemAddItem = new System.Windows.Forms.Button();
            this.btnFindItemEditItem = new System.Windows.Forms.Button();
            this.btnFindItemDeleteItem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Qntity_Details = new System.Windows.Forms.Label();
            this.lbl_low_leval = new System.Windows.Forms.Label();
            this.cbxFindItemSubCategory = new System.Windows.Forms.ComboBox();
            this.cbxFindItemBrande = new System.Windows.Forms.ComboBox();
            this.cbxFindItemCategory = new System.Windows.Forms.ComboBox();
            this.btnFindItemCancel = new System.Windows.Forms.Button();
            this.btnFindItemReset = new System.Windows.Forms.Button();
            this.btnFindItemSearch = new System.Windows.Forms.Button();
            this.txtFindItemDiscription = new System.Windows.Forms.TextBox();
            this.txtFindItemBarcode = new System.Windows.Forms.TextBox();
            this.txtFindItemItemName = new System.Windows.Forms.TextBox();
            this.txtFindItemItemSerial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTip_check = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(331, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Find Items";
            // 
            // dgvFindItem
            // 
            this.dgvFindItem.AllowUserToDeleteRows = false;
            this.dgvFindItem.AllowUserToResizeColumns = false;
            this.dgvFindItem.AllowUserToResizeRows = false;
            this.dgvFindItem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFindItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvFindItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFindItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFindItem.Location = new System.Drawing.Point(22, 199);
            this.dgvFindItem.Name = "dgvFindItem";
            this.dgvFindItem.Size = new System.Drawing.Size(724, 256);
            this.dgvFindItem.TabIndex = 11;
            this.dgvFindItem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindItem_CellClick);
            this.dgvFindItem.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindItem_CellContentClick);
            this.dgvFindItem.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFindItem_RowEnter);
            // 
            // btnFindItemAddItem
            // 
            this.btnFindItemAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItemAddItem.Image = global::Inventory_System.Properties.Resources.add;
            this.btnFindItemAddItem.Location = new System.Drawing.Point(34, 468);
            this.btnFindItemAddItem.Name = "btnFindItemAddItem";
            this.btnFindItemAddItem.Size = new System.Drawing.Size(89, 23);
            this.btnFindItemAddItem.TabIndex = 14;
            this.btnFindItemAddItem.Text = "Add";
            this.btnFindItemAddItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindItemAddItem.UseVisualStyleBackColor = true;
            // 
            // btnFindItemEditItem
            // 
            this.btnFindItemEditItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItemEditItem.Image = global::Inventory_System.Properties.Resources.edit;
            this.btnFindItemEditItem.Location = new System.Drawing.Point(156, 468);
            this.btnFindItemEditItem.Name = "btnFindItemEditItem";
            this.btnFindItemEditItem.Size = new System.Drawing.Size(89, 23);
            this.btnFindItemEditItem.TabIndex = 8;
            this.btnFindItemEditItem.Text = "Edit ";
            this.btnFindItemEditItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindItemEditItem.UseVisualStyleBackColor = true;
            this.btnFindItemEditItem.Click += new System.EventHandler(this.btnFindItemEditItem_Click);
            // 
            // btnFindItemDeleteItem
            // 
            this.btnFindItemDeleteItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItemDeleteItem.Image = global::Inventory_System.Properties.Resources.delete;
            this.btnFindItemDeleteItem.Location = new System.Drawing.Point(279, 468);
            this.btnFindItemDeleteItem.Name = "btnFindItemDeleteItem";
            this.btnFindItemDeleteItem.Size = new System.Drawing.Size(89, 23);
            this.btnFindItemDeleteItem.TabIndex = 9;
            this.btnFindItemDeleteItem.Text = "Delete ";
            this.btnFindItemDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindItemDeleteItem.UseVisualStyleBackColor = true;
            this.btnFindItemDeleteItem.Click += new System.EventHandler(this.btnFindItemDeleteItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 510);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Qntity_Details
            // 
            this.lbl_Qntity_Details.AutoSize = true;
            this.lbl_Qntity_Details.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Qntity_Details.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Qntity_Details.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Qntity_Details.Location = new System.Drawing.Point(541, 473);
            this.lbl_Qntity_Details.Name = "lbl_Qntity_Details";
            this.lbl_Qntity_Details.Size = new System.Drawing.Size(2, 17);
            this.lbl_Qntity_Details.TabIndex = 24;
            // 
            // lbl_low_leval
            // 
            this.lbl_low_leval.AutoSize = true;
            this.lbl_low_leval.BackColor = System.Drawing.Color.Transparent;
            this.lbl_low_leval.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_low_leval.Location = new System.Drawing.Point(538, 494);
            this.lbl_low_leval.Name = "lbl_low_leval";
            this.lbl_low_leval.Size = new System.Drawing.Size(87, 13);
            this.lbl_low_leval.TabIndex = 25;
            this.lbl_low_leval.Text = "Low Stock Level";
            this.lbl_low_leval.Visible = false;
            // 
            // cbxFindItemSubCategory
            // 
            this.cbxFindItemSubCategory.FormattingEnabled = true;
            this.cbxFindItemSubCategory.Location = new System.Drawing.Point(126, 113);
            this.cbxFindItemSubCategory.Name = "cbxFindItemSubCategory";
            this.cbxFindItemSubCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxFindItemSubCategory.TabIndex = 36;
            this.cbxFindItemSubCategory.SelectedIndexChanged += new System.EventHandler(this.cbxFindItemSubCategory_SelectedIndexChanged);
            this.cbxFindItemSubCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxFindItemSubCategory_KeyPress);
            // 
            // cbxFindItemBrande
            // 
            this.cbxFindItemBrande.FormattingEnabled = true;
            this.cbxFindItemBrande.Location = new System.Drawing.Point(359, 55);
            this.cbxFindItemBrande.Name = "cbxFindItemBrande";
            this.cbxFindItemBrande.Size = new System.Drawing.Size(144, 21);
            this.cbxFindItemBrande.TabIndex = 39;
            this.cbxFindItemBrande.SelectedIndexChanged += new System.EventHandler(this.cbxFindItemBrande_SelectedIndexChanged);
            // 
            // cbxFindItemCategory
            // 
            this.cbxFindItemCategory.FormattingEnabled = true;
            this.cbxFindItemCategory.Location = new System.Drawing.Point(126, 84);
            this.cbxFindItemCategory.Name = "cbxFindItemCategory";
            this.cbxFindItemCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxFindItemCategory.TabIndex = 35;
            this.cbxFindItemCategory.SelectedIndexChanged += new System.EventHandler(this.cbxFindItemCategory_SelectedIndexChanged);
            this.cbxFindItemCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxFindItemCategory_KeyPress);
            // 
            // btnFindItemCancel
            // 
            this.btnFindItemCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItemCancel.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btnFindItemCancel.Location = new System.Drawing.Point(559, 85);
            this.btnFindItemCancel.Name = "btnFindItemCancel";
            this.btnFindItemCancel.Size = new System.Drawing.Size(101, 24);
            this.btnFindItemCancel.TabIndex = 40;
            this.btnFindItemCancel.Text = "Cancel";
            this.btnFindItemCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindItemCancel.UseVisualStyleBackColor = true;
            // 
            // btnFindItemReset
            // 
            this.btnFindItemReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItemReset.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btnFindItemReset.Location = new System.Drawing.Point(559, 55);
            this.btnFindItemReset.Name = "btnFindItemReset";
            this.btnFindItemReset.Size = new System.Drawing.Size(101, 24);
            this.btnFindItemReset.TabIndex = 42;
            this.btnFindItemReset.Text = "Reset";
            this.btnFindItemReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindItemReset.UseVisualStyleBackColor = true;
            this.btnFindItemReset.Click += new System.EventHandler(this.btnFindItemReset_Click);
            // 
            // btnFindItemSearch
            // 
            this.btnFindItemSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItemSearch.Image = global::Inventory_System.Properties.Resources.find;
            this.btnFindItemSearch.Location = new System.Drawing.Point(559, 26);
            this.btnFindItemSearch.Name = "btnFindItemSearch";
            this.btnFindItemSearch.Size = new System.Drawing.Size(101, 24);
            this.btnFindItemSearch.TabIndex = 38;
            this.btnFindItemSearch.Text = "Search";
            this.btnFindItemSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindItemSearch.UseVisualStyleBackColor = true;
            // 
            // txtFindItemDiscription
            // 
            this.txtFindItemDiscription.Location = new System.Drawing.Point(359, 87);
            this.txtFindItemDiscription.Multiline = true;
            this.txtFindItemDiscription.Name = "txtFindItemDiscription";
            this.txtFindItemDiscription.Size = new System.Drawing.Size(144, 51);
            this.txtFindItemDiscription.TabIndex = 41;
            this.txtFindItemDiscription.TextChanged += new System.EventHandler(this.txtFindItemDiscription_TextChanged);
            this.txtFindItemDiscription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindItemDiscription_KeyPress);
            // 
            // txtFindItemBarcode
            // 
            this.txtFindItemBarcode.Location = new System.Drawing.Point(126, 56);
            this.txtFindItemBarcode.Name = "txtFindItemBarcode";
            this.txtFindItemBarcode.Size = new System.Drawing.Size(121, 20);
            this.txtFindItemBarcode.TabIndex = 34;
            this.txtFindItemBarcode.TextChanged += new System.EventHandler(this.txtFindItemBarcode_TextChanged);
            // 
            // txtFindItemItemName
            // 
            this.txtFindItemItemName.Location = new System.Drawing.Point(359, 26);
            this.txtFindItemItemName.Name = "txtFindItemItemName";
            this.txtFindItemItemName.Size = new System.Drawing.Size(144, 20);
            this.txtFindItemItemName.TabIndex = 37;
            this.txtFindItemItemName.TextChanged += new System.EventHandler(this.txtFindItemItemName_TextChanged);
            this.txtFindItemItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindItemItemName_KeyPress);
            // 
            // txtFindItemItemSerial
            // 
            this.txtFindItemItemSerial.Location = new System.Drawing.Point(126, 27);
            this.txtFindItemItemSerial.Name = "txtFindItemItemSerial";
            this.txtFindItemItemSerial.Size = new System.Drawing.Size(121, 20);
            this.txtFindItemItemSerial.TabIndex = 33;
            this.txtFindItemItemSerial.TextChanged += new System.EventHandler(this.txtFindItemItemSerial_TextChanged_1);
            this.txtFindItemItemSerial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindItemItemSerial_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Brande       :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Sub-Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Category        :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Discription :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Barcode         :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Item Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Serial No          :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cbxFindItemSubCategory);
            this.panel1.Controls.Add(this.cbxFindItemBrande);
            this.panel1.Controls.Add(this.cbxFindItemCategory);
            this.panel1.Controls.Add(this.btnFindItemCancel);
            this.panel1.Controls.Add(this.btnFindItemReset);
            this.panel1.Controls.Add(this.btnFindItemSearch);
            this.panel1.Controls.Add(this.txtFindItemDiscription);
            this.panel1.Controls.Add(this.txtFindItemBarcode);
            this.panel1.Controls.Add(this.txtFindItemItemName);
            this.panel1.Controls.Add(this.txtFindItemItemSerial);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(723, 156);
            this.panel1.TabIndex = 43;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            // Find_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_low_leval);
            this.Controls.Add(this.lbl_Qntity_Details);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFindItemDeleteItem);
            this.Controls.Add(this.btnFindItemEditItem);
            this.Controls.Add(this.btnFindItemAddItem);
            this.Controls.Add(this.dgvFindItem);
            this.Controls.Add(this.label8);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Find_item";
            this.Text = "Find_item";
            this.Load += new System.EventHandler(this.Find_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvFindItem;
        private System.Windows.Forms.Button btnFindItemAddItem;
        private System.Windows.Forms.Button btnFindItemEditItem;
        private System.Windows.Forms.Button btnFindItemDeleteItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Qntity_Details;
        private System.Windows.Forms.Label lbl_low_leval;
        private System.Windows.Forms.ComboBox cbxFindItemSubCategory;
        private System.Windows.Forms.ComboBox cbxFindItemBrande;
        private System.Windows.Forms.ComboBox cbxFindItemCategory;
        private System.Windows.Forms.Button btnFindItemCancel;
        private System.Windows.Forms.Button btnFindItemReset;
        private System.Windows.Forms.Button btnFindItemSearch;
        private System.Windows.Forms.TextBox txtFindItemDiscription;
        private System.Windows.Forms.TextBox txtFindItemBarcode;
        private System.Windows.Forms.TextBox txtFindItemItemName;
        private System.Windows.Forms.TextBox txtFindItemItemSerial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTip_check;
    }
}