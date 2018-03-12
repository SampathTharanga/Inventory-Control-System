namespace Inventory_System
{
    partial class Find_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find_Customer));
            this.dgvFindCusto = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFindCustoEditItem = new System.Windows.Forms.Button();
            this.btn_view_CusAcc = new System.Windows.Forms.Button();
            this.btnFindCustoDeleteItem = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txtFindCustoLastName = new System.Windows.Forms.TextBox();
            this.btnFindCustoReset = new System.Windows.Forms.Button();
            this.btnFindCustoSearch = new System.Windows.Forms.Button();
            this.txtFindCustoFirstName = new System.Windows.Forms.TextBox();
            this.txtFindCusto4n = new System.Windows.Forms.TextBox();
            this.txtFindCustoCustoNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFindCusto
            // 
            this.dgvFindCusto.AllowUserToResizeColumns = false;
            this.dgvFindCusto.AllowUserToResizeRows = false;
            this.dgvFindCusto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFindCusto.BackgroundColor = System.Drawing.Color.White;
            this.dgvFindCusto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindCusto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFindCusto.Location = new System.Drawing.Point(32, 170);
            this.dgvFindCusto.Name = "dgvFindCusto";
            this.dgvFindCusto.Size = new System.Drawing.Size(692, 256);
            this.dgvFindCusto.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(332, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Find Customer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 480);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(754, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // btnFindCustoEditItem
            // 
            this.btnFindCustoEditItem.Image = global::Inventory_System.Properties.Resources.edit;
            this.btnFindCustoEditItem.Location = new System.Drawing.Point(32, 446);
            this.btnFindCustoEditItem.Name = "btnFindCustoEditItem";
            this.btnFindCustoEditItem.Size = new System.Drawing.Size(75, 23);
            this.btnFindCustoEditItem.TabIndex = 21;
            this.btnFindCustoEditItem.Text = "Edit ";
            this.btnFindCustoEditItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindCustoEditItem.UseVisualStyleBackColor = true;
            this.btnFindCustoEditItem.Click += new System.EventHandler(this.btnFindCustoEditItem_Click);
            // 
            // btn_view_CusAcc
            // 
            this.btn_view_CusAcc.Location = new System.Drawing.Point(639, 445);
            this.btn_view_CusAcc.Name = "btn_view_CusAcc";
            this.btn_view_CusAcc.Size = new System.Drawing.Size(85, 24);
            this.btn_view_CusAcc.TabIndex = 0;
            this.btn_view_CusAcc.Text = "View Account";
            this.btn_view_CusAcc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_view_CusAcc.UseVisualStyleBackColor = true;
            // 
            // btnFindCustoDeleteItem
            // 
            this.btnFindCustoDeleteItem.Image = global::Inventory_System.Properties.Resources.delete;
            this.btnFindCustoDeleteItem.Location = new System.Drawing.Point(149, 446);
            this.btnFindCustoDeleteItem.Name = "btnFindCustoDeleteItem";
            this.btnFindCustoDeleteItem.Size = new System.Drawing.Size(75, 23);
            this.btnFindCustoDeleteItem.TabIndex = 22;
            this.btnFindCustoDeleteItem.Text = "Delete ";
            this.btnFindCustoDeleteItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindCustoDeleteItem.UseVisualStyleBackColor = true;
            this.btnFindCustoDeleteItem.Click += new System.EventHandler(this.btnFindCustoDeleteItem_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(266, 447);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 24;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // txtFindCustoLastName
            // 
            this.txtFindCustoLastName.Location = new System.Drawing.Point(375, 27);
            this.txtFindCustoLastName.Name = "txtFindCustoLastName";
            this.txtFindCustoLastName.Size = new System.Drawing.Size(121, 20);
            this.txtFindCustoLastName.TabIndex = 34;
            this.txtFindCustoLastName.TextChanged += new System.EventHandler(this.txtFindCustoLastName_TextChanged);
            this.txtFindCustoLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindCustoLastName_KeyPress);
            // 
            // btnFindCustoReset
            // 
            this.btnFindCustoReset.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btnFindCustoReset.Location = new System.Drawing.Point(561, 61);
            this.btnFindCustoReset.Name = "btnFindCustoReset";
            this.btnFindCustoReset.Size = new System.Drawing.Size(85, 24);
            this.btnFindCustoReset.TabIndex = 33;
            this.btnFindCustoReset.Text = "Reset";
            this.btnFindCustoReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindCustoReset.UseVisualStyleBackColor = true;
            this.btnFindCustoReset.Click += new System.EventHandler(this.btnFindCustoReset_Click_1);
            // 
            // btnFindCustoSearch
            // 
            this.btnFindCustoSearch.Image = global::Inventory_System.Properties.Resources.find;
            this.btnFindCustoSearch.Location = new System.Drawing.Point(561, 26);
            this.btnFindCustoSearch.Name = "btnFindCustoSearch";
            this.btnFindCustoSearch.Size = new System.Drawing.Size(85, 24);
            this.btnFindCustoSearch.TabIndex = 32;
            this.btnFindCustoSearch.Text = " Search";
            this.btnFindCustoSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindCustoSearch.UseVisualStyleBackColor = true;
            // 
            // txtFindCustoFirstName
            // 
            this.txtFindCustoFirstName.Location = new System.Drawing.Point(128, 62);
            this.txtFindCustoFirstName.Name = "txtFindCustoFirstName";
            this.txtFindCustoFirstName.Size = new System.Drawing.Size(121, 20);
            this.txtFindCustoFirstName.TabIndex = 31;
            this.txtFindCustoFirstName.TextChanged += new System.EventHandler(this.txtFindCustoFirstName_TextChanged);
            this.txtFindCustoFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindCustoFirstName_KeyPress);
            // 
            // txtFindCusto4n
            // 
            this.txtFindCusto4n.Location = new System.Drawing.Point(375, 62);
            this.txtFindCusto4n.Name = "txtFindCusto4n";
            this.txtFindCusto4n.Size = new System.Drawing.Size(121, 20);
            this.txtFindCusto4n.TabIndex = 30;
            this.txtFindCusto4n.TextChanged += new System.EventHandler(this.txtFindCusto4n_TextChanged);
            this.txtFindCusto4n.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindCusto4n_KeyPress);
            // 
            // txtFindCustoCustoNo
            // 
            this.txtFindCustoCustoNo.Location = new System.Drawing.Point(128, 27);
            this.txtFindCustoCustoNo.Name = "txtFindCustoCustoNo";
            this.txtFindCustoCustoNo.Size = new System.Drawing.Size(75, 20);
            this.txtFindCustoCustoNo.TabIndex = 29;
            this.txtFindCustoCustoNo.TextChanged += new System.EventHandler(this.txtFindCustoCustoNo_TextChanged);
            this.txtFindCustoCustoNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindCustoCustoNo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Last Name       :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "First Name     :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mobile             :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customer No :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtFindCustoLastName);
            this.panel1.Controls.Add(this.btnFindCustoReset);
            this.panel1.Controls.Add(this.btnFindCustoSearch);
            this.panel1.Controls.Add(this.txtFindCustoFirstName);
            this.panel1.Controls.Add(this.txtFindCusto4n);
            this.panel1.Controls.Add(this.txtFindCustoCustoNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(32, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 108);
            this.panel1.TabIndex = 35;
            // 
            // Find_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFindCustoEditItem);
            this.Controls.Add(this.btn_view_CusAcc);
            this.Controls.Add(this.dgvFindCusto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFindCustoDeleteItem);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Find_Customer";
            this.Text = "Sharp Creation";
            this.Load += new System.EventHandler(this.Find_Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindCustoEditItem;
        private System.Windows.Forms.DataGridView dgvFindCusto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFindCustoDeleteItem;
        private System.Windows.Forms.Button btn_view_CusAcc;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txtFindCustoLastName;
        private System.Windows.Forms.Button btnFindCustoReset;
        private System.Windows.Forms.Button btnFindCustoSearch;
        private System.Windows.Forms.TextBox txtFindCustoFirstName;
        private System.Windows.Forms.TextBox txtFindCusto4n;
        private System.Windows.Forms.TextBox txtFindCustoCustoNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}