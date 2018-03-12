namespace Inventory_System
{
    partial class View_Requst_Order
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgv_reqst_odr = new System.Windows.Forms.DataGridView();
            this.txt_descrip = new System.Windows.Forms.TextBox();
            this.txtOrdorNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSupplier = new System.Windows.Forms.ComboBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.lbl_oNot = new System.Windows.Forms.Label();
            this.lbl_oYes = new System.Windows.Forms.Label();
            this.cbx_view = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reqst_odr)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Inventory_System.Properties.Resources.edit;
            this.btnEdit.Location = new System.Drawing.Point(403, 358);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 24);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btnCancel.Location = new System.Drawing.Point(590, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 24);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::Inventory_System.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(485, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 24);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgv_reqst_odr
            // 
            this.dgv_reqst_odr.AllowUserToAddRows = false;
            this.dgv_reqst_odr.AllowUserToDeleteRows = false;
            this.dgv_reqst_odr.AllowUserToOrderColumns = true;
            this.dgv_reqst_odr.AllowUserToResizeColumns = false;
            this.dgv_reqst_odr.AllowUserToResizeRows = false;
            this.dgv_reqst_odr.BackgroundColor = System.Drawing.Color.White;
            this.dgv_reqst_odr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reqst_odr.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_reqst_odr.Location = new System.Drawing.Point(16, 104);
            this.dgv_reqst_odr.Name = "dgv_reqst_odr";
            this.dgv_reqst_odr.Size = new System.Drawing.Size(657, 232);
            this.dgv_reqst_odr.TabIndex = 21;
            this.dgv_reqst_odr.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_reqst_odr_CellClick);
            // 
            // txt_descrip
            // 
            this.txt_descrip.Location = new System.Drawing.Point(405, 23);
            this.txt_descrip.Name = "txt_descrip";
            this.txt_descrip.Size = new System.Drawing.Size(154, 20);
            this.txt_descrip.TabIndex = 20;
            this.txt_descrip.TextChanged += new System.EventHandler(this.txt_descrip_TextChanged);
            this.txt_descrip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_descrip_KeyPress);
            // 
            // txtOrdorNo
            // 
            this.txtOrdorNo.Location = new System.Drawing.Point(76, 24);
            this.txtOrdorNo.Name = "txtOrdorNo";
            this.txtOrdorNo.Size = new System.Drawing.Size(100, 20);
            this.txtOrdorNo.TabIndex = 18;
            this.txtOrdorNo.TextChanged += new System.EventHandler(this.txtOrdorNo_TextChanged);
            this.txtOrdorNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrdorNo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(361, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Oder :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(190, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Supplier :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Order No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(268, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "View Requst Order";
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.FormattingEnabled = true;
            this.cbxSupplier.Location = new System.Drawing.Point(247, 23);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(100, 21);
            this.cbxSupplier.TabIndex = 25;
            this.cbxSupplier.SelectedIndexChanged += new System.EventHandler(this.cbxSupplier_SelectedIndexChanged);
            this.cbxSupplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxSupplier_KeyPress);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(485, 358);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 24);
            this.btn_select.TabIndex = 26;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Visible = false;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // lbl_oNot
            // 
            this.lbl_oNot.AutoSize = true;
            this.lbl_oNot.BackColor = System.Drawing.Color.Transparent;
            this.lbl_oNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oNot.ForeColor = System.Drawing.Color.Red;
            this.lbl_oNot.Location = new System.Drawing.Point(37, 364);
            this.lbl_oNot.Name = "lbl_oNot";
            this.lbl_oNot.Size = new System.Drawing.Size(141, 16);
            this.lbl_oNot.TabIndex = 27;
            this.lbl_oNot.Text = "Oder Not Received";
            this.lbl_oNot.Visible = false;
            // 
            // lbl_oYes
            // 
            this.lbl_oYes.AutoSize = true;
            this.lbl_oYes.BackColor = System.Drawing.Color.Transparent;
            this.lbl_oYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oYes.ForeColor = System.Drawing.Color.Green;
            this.lbl_oYes.Location = new System.Drawing.Point(50, 364);
            this.lbl_oYes.Name = "lbl_oYes";
            this.lbl_oYes.Size = new System.Drawing.Size(113, 16);
            this.lbl_oYes.TabIndex = 28;
            this.lbl_oYes.Text = "Oder Received";
            this.lbl_oYes.Visible = false;
            // 
            // cbx_view
            // 
            this.cbx_view.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbx_view.FormattingEnabled = true;
            this.cbx_view.Items.AddRange(new object[] {
            "All",
            "Received",
            "Not Received"});
            this.cbx_view.Location = new System.Drawing.Point(576, 23);
            this.cbx_view.Name = "cbx_view";
            this.cbx_view.Size = new System.Drawing.Size(88, 21);
            this.cbx_view.TabIndex = 29;
            this.cbx_view.Text = "All";
            this.cbx_view.SelectedIndexChanged += new System.EventHandler(this.cbx_view_SelectedIndexChanged);
            this.cbx_view.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbx_view_KeyPress);
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
            this.panel1.Controls.Add(this.cbx_view);
            this.panel1.Controls.Add(this.cbxSupplier);
            this.panel1.Controls.Add(this.txt_descrip);
            this.panel1.Controls.Add(this.txtOrdorNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-2, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 63);
            this.panel1.TabIndex = 30;
            // 
            // View_Requst_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources._02;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 394);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_oYes);
            this.Controls.Add(this.lbl_oNot);
            this.Controls.Add(this.btn_select);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgv_reqst_odr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "View_Requst_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sharp Creations";
            this.Load += new System.EventHandler(this.View_Requst_Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reqst_odr)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgv_reqst_odr;
        private System.Windows.Forms.TextBox txt_descrip;
        private System.Windows.Forms.TextBox txtOrdorNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSupplier;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.Label lbl_oNot;
        private System.Windows.Forms.Label lbl_oYes;
        private System.Windows.Forms.ComboBox cbx_view;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel1;
    }
}