namespace Inventory_System
{
    partial class View_item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_item));
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewItemAddItem = new System.Windows.Forms.Button();
            this.btnViewItemDeleteItem = new System.Windows.Forms.Button();
            this.btnViewItemEditItem = new System.Windows.Forms.Button();
            this.btnViewItemFindItem = new System.Windows.Forms.Button();
            this.dgvViewItem = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewItem)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(315, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "View Items";
            // 
            // btnViewItemAddItem
            // 
            this.btnViewItemAddItem.Location = new System.Drawing.Point(276, 430);
            this.btnViewItemAddItem.Name = "btnViewItemAddItem";
            this.btnViewItemAddItem.Size = new System.Drawing.Size(92, 23);
            this.btnViewItemAddItem.TabIndex = 5;
            this.btnViewItemAddItem.Text = "Add Item";
            this.btnViewItemAddItem.UseVisualStyleBackColor = true;
            this.btnViewItemAddItem.Click += new System.EventHandler(this.button_add_item_Click);
            // 
            // btnViewItemDeleteItem
            // 
            this.btnViewItemDeleteItem.Location = new System.Drawing.Point(392, 430);
            this.btnViewItemDeleteItem.Name = "btnViewItemDeleteItem";
            this.btnViewItemDeleteItem.Size = new System.Drawing.Size(92, 23);
            this.btnViewItemDeleteItem.TabIndex = 4;
            this.btnViewItemDeleteItem.Text = "Delete Item";
            this.btnViewItemDeleteItem.UseVisualStyleBackColor = true;
            // 
            // btnViewItemEditItem
            // 
            this.btnViewItemEditItem.Location = new System.Drawing.Point(508, 430);
            this.btnViewItemEditItem.Name = "btnViewItemEditItem";
            this.btnViewItemEditItem.Size = new System.Drawing.Size(92, 23);
            this.btnViewItemEditItem.TabIndex = 3;
            this.btnViewItemEditItem.Text = "Edit Item";
            this.btnViewItemEditItem.UseVisualStyleBackColor = true;
            // 
            // btnViewItemFindItem
            // 
            this.btnViewItemFindItem.Location = new System.Drawing.Point(160, 430);
            this.btnViewItemFindItem.Name = "btnViewItemFindItem";
            this.btnViewItemFindItem.Size = new System.Drawing.Size(92, 23);
            this.btnViewItemFindItem.TabIndex = 2;
            this.btnViewItemFindItem.Text = "Find Item";
            this.btnViewItemFindItem.UseVisualStyleBackColor = true;
            // 
            // dgvViewItem
            // 
            this.dgvViewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewItem.Location = new System.Drawing.Point(8, 17);
            this.dgvViewItem.Name = "dgvViewItem";
            this.dgvViewItem.Size = new System.Drawing.Size(729, 396);
            this.dgvViewItem.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnViewItemAddItem);
            this.groupBox1.Controls.Add(this.btnViewItemDeleteItem);
            this.groupBox1.Controls.Add(this.btnViewItemEditItem);
            this.groupBox1.Controls.Add(this.btnViewItemFindItem);
            this.groupBox1.Controls.Add(this.dgvViewItem);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 459);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 491);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // View_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources._02;
            this.ClientSize = new System.Drawing.Size(770, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_item";
            this.Text = "View_item";
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewItem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewItemAddItem;
        private System.Windows.Forms.Button btnViewItemDeleteItem;
        private System.Windows.Forms.Button btnViewItemEditItem;
        private System.Windows.Forms.Button btnViewItemFindItem;
        private System.Windows.Forms.DataGridView dgvViewItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}