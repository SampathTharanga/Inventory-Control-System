namespace Inventory_System
{
    partial class paysheet_histry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paysheet_histry));
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_usernn = new System.Windows.Forms.ComboBox();
            this.dgv_Histry = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_year = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.cbx_month = new System.Windows.Forms.ComboBox();
            this.errorProvider_Unme = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_yer = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_mon = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_rreset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.lbl_tot_sal = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lbl_etra_sal = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.lbl_extr_com_tgt = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.lbl_com_tgt = new System.Windows.Forms.Label();
            this.lbl_mon_tgt = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.lbl_aditionl_receved = new System.Windows.Forms.Label();
            this.lbl_sal_rest = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lbl_recevd_sal = new System.Windows.Forms.Label();
            this.lbl_totsal1 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lbl_mon_sal = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.lbl_net_sal = new System.Windows.Forms.Label();
            this.lbl_reming = new System.Windows.Forms.Label();
            this.lbl_arias = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Histry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Unme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_yer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mon)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "User Name";
            // 
            // cbx_usernn
            // 
            this.cbx_usernn.FormattingEnabled = true;
            this.cbx_usernn.Location = new System.Drawing.Point(102, 19);
            this.cbx_usernn.Name = "cbx_usernn";
            this.cbx_usernn.Size = new System.Drawing.Size(114, 21);
            this.cbx_usernn.TabIndex = 22;
            this.cbx_usernn.SelectedIndexChanged += new System.EventHandler(this.cbx_usernn_SelectedIndexChanged);
            // 
            // dgv_Histry
            // 
            this.dgv_Histry.AllowUserToResizeColumns = false;
            this.dgv_Histry.AllowUserToResizeRows = false;
            this.dgv_Histry.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Histry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Histry.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgv_Histry.Location = new System.Drawing.Point(8, 76);
            this.dgv_Histry.Name = "dgv_Histry";
            this.dgv_Histry.Size = new System.Drawing.Size(752, 223);
            this.dgv_Histry.TabIndex = 17;
            this.dgv_Histry.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Histry_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(255, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Year";
            // 
            // cbx_year
            // 
            this.cbx_year.FormattingEnabled = true;
            this.cbx_year.Location = new System.Drawing.Point(301, 19);
            this.cbx_year.Name = "cbx_year";
            this.cbx_year.Size = new System.Drawing.Size(92, 21);
            this.cbx_year.TabIndex = 24;
            this.cbx_year.SelectedIndexChanged += new System.EventHandler(this.cbx_year_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Location = new System.Drawing.Point(438, 22);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(37, 13);
            this.label32.TabIndex = 27;
            this.label32.Text = "Month";
            // 
            // cbx_month
            // 
            this.cbx_month.FormattingEnabled = true;
            this.cbx_month.Location = new System.Drawing.Point(490, 19);
            this.cbx_month.Name = "cbx_month";
            this.cbx_month.Size = new System.Drawing.Size(47, 21);
            this.cbx_month.TabIndex = 26;
            this.cbx_month.SelectedIndexChanged += new System.EventHandler(this.cbx_month_SelectedIndexChanged);
            // 
            // errorProvider_Unme
            // 
            this.errorProvider_Unme.ContainerControl = this;
            this.errorProvider_Unme.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_Unme.Icon")));
            // 
            // errorProvider_yer
            // 
            this.errorProvider_yer.ContainerControl = this;
            this.errorProvider_yer.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_yer.Icon")));
            // 
            // errorProvider_mon
            // 
            this.errorProvider_mon.ContainerControl = this;
            this.errorProvider_mon.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider_mon.Icon")));
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.btn_rreset);
            this.panel4.Controls.Add(this.label32);
            this.panel4.Controls.Add(this.cbx_month);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.cbx_year);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cbx_usernn);
            this.panel4.Location = new System.Drawing.Point(1, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(758, 53);
            this.panel4.TabIndex = 28;
            // 
            // btn_rreset
            // 
            this.btn_rreset.Image = global::Inventory_System.Properties.Resources.refresh;
            this.btn_rreset.Location = new System.Drawing.Point(647, 17);
            this.btn_rreset.Name = "btn_rreset";
            this.btn_rreset.Size = new System.Drawing.Size(75, 24);
            this.btn_rreset.TabIndex = 28;
            this.btn_rreset.Text = "Reset";
            this.btn_rreset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_rreset.UseVisualStyleBackColor = true;
            this.btn_rreset.Click += new System.EventHandler(this.btn_rreset_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel20);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.lbl_tot_sal);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(this.lbl_etra_sal);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.lbl_extr_com_tgt);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.lbl_com_tgt);
            this.panel2.Controls.Add(this.lbl_mon_tgt);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(247, 316);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 217);
            this.panel2.TabIndex = 31;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel20.Location = new System.Drawing.Point(27, 193);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(185, 1);
            this.panel20.TabIndex = 56;
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel15.Location = new System.Drawing.Point(27, 164);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(185, 1);
            this.panel15.TabIndex = 56;
            // 
            // lbl_tot_sal
            // 
            this.lbl_tot_sal.AutoSize = true;
            this.lbl_tot_sal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_tot_sal.Location = new System.Drawing.Point(131, 176);
            this.lbl_tot_sal.Name = "lbl_tot_sal";
            this.lbl_tot_sal.Size = new System.Drawing.Size(0, 13);
            this.lbl_tot_sal.TabIndex = 17;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel14.Location = new System.Drawing.Point(27, 135);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(185, 1);
            this.panel14.TabIndex = 56;
            // 
            // lbl_etra_sal
            // 
            this.lbl_etra_sal.AutoSize = true;
            this.lbl_etra_sal.ForeColor = System.Drawing.Color.Green;
            this.lbl_etra_sal.Location = new System.Drawing.Point(131, 148);
            this.lbl_etra_sal.Name = "lbl_etra_sal";
            this.lbl_etra_sal.Size = new System.Drawing.Size(0, 13);
            this.lbl_etra_sal.TabIndex = 16;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel13.Location = new System.Drawing.Point(27, 108);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(185, 1);
            this.panel13.TabIndex = 56;
            // 
            // lbl_extr_com_tgt
            // 
            this.lbl_extr_com_tgt.AutoSize = true;
            this.lbl_extr_com_tgt.ForeColor = System.Drawing.Color.Green;
            this.lbl_extr_com_tgt.Location = new System.Drawing.Point(131, 121);
            this.lbl_extr_com_tgt.Name = "lbl_extr_com_tgt";
            this.lbl_extr_com_tgt.Size = new System.Drawing.Size(0, 13);
            this.lbl_extr_com_tgt.TabIndex = 15;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel12.Location = new System.Drawing.Point(27, 79);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(185, 1);
            this.panel12.TabIndex = 56;
            // 
            // lbl_com_tgt
            // 
            this.lbl_com_tgt.AutoSize = true;
            this.lbl_com_tgt.ForeColor = System.Drawing.Color.Blue;
            this.lbl_com_tgt.Location = new System.Drawing.Point(131, 89);
            this.lbl_com_tgt.Name = "lbl_com_tgt";
            this.lbl_com_tgt.Size = new System.Drawing.Size(0, 13);
            this.lbl_com_tgt.TabIndex = 14;
            // 
            // lbl_mon_tgt
            // 
            this.lbl_mon_tgt.AutoSize = true;
            this.lbl_mon_tgt.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_mon_tgt.Location = new System.Drawing.Point(131, 61);
            this.lbl_mon_tgt.Name = "lbl_mon_tgt";
            this.lbl_mon_tgt.Size = new System.Drawing.Size(0, 13);
            this.lbl_mon_tgt.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(24, 173);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Total Salery           : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Extra Salery           : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "Extra Completed    : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Completed Target  : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Monthly Target      : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(110, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Month";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.panel19);
            this.panel3.Controls.Add(this.lbl_aditionl_receved);
            this.panel3.Controls.Add(this.lbl_sal_rest);
            this.panel3.Controls.Add(this.panel18);
            this.panel3.Controls.Add(this.lbl_recevd_sal);
            this.panel3.Controls.Add(this.lbl_totsal1);
            this.panel3.Controls.Add(this.panel17);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.panel16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(519, 316);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(231, 217);
            this.panel3.TabIndex = 30;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel19.Location = new System.Drawing.Point(30, 166);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(185, 1);
            this.panel19.TabIndex = 56;
            // 
            // lbl_aditionl_receved
            // 
            this.lbl_aditionl_receved.AutoSize = true;
            this.lbl_aditionl_receved.ForeColor = System.Drawing.Color.Red;
            this.lbl_aditionl_receved.Location = new System.Drawing.Point(140, 146);
            this.lbl_aditionl_receved.Name = "lbl_aditionl_receved";
            this.lbl_aditionl_receved.Size = new System.Drawing.Size(0, 13);
            this.lbl_aditionl_receved.TabIndex = 24;
            // 
            // lbl_sal_rest
            // 
            this.lbl_sal_rest.AutoSize = true;
            this.lbl_sal_rest.ForeColor = System.Drawing.Color.Green;
            this.lbl_sal_rest.Location = new System.Drawing.Point(140, 121);
            this.lbl_sal_rest.Name = "lbl_sal_rest";
            this.lbl_sal_rest.Size = new System.Drawing.Size(0, 13);
            this.lbl_sal_rest.TabIndex = 23;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel18.Location = new System.Drawing.Point(30, 136);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(185, 1);
            this.panel18.TabIndex = 56;
            // 
            // lbl_recevd_sal
            // 
            this.lbl_recevd_sal.AutoSize = true;
            this.lbl_recevd_sal.ForeColor = System.Drawing.Color.Blue;
            this.lbl_recevd_sal.Location = new System.Drawing.Point(140, 89);
            this.lbl_recevd_sal.Name = "lbl_recevd_sal";
            this.lbl_recevd_sal.Size = new System.Drawing.Size(0, 13);
            this.lbl_recevd_sal.TabIndex = 22;
            // 
            // lbl_totsal1
            // 
            this.lbl_totsal1.AutoSize = true;
            this.lbl_totsal1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_totsal1.Location = new System.Drawing.Point(140, 61);
            this.lbl_totsal1.Name = "lbl_totsal1";
            this.lbl_totsal1.Size = new System.Drawing.Size(0, 13);
            this.lbl_totsal1.TabIndex = 21;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel17.Location = new System.Drawing.Point(30, 108);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(185, 1);
            this.panel17.TabIndex = 56;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(27, 146);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(114, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Additional Received  : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 89);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Received Salary        : ";
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel16.Location = new System.Drawing.Point(30, 79);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(185, 1);
            this.panel16.TabIndex = 56;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 119);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Salary Balance          : ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Total Salery               : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(93, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Salery";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back_group;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.lbl_mon_sal);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.lbl_net_sal);
            this.panel1.Controls.Add(this.lbl_reming);
            this.panel1.Controls.Add(this.lbl_arias);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 316);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 217);
            this.panel1.TabIndex = 29;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel11.Location = new System.Drawing.Point(19, 164);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(185, 1);
            this.panel11.TabIndex = 56;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel10.Location = new System.Drawing.Point(19, 135);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(185, 1);
            this.panel10.TabIndex = 56;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel9.Location = new System.Drawing.Point(19, 108);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(185, 1);
            this.panel9.TabIndex = 56;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel8.Location = new System.Drawing.Point(19, 79);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(185, 1);
            this.panel8.TabIndex = 56;
            // 
            // lbl_mon_sal
            // 
            this.lbl_mon_sal.AutoSize = true;
            this.lbl_mon_sal.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lbl_mon_sal.Location = new System.Drawing.Point(118, 61);
            this.lbl_mon_sal.Name = "lbl_mon_sal";
            this.lbl_mon_sal.Size = new System.Drawing.Size(0, 13);
            this.lbl_mon_sal.TabIndex = 14;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(16, 61);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 13);
            this.label31.TabIndex = 13;
            this.label31.Text = "Monthly Salery      : ";
            // 
            // lbl_net_sal
            // 
            this.lbl_net_sal.AutoSize = true;
            this.lbl_net_sal.ForeColor = System.Drawing.Color.Blue;
            this.lbl_net_sal.Location = new System.Drawing.Point(118, 145);
            this.lbl_net_sal.Name = "lbl_net_sal";
            this.lbl_net_sal.Size = new System.Drawing.Size(0, 13);
            this.lbl_net_sal.TabIndex = 12;
            // 
            // lbl_reming
            // 
            this.lbl_reming.AutoSize = true;
            this.lbl_reming.ForeColor = System.Drawing.Color.Green;
            this.lbl_reming.Location = new System.Drawing.Point(118, 117);
            this.lbl_reming.Name = "lbl_reming";
            this.lbl_reming.Size = new System.Drawing.Size(0, 13);
            this.lbl_reming.TabIndex = 11;
            // 
            // lbl_arias
            // 
            this.lbl_arias.AutoSize = true;
            this.lbl_arias.ForeColor = System.Drawing.Color.Red;
            this.lbl_arias.Location = new System.Drawing.Point(118, 89);
            this.lbl_arias.Name = "lbl_arias";
            this.lbl_arias.Size = new System.Drawing.Size(0, 13);
            this.lbl_arias.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Net month Salery  : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Old Remaining      : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Old Arrears            : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(90, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "History";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Location = new System.Drawing.Point(8, 544);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(757, 1);
            this.panel6.TabIndex = 56;
            // 
            // paysheet_histry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventory_System.Properties.Resources.inventry_back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 553);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dgv_Histry);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paysheet_histry";
            this.Text = "paysheet_histry";
            this.Load += new System.EventHandler(this.paysheet_histry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Histry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Unme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_yer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_mon)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_usernn;
        private System.Windows.Forms.DataGridView dgv_Histry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_year;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox cbx_month;
        private System.Windows.Forms.ErrorProvider errorProvider_Unme;
        private System.Windows.Forms.ErrorProvider errorProvider_yer;
        private System.Windows.Forms.ErrorProvider errorProvider_mon;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_rreset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label lbl_tot_sal;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label lbl_etra_sal;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lbl_extr_com_tgt;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label lbl_com_tgt;
        private System.Windows.Forms.Label lbl_mon_tgt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label lbl_aditionl_receved;
        private System.Windows.Forms.Label lbl_sal_rest;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Label lbl_recevd_sal;
        private System.Windows.Forms.Label lbl_totsal1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lbl_mon_sal;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lbl_net_sal;
        private System.Windows.Forms.Label lbl_reming;
        private System.Windows.Forms.Label lbl_arias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;

    }
}