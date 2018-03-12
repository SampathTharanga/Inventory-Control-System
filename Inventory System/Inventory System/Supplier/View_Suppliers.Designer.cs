namespace Inventory_System
{
    partial class View_Suppliers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Suppliers));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvViewSupp = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewSuppEditSupplier = new System.Windows.Forms.Button();
            this.btnViewSuppViewAcc = new System.Windows.Forms.Button();
            this.btnViewSuppDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFindSupLastName = new System.Windows.Forms.TextBox();
            this.btnFindCustoReset = new System.Windows.Forms.Button();
            this.btnFindCustoSearch = new System.Windows.Forms.Button();
            this.txtFindSupFirstName = new System.Windows.Forms.TextBox();
            this.txtFindSup4n = new System.Windows.Forms.TextBox();
            this.txtFindSupNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSupp)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(340, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suppliers";
            // 
            // dgvViewSupp
            // 
            this.dgvViewSupp.AllowUserToOrderColumns = true;
            this.dgvViewSupp.AllowUserToResizeColumns = false;
            this.dgvViewSupp.AllowUserToResizeRows = false;
            this.dgvViewSupp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvViewSupp.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvViewSupp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvViewSupp.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvViewSupp.Location = new System.Drawing.Point(13, 18);
            this.dgvViewSupp.Name = "dgvViewSupp";
            this.dgvViewSupp.Size = new System.Drawing.Size(704, 261);
            this.dgvViewSupp.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dgvViewSupp);
            this.groupBox1.Location = new System.Drawing.Point(12, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(730, 298);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnViewSuppEditSupplier
            // 
            this.btnViewSuppEditSupplier.Image = global::Inventory_System.Properties.Resources.edit;
            this.btnViewSuppEditSupplier.Location = new System.Drawing.Point(203, 468);
            this.btnViewSuppEditSupplier.Name = "btnViewSuppEditSupplier";
            this.btnViewSuppEditSupplier.Size = new System.Drawing.Size(104, 23);
            this.btnViewSuppEditSupplier.TabIndex = 4;
            this.btnViewSuppEditSupplier.Text = "Edit ";
            this.btnViewSuppEditSupplier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewSuppEditSupplier.UseVisualStyleBackColor = true;
            this.btnViewSuppEditSupplier.Click += new System.EventHandler(this.btnViewSuppEditSupplier_Click);
            // 
            // btnViewSuppViewAcc
            // 
            this.btnViewSuppViewAcc.Location = new System.Drawing.Point(447, 468);
            this.btnViewSuppViewAcc.Name = "btnViewSuppViewAcc";
            this.btnViewSuppViewAcc.Size = new System.Drawing.Size(104, 23);
            this.btnViewSuppViewAcc.TabIndex = 5;
            this.btnViewSuppViewAcc.Text = "View Account";
            this.btnViewSuppViewAcc.UseVisualStyleBackColor = true;
            this.btnViewSuppViewAcc.Click += new System.EventHandler(this.btnViewSuppViewAcc_Click);
            // 
            // btnViewSuppDelete
            // 
            this.btnViewSuppDelete.Image = global::Inventory_System.Properties.Resources.delete;
            this.btnViewSuppDelete.Location = new System.Drawing.Point(325, 468);
            this.btnViewSuppDelete.Name = "btnViewSuppDelete";
            this.btnViewSuppDelete.Size = new System.Drawing.Size(104, 23);
            this.btnViewSuppDelete.TabIndex = 6;
            this.btnViewSuppDelete.Text = "Delete";
            this.btnViewSuppDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnViewSuppDelete.UseVisualStyleBackColor = true;
            this.btnViewSuppDelete.Click += new System.EventHandler(this.btnViewSuppDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 503);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // txtFindSupLastName
            // 
            this.txtFindSupLastName.Location = new System.Drawing.Point(376, 26);
            this.txtFindSupLastName.Name = "txtFindSupLastName";
            this.txtFindSupLastName.Size = new System.Drawing.Size(121, 20);
            this.txtFindSupLastName.TabIndex = 33;
            this.txtFindSupLastName.TextChanged += new System.EventHandler(this.txtFindSupLastName_TextChanged);
            this.txtFindSupLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindSupLastName_KeyPress);
            // 
            // btnFindCustoReset
            // 
            this.btnFindCustoReset.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btnFindCustoReset.Location = new System.Drawing.Point(562, 60);
            this.btnFindCustoReset.Name = "btnFindCustoReset";
            this.btnFindCustoReset.Size = new System.Drawing.Size(85, 24);
            this.btnFindCustoReset.TabIndex = 32;
            this.btnFindCustoReset.Text = "Clear";
            this.btnFindCustoReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindCustoReset.UseVisualStyleBackColor = true;
            // 
            // btnFindCustoSearch
            // 
            this.btnFindCustoSearch.Image = global::Inventory_System.Properties.Resources.find;
            this.btnFindCustoSearch.Location = new System.Drawing.Point(562, 25);
            this.btnFindCustoSearch.Name = "btnFindCustoSearch";
            this.btnFindCustoSearch.Size = new System.Drawing.Size(85, 24);
            this.btnFindCustoSearch.TabIndex = 31;
            this.btnFindCustoSearch.Text = " Search";
            this.btnFindCustoSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindCustoSearch.UseVisualStyleBackColor = true;
            // 
            // txtFindSupFirstName
            // 
            this.txtFindSupFirstName.Location = new System.Drawing.Point(129, 61);
            this.txtFindSupFirstName.Name = "txtFindSupFirstName";
            this.txtFindSupFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFindSupFirstName.TabIndex = 30;
            this.txtFindSupFirstName.TextChanged += new System.EventHandler(this.txtFindSupFirstName_TextChanged);
            this.txtFindSupFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindSupFirstName_KeyPress);
            // 
            // txtFindSup4n
            // 
            this.txtFindSup4n.Location = new System.Drawing.Point(376, 61);
            this.txtFindSup4n.Name = "txtFindSup4n";
            this.txtFindSup4n.Size = new System.Drawing.Size(121, 20);
            this.txtFindSup4n.TabIndex = 29;
            this.txtFindSup4n.TextChanged += new System.EventHandler(this.txtFindSup4n_TextChanged);
            this.txtFindSup4n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindSup4n_KeyPress);
            // 
            // txtFindSupNo
            // 
            this.txtFindSupNo.Location = new System.Drawing.Point(129, 26);
            this.txtFindSupNo.Name = "txtFindSupNo";
            this.txtFindSupNo.Size = new System.Drawing.Size(75, 20);
            this.txtFindSupNo.TabIndex = 28;
            this.txtFindSupNo.TextChanged += new System.EventHandler(this.txtFindSupNo_TextChanged);
            this.txtFindSupNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindSupNo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Last Name       :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "First Name     :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mobile             :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Supplier No   :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtFindSupLastName);
            this.panel1.Controls.Add(this.btnFindCustoReset);
            this.panel1.Controls.Add(this.btnFindCustoSearch);
            this.panel1.Controls.Add(this.txtFindSupFirstName);
            this.panel1.Controls.Add(this.txtFindSup4n);
            this.panel1.Controls.Add(this.txtFindSupNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(25, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 123);
            this.panel1.TabIndex = 34;
            // 
            // View_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnViewSuppDelete);
            this.Controls.Add(this.btnViewSuppViewAcc);
            this.Controls.Add(this.btnViewSuppEditSupplier);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "View_Suppliers";
            this.Text = "Suppliers";
            this.Load += new System.EventHandler(this.View_Suppliers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvViewSupp)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvViewSupp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewSuppEditSupplier;
        private System.Windows.Forms.Button btnViewSuppViewAcc;
        private System.Windows.Forms.Button btnViewSuppDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFindSupLastName;
        private System.Windows.Forms.Button btnFindCustoReset;
        private System.Windows.Forms.Button btnFindCustoSearch;
        private System.Windows.Forms.TextBox txtFindSupFirstName;
        private System.Windows.Forms.TextBox txtFindSup4n;
        private System.Windows.Forms.TextBox txtFindSupNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}