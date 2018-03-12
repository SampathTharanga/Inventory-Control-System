namespace Inventory_System
{
    partial class Rpot_ItemList
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
            this.pnl_itmlst = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_ctgy = new System.Windows.Forms.ComboBox();
            this.cbx_subctgy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnl_itmlst
            // 
            this.pnl_itmlst.BackColor = System.Drawing.Color.Transparent;
            this.pnl_itmlst.Location = new System.Drawing.Point(4, 40);
            this.pnl_itmlst.Name = "pnl_itmlst";
            this.pnl_itmlst.Size = new System.Drawing.Size(626, 538);
            this.pnl_itmlst.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catogary";
            // 
            // cbx_ctgy
            // 
            this.cbx_ctgy.FormattingEnabled = true;
            this.cbx_ctgy.Location = new System.Drawing.Point(89, 6);
            this.cbx_ctgy.Name = "cbx_ctgy";
            this.cbx_ctgy.Size = new System.Drawing.Size(121, 21);
            this.cbx_ctgy.TabIndex = 2;
            this.cbx_ctgy.SelectedIndexChanged += new System.EventHandler(this.cbx_ctgy_SelectedIndexChanged);
            // 
            // cbx_subctgy
            // 
            this.cbx_subctgy.FormattingEnabled = true;
            this.cbx_subctgy.Location = new System.Drawing.Point(324, 6);
            this.cbx_subctgy.Name = "cbx_subctgy";
            this.cbx_subctgy.Size = new System.Drawing.Size(121, 21);
            this.cbx_subctgy.TabIndex = 4;
            this.cbx_subctgy.SelectedIndexChanged += new System.EventHandler(this.cbx_subctgy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(249, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sub Catogary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(536, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "All Item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rpot_ItemList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 582);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_subctgy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_ctgy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnl_itmlst);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Rpot_ItemList";
            this.Text = "Rpot_ItemList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Rpot_ItemList_FormClosing);
            this.Load += new System.EventHandler(this.Rpot_ItemList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_itmlst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_ctgy;
        private System.Windows.Forms.ComboBox cbx_subctgy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;

    }
}