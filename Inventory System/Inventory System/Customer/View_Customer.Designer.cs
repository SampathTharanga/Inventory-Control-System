namespace Inventory_System
{
    partial class View_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Customer));
            this.dgvViewCusto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewCustoAddCusto = new System.Windows.Forms.Button();
            this.btnViewCustoEdit = new System.Windows.Forms.Button();
            this.btnViewCustoViewSales = new System.Windows.Forms.Button();
            this.btnViewCustoDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCusto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvViewCusto
            // 
            this.dgvViewCusto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewCusto.Location = new System.Drawing.Point(11, 19);
            this.dgvViewCusto.Name = "dgvViewCusto";
            this.dgvViewCusto.Size = new System.Drawing.Size(712, 396);
            this.dgvViewCusto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(322, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "View Customer";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvViewCusto);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(735, 431);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnViewCustoAddCusto
            // 
            this.btnViewCustoAddCusto.Location = new System.Drawing.Point(166, 469);
            this.btnViewCustoAddCusto.Name = "btnViewCustoAddCusto";
            this.btnViewCustoAddCusto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnViewCustoAddCusto.Size = new System.Drawing.Size(92, 23);
            this.btnViewCustoAddCusto.TabIndex = 3;
            this.btnViewCustoAddCusto.Text = "Add Customer";
            this.btnViewCustoAddCusto.UseVisualStyleBackColor = true;
            // 
            // btnViewCustoEdit
            // 
            this.btnViewCustoEdit.Location = new System.Drawing.Point(270, 469);
            this.btnViewCustoEdit.Name = "btnViewCustoEdit";
            this.btnViewCustoEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnViewCustoEdit.Size = new System.Drawing.Size(92, 23);
            this.btnViewCustoEdit.TabIndex = 4;
            this.btnViewCustoEdit.Text = "Edit";
            this.btnViewCustoEdit.UseVisualStyleBackColor = true;
            // 
            // btnViewCustoViewSales
            // 
            this.btnViewCustoViewSales.Location = new System.Drawing.Point(380, 469);
            this.btnViewCustoViewSales.Name = "btnViewCustoViewSales";
            this.btnViewCustoViewSales.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnViewCustoViewSales.Size = new System.Drawing.Size(92, 23);
            this.btnViewCustoViewSales.TabIndex = 5;
            this.btnViewCustoViewSales.Text = "View Sales";
            this.btnViewCustoViewSales.UseVisualStyleBackColor = true;
            // 
            // btnViewCustoDelete
            // 
            this.btnViewCustoDelete.Location = new System.Drawing.Point(489, 469);
            this.btnViewCustoDelete.Name = "btnViewCustoDelete";
            this.btnViewCustoDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnViewCustoDelete.Size = new System.Drawing.Size(92, 23);
            this.btnViewCustoDelete.TabIndex = 6;
            this.btnViewCustoDelete.Text = "Delete";
            this.btnViewCustoDelete.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 499);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // View_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 580);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnViewCustoDelete);
            this.Controls.Add(this.btnViewCustoViewSales);
            this.Controls.Add(this.btnViewCustoEdit);
            this.Controls.Add(this.btnViewCustoAddCusto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Customer";
            this.Text = "View_Customer";
            this.Load += new System.EventHandler(this.View_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewCusto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvViewCusto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewCustoAddCusto;
        private System.Windows.Forms.Button btnViewCustoEdit;
        private System.Windows.Forms.Button btnViewCustoViewSales;
        private System.Windows.Forms.Button btnViewCustoDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}