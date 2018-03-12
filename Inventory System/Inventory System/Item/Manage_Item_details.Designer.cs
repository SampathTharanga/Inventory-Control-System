namespace Inventory_System
{
    partial class Manage_Item_details
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
            this.cbx_choose = new System.Windows.Forms.ComboBox();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.dgv_item_details = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item_details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_choose
            // 
            this.cbx_choose.FormattingEnabled = true;
            this.cbx_choose.Items.AddRange(new object[] {
            "Catogory",
            "Sub catogory",
            "Brande",
            "Item type"});
            this.cbx_choose.Location = new System.Drawing.Point(12, 16);
            this.cbx_choose.Name = "cbx_choose";
            this.cbx_choose.Size = new System.Drawing.Size(121, 21);
            this.cbx_choose.TabIndex = 0;
            this.cbx_choose.SelectedIndexChanged += new System.EventHandler(this.cbx_choose_SelectedIndexChanged);
            // 
            // txt_Search
            // 
            this.txt_Search.Enabled = false;
            this.txt_Search.Location = new System.Drawing.Point(148, 17);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(121, 20);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.Click += new System.EventHandler(this.txt_Search_Click);
            this.txt_Search.TextChanged += new System.EventHandler(this.txt_Search_TextChanged);
            this.txt_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Search_KeyPress);
            // 
            // btn_delete
            // 
            this.btn_delete.Image = global::Inventory_System.Properties.Resources.delete;
            this.btn_delete.Location = new System.Drawing.Point(76, 400);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btn_cancel.Location = new System.Drawing.Point(168, 400);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 5;
            this.btn_cancel.Text = "cancel";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // dgv_item_details
            // 
            this.dgv_item_details.BackgroundColor = System.Drawing.Color.White;
            this.dgv_item_details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_item_details.Location = new System.Drawing.Point(11, 48);
            this.dgv_item_details.Name = "dgv_item_details";
            this.dgv_item_details.Size = new System.Drawing.Size(285, 342);
            this.dgv_item_details.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_System.Properties.Resources.find;
            this.pictureBox1.Location = new System.Drawing.Point(280, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(17, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Manage_Item_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources._02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(306, 431);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgv_item_details);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.cbx_choose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Manage_Item_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sharp Creations";
            this.Load += new System.EventHandler(this.Manage_Item_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item_details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_choose;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.DataGridView dgv_item_details;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}