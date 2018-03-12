namespace Inventory_System
{
    partial class Rpot_Sales
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
            this.cbxFindItemSubCategory = new System.Windows.Forms.ComboBox();
            this.cbxFindItemCategory = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_to = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_view = new System.Windows.Forms.Button();
            this.pnl_Rpot_sales = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxFindItemSubCategory
            // 
            this.cbxFindItemSubCategory.FormattingEnabled = true;
            this.cbxFindItemSubCategory.Location = new System.Drawing.Point(395, 41);
            this.cbxFindItemSubCategory.Name = "cbxFindItemSubCategory";
            this.cbxFindItemSubCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxFindItemSubCategory.TabIndex = 44;
            this.cbxFindItemSubCategory.SelectedIndexChanged += new System.EventHandler(this.cbxFindItemSubCategory_SelectedIndexChanged);
            // 
            // cbxFindItemCategory
            // 
            this.cbxFindItemCategory.FormattingEnabled = true;
            this.cbxFindItemCategory.Location = new System.Drawing.Point(395, 12);
            this.cbxFindItemCategory.Name = "cbxFindItemCategory";
            this.cbxFindItemCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxFindItemCategory.TabIndex = 43;
            this.cbxFindItemCategory.SelectedIndexChanged += new System.EventHandler(this.cbxFindItemCategory_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(318, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Sub-Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(318, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Category        :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "To Date     : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "From Date  : ";
            // 
            // dateTimePicker_to
            // 
            this.dateTimePicker_to.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_to.Location = new System.Drawing.Point(83, 44);
            this.dateTimePicker_to.Name = "dateTimePicker_to";
            this.dateTimePicker_to.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker_to.TabIndex = 47;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_From.Location = new System.Drawing.Point(80, 12);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(116, 20);
            this.dateTimePicker_From.TabIndex = 46;
            this.dateTimePicker_From.ValueChanged += new System.EventHandler(this.dateTimePicker_From_ValueChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btn_reset.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_reset.Location = new System.Drawing.Point(536, 18);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 24);
            this.btn_reset.TabIndex = 50;
            this.btn_reset.Text = "Reset";
            this.btn_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(216, 22);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(73, 23);
            this.btn_view.TabIndex = 51;
            this.btn_view.Text = "View Report";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // pnl_Rpot_sales
            // 
            this.pnl_Rpot_sales.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Rpot_sales.Location = new System.Drawing.Point(1, 72);
            this.pnl_Rpot_sales.Name = "pnl_Rpot_sales";
            this.pnl_Rpot_sales.Size = new System.Drawing.Size(630, 508);
            this.pnl_Rpot_sales.TabIndex = 52;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btn_view);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker_to);
            this.groupBox1.Controls.Add(this.dateTimePicker_From);
            this.groupBox1.Location = new System.Drawing.Point(4, -5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 71);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            // 
            // Rpot_Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 582);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_Rpot_sales);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.cbxFindItemSubCategory);
            this.Controls.Add(this.cbxFindItemCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_Sales";
            this.Text = "Rpot_Sales";
            this.Load += new System.EventHandler(this.Rpot_Sales_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxFindItemSubCategory;
        private System.Windows.Forms.ComboBox cbxFindItemCategory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.Panel pnl_Rpot_sales;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}