namespace Inventory_System
{
    partial class Set_ref_salary_taget
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
            this.dgv_Ref_Sal_Target = new System.Windows.Forms.DataGridView();
            this.cbx_ref_Name = new System.Windows.Forms.ComboBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tool_tip_emty = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ref_Sal_Target)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Ref_Sal_Target
            // 
            this.dgv_Ref_Sal_Target.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Ref_Sal_Target.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ref_Sal_Target.Location = new System.Drawing.Point(12, 123);
            this.dgv_Ref_Sal_Target.Name = "dgv_Ref_Sal_Target";
            this.dgv_Ref_Sal_Target.Size = new System.Drawing.Size(476, 238);
            this.dgv_Ref_Sal_Target.TabIndex = 0;
            // 
            // cbx_ref_Name
            // 
            this.cbx_ref_Name.FormattingEnabled = true;
            this.cbx_ref_Name.Location = new System.Drawing.Point(25, 18);
            this.cbx_ref_Name.Name = "cbx_ref_Name";
            this.cbx_ref_Name.Size = new System.Drawing.Size(121, 21);
            this.cbx_ref_Name.TabIndex = 1;
            this.cbx_ref_Name.SelectedIndexChanged += new System.EventHandler(this.cbx_ref_Name_SelectedIndexChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.Image = global::Inventory_System.Properties.Resources.edit;
            this.btn_edit.Location = new System.Drawing.Point(169, 371);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Edit";
            this.btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(151, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Self-Ref Salery  and Target";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Image = global::Inventory_System.Properties.Resources.cancel;
            this.btn_cancel.Location = new System.Drawing.Point(256, 371);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbx_ref_Name);
            this.panel1.Location = new System.Drawing.Point(12, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 67);
            this.panel1.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Show All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tool_tip_emty
            // 
            this.tool_tip_emty.IsBalloon = true;
            // 
            // Set_ref_salary_taget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 408);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_Ref_Sal_Target);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Set_ref_salary_taget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Set_ref_salary_taget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ref_Sal_Target)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Ref_Sal_Target;
        private System.Windows.Forms.ComboBox cbx_ref_Name;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip tool_tip_emty;
    }
}