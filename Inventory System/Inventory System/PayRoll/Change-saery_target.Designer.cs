namespace Inventory_System
{
    partial class Change_saery_target
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Change_saery_target));
            this.txt_sal = new System.Windows.Forms.TextBox();
            this.txt_tget = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_chnge = new System.Windows.Forms.Button();
            this.btn_set = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip_ss = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_sal
            // 
            this.txt_sal.Location = new System.Drawing.Point(125, 26);
            this.txt_sal.Name = "txt_sal";
            this.txt_sal.Size = new System.Drawing.Size(156, 20);
            this.txt_sal.TabIndex = 0;
            this.txt_sal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_sal_KeyPress);
            // 
            // txt_tget
            // 
            this.txt_tget.Location = new System.Drawing.Point(125, 58);
            this.txt_tget.Name = "txt_tget";
            this.txt_tget.Size = new System.Drawing.Size(156, 20);
            this.txt_tget.TabIndex = 1;
            this.txt_tget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tget_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monthly Salery  : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monthly Target : ";
            // 
            // button2
            // 
            this.button2.Image = global::Inventory_System.Properties.Resources.cancel;
            this.button2.Location = new System.Drawing.Point(212, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(67, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_chnge
            // 
            this.btn_chnge.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_chnge.Location = new System.Drawing.Point(135, 98);
            this.btn_chnge.Name = "btn_chnge";
            this.btn_chnge.Size = new System.Drawing.Size(71, 23);
            this.btn_chnge.TabIndex = 4;
            this.btn_chnge.Text = "Change";
            this.btn_chnge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_chnge.UseVisualStyleBackColor = true;
            this.btn_chnge.Click += new System.EventHandler(this.btn_chnge_Click);
            // 
            // btn_set
            // 
            this.btn_set.Image = global::Inventory_System.Properties.Resources.ok;
            this.btn_set.Location = new System.Drawing.Point(135, 98);
            this.btn_set.Name = "btn_set";
            this.btn_set.Size = new System.Drawing.Size(75, 23);
            this.btn_set.TabIndex = 6;
            this.btn_set.Text = "Set";
            this.btn_set.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_set.UseVisualStyleBackColor = true;
            this.btn_set.Click += new System.EventHandler(this.btn_set_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            this.errorProvider2.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider2.Icon")));
            // 
            // toolTip_ss
            // 
            this.toolTip_ss.IsBalloon = true;
            // 
            // Change_saery_target
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(317, 147);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_chnge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tget);
            this.Controls.Add(this.txt_sal);
            this.Controls.Add(this.btn_set);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Change_saery_target";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Enter Salery and Target ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Change_saery_target_FormClosed);
            this.Load += new System.EventHandler(this.Change_saery_target_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sal;
        private System.Windows.Forms.TextBox txt_tget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_chnge;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_set;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ToolTip toolTip_ss;
    }
}