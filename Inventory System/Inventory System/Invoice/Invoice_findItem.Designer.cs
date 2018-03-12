namespace Inventory_System
{
    partial class Invoice_findItem
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
            this.dgvFindItem = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxFindItemSubCategory = new System.Windows.Forms.ComboBox();
            this.cbxFindItemBrande = new System.Windows.Forms.ComboBox();
            this.cbxFindItemCategory = new System.Windows.Forms.ComboBox();
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
            this.btn_complete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btnFindItemCancel = new System.Windows.Forms.Button();
            this.lbl_add = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFindItem
            // 
            this.dgvFindItem.AllowUserToResizeColumns = false;
            this.dgvFindItem.AllowUserToResizeRows = false;
            this.dgvFindItem.BackgroundColor = System.Drawing.Color.White;
            this.dgvFindItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvFindItem.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFindItem.Location = new System.Drawing.Point(9, 186);
            this.dgvFindItem.Name = "dgvFindItem";
            this.dgvFindItem.Size = new System.Drawing.Size(724, 215);
            this.dgvFindItem.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(319, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Select Items";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cbxFindItemSubCategory);
            this.groupBox1.Controls.Add(this.cbxFindItemBrande);
            this.groupBox1.Controls.Add(this.cbxFindItemCategory);
            this.groupBox1.Controls.Add(this.btnFindItemReset);
            this.groupBox1.Controls.Add(this.btnFindItemSearch);
            this.groupBox1.Controls.Add(this.txtFindItemDiscription);
            this.groupBox1.Controls.Add(this.txtFindItemBarcode);
            this.groupBox1.Controls.Add(this.txtFindItemItemName);
            this.groupBox1.Controls.Add(this.txtFindItemItemSerial);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 152);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter details ";
            // 
            // cbxFindItemSubCategory
            // 
            this.cbxFindItemSubCategory.FormattingEnabled = true;
            this.cbxFindItemSubCategory.Location = new System.Drawing.Point(122, 111);
            this.cbxFindItemSubCategory.Name = "cbxFindItemSubCategory";
            this.cbxFindItemSubCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxFindItemSubCategory.TabIndex = 4;
            this.cbxFindItemSubCategory.SelectedIndexChanged += new System.EventHandler(this.cbxFindItemSubCategory_SelectedIndexChanged);
            this.cbxFindItemSubCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxFindItemSubCategory_KeyPress);
            // 
            // cbxFindItemBrande
            // 
            this.cbxFindItemBrande.FormattingEnabled = true;
            this.cbxFindItemBrande.Location = new System.Drawing.Point(355, 53);
            this.cbxFindItemBrande.Name = "cbxFindItemBrande";
            this.cbxFindItemBrande.Size = new System.Drawing.Size(144, 21);
            this.cbxFindItemBrande.TabIndex = 6;
            this.cbxFindItemBrande.SelectedIndexChanged += new System.EventHandler(this.cbxFindItemBrande_SelectedIndexChanged);
            this.cbxFindItemBrande.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxFindItemBrande_KeyPress);
            // 
            // cbxFindItemCategory
            // 
            this.cbxFindItemCategory.FormattingEnabled = true;
            this.cbxFindItemCategory.Location = new System.Drawing.Point(122, 82);
            this.cbxFindItemCategory.Name = "cbxFindItemCategory";
            this.cbxFindItemCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxFindItemCategory.TabIndex = 3;
            this.cbxFindItemCategory.SelectedIndexChanged += new System.EventHandler(this.cbxFindItemCategory_SelectedIndexChanged);
            this.cbxFindItemCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxFindItemCategory_KeyPress);
            // 
            // btnFindItemReset
            // 
            this.btnFindItemReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItemReset.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btnFindItemReset.Location = new System.Drawing.Point(555, 53);
            this.btnFindItemReset.Name = "btnFindItemReset";
            this.btnFindItemReset.Size = new System.Drawing.Size(101, 24);
            this.btnFindItemReset.TabIndex = 10;
            this.btnFindItemReset.Text = "Reset";
            this.btnFindItemReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindItemReset.UseVisualStyleBackColor = true;
            this.btnFindItemReset.Click += new System.EventHandler(this.btnFindItemReset_Click);
            // 
            // btnFindItemSearch
            // 
            this.btnFindItemSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItemSearch.Image = global::Inventory_System.Properties.Resources.find;
            this.btnFindItemSearch.Location = new System.Drawing.Point(555, 24);
            this.btnFindItemSearch.Name = "btnFindItemSearch";
            this.btnFindItemSearch.Size = new System.Drawing.Size(101, 24);
            this.btnFindItemSearch.TabIndex = 5;
            this.btnFindItemSearch.Text = "Search";
            this.btnFindItemSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindItemSearch.UseVisualStyleBackColor = true;
            // 
            // txtFindItemDiscription
            // 
            this.txtFindItemDiscription.Location = new System.Drawing.Point(355, 85);
            this.txtFindItemDiscription.Multiline = true;
            this.txtFindItemDiscription.Name = "txtFindItemDiscription";
            this.txtFindItemDiscription.Size = new System.Drawing.Size(144, 51);
            this.txtFindItemDiscription.TabIndex = 7;
            this.txtFindItemDiscription.TextChanged += new System.EventHandler(this.txtFindItemDiscription_TextChanged);
            this.txtFindItemDiscription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindItemDiscription_KeyPress);
            // 
            // txtFindItemBarcode
            // 
            this.txtFindItemBarcode.Location = new System.Drawing.Point(122, 54);
            this.txtFindItemBarcode.Name = "txtFindItemBarcode";
            this.txtFindItemBarcode.Size = new System.Drawing.Size(121, 20);
            this.txtFindItemBarcode.TabIndex = 2;
            // 
            // txtFindItemItemName
            // 
            this.txtFindItemItemName.Location = new System.Drawing.Point(355, 24);
            this.txtFindItemItemName.Name = "txtFindItemItemName";
            this.txtFindItemItemName.Size = new System.Drawing.Size(144, 20);
            this.txtFindItemItemName.TabIndex = 5;
            this.txtFindItemItemName.TextChanged += new System.EventHandler(this.txtFindItemItemName_TextChanged);
            this.txtFindItemItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindItemItemName_KeyPress);
            // 
            // txtFindItemItemSerial
            // 
            this.txtFindItemItemSerial.Location = new System.Drawing.Point(122, 25);
            this.txtFindItemItemSerial.Name = "txtFindItemItemSerial";
            this.txtFindItemItemSerial.Size = new System.Drawing.Size(121, 20);
            this.txtFindItemItemSerial.TabIndex = 1;
            this.txtFindItemItemSerial.TextChanged += new System.EventHandler(this.txtFindItemItemSerial_TextChanged);
            this.txtFindItemItemSerial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindItemItemSerial_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Brande       :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Sub-Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category        :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Discription :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Barcode         :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Item Name :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial No          :";
            // 
            // btn_complete
            // 
            this.btn_complete.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_complete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_complete.Location = new System.Drawing.Point(534, 410);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.Size = new System.Drawing.Size(82, 24);
            this.btn_complete.TabIndex = 16;
            this.btn_complete.Text = "Complete";
            this.btn_complete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_complete.UseVisualStyleBackColor = true;
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(419, 410);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 24);
            this.btn_add.TabIndex = 18;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btnFindItemCancel
            // 
            this.btnFindItemCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFindItemCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFindItemCancel.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btnFindItemCancel.Location = new System.Drawing.Point(649, 410);
            this.btnFindItemCancel.Name = "btnFindItemCancel";
            this.btnFindItemCancel.Size = new System.Drawing.Size(82, 24);
            this.btnFindItemCancel.TabIndex = 19;
            this.btnFindItemCancel.Text = "Cancel";
            this.btnFindItemCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindItemCancel.UseVisualStyleBackColor = true;
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.BackColor = System.Drawing.Color.Transparent;
            this.lbl_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_add.Location = new System.Drawing.Point(27, 417);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(0, 15);
            this.lbl_add.TabIndex = 20;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Invoice_findItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources._02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnFindItemCancel;
            this.ClientSize = new System.Drawing.Size(745, 445);
            this.Controls.Add(this.lbl_add);
            this.Controls.Add(this.btnFindItemCancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_complete);
            this.Controls.Add(this.dgvFindItem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Invoice_findItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invoice_findItem";
            this.Load += new System.EventHandler(this.Invoice_findItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFindItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxFindItemSubCategory;
        private System.Windows.Forms.ComboBox cbxFindItemBrande;
        private System.Windows.Forms.ComboBox cbxFindItemCategory;
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
        private System.Windows.Forms.Button btn_complete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btnFindItemCancel;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}