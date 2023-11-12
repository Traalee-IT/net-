
namespace form1
{
    partial class quanlynhanvien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanlynhanvien));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aDMINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bttclear = new System.Windows.Forms.Button();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.dateTimeNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 34);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aDMINToolStripMenuItem
            // 
            this.aDMINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem,
            this.quảnLýNhânViênToolStripMenuItem});
            this.aDMINToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aDMINToolStripMenuItem.ForeColor = System.Drawing.Color.MidnightBlue;
            this.aDMINToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aDMINToolStripMenuItem.Image")));
            this.aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            this.aDMINToolStripMenuItem.Size = new System.Drawing.Size(135, 30);
            this.aDMINToolStripMenuItem.Text = "ADMIN";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.ForeColor = System.Drawing.Color.DarkBlue;
            this.thốngKêToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("thốngKêToolStripMenuItem.Image")));
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(307, 34);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênToolStripMenuItem
            // 
            this.quảnLýNhânViênToolStripMenuItem.ForeColor = System.Drawing.Color.Navy;
            this.quảnLýNhânViênToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quảnLýNhânViênToolStripMenuItem.Image")));
            this.quảnLýNhânViênToolStripMenuItem.Name = "quảnLýNhânViênToolStripMenuItem";
            this.quảnLýNhânViênToolStripMenuItem.Size = new System.Drawing.Size(307, 34);
            this.quảnLýNhânViênToolStripMenuItem.Text = "Quản lý nhân viên ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 821);
            this.panel1.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btTim);
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(3, 486);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1144, 332);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 209);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btTim
            // 
            this.btTim.BackColor = System.Drawing.SystemColors.Control;
            this.btTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTim.ForeColor = System.Drawing.Color.Navy;
            this.btTim.Image = global::form1.Properties.Resources.search__2_;
            this.btTim.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTim.Location = new System.Drawing.Point(64, 25);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(177, 57);
            this.btTim.TabIndex = 10;
            this.btTim.Text = "Search";
            this.btTim.UseVisualStyleBackColor = false;
            this.btTim.Click += new System.EventHandler(this.btTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(296, 42);
            this.txtTim.Multiline = true;
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(622, 33);
            this.txtTim.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dateTimeNgaysinh);
            this.groupBox1.Controls.Add(this.cbGioitinh);
            this.groupBox1.Controls.Add(this.txtManhanvien);
            this.groupBox1.Controls.Add(this.txtQuequan);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Navy;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 477);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(191, 102);
            this.txtHoten.Multiline = true;
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(451, 34);
            this.txtHoten.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox3.Controls.Add(this.bttclear);
            this.groupBox3.Controls.Add(this.btThem);
            this.groupBox3.Controls.Add(this.btXoa);
            this.groupBox3.Controls.Add(this.btSua);
            this.groupBox3.ForeColor = System.Drawing.Color.Navy;
            this.groupBox3.Location = new System.Drawing.Point(672, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(438, 399);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // bttclear
            // 
            this.bttclear.BackColor = System.Drawing.SystemColors.Control;
            this.bttclear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttclear.Image = global::form1.Properties.Resources.clear__2_;
            this.bttclear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bttclear.Location = new System.Drawing.Point(228, 49);
            this.bttclear.Name = "bttclear";
            this.bttclear.Size = new System.Drawing.Size(177, 57);
            this.bttclear.TabIndex = 14;
            this.bttclear.Text = "Clear";
            this.bttclear.UseVisualStyleBackColor = false;
            this.bttclear.Click += new System.EventHandler(this.bttclear_Click_1);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.Control;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.Image = global::form1.Properties.Resources.plus__5_;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.Location = new System.Drawing.Point(15, 48);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(177, 57);
            this.btThem.TabIndex = 11;
            this.btThem.Text = "Add";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.Control;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = global::form1.Properties.Resources.delete__4_;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.Location = new System.Drawing.Point(228, 153);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(177, 57);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Delete";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.Control;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.Image = global::form1.Properties.Resources.sync;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.Location = new System.Drawing.Point(15, 153);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(177, 57);
            this.btSua.TabIndex = 13;
            this.btSua.Text = "Update";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // dateTimeNgaysinh
            // 
            this.dateTimeNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgaysinh.Location = new System.Drawing.Point(189, 329);
            this.dateTimeNgaysinh.Name = "dateTimeNgaysinh";
            this.dateTimeNgaysinh.Size = new System.Drawing.Size(232, 26);
            this.dateTimeNgaysinh.TabIndex = 10;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cbGioitinh.Location = new System.Drawing.Point(189, 157);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(212, 28);
            this.cbGioitinh.TabIndex = 10;
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(191, 43);
            this.txtManhanvien.Multiline = true;
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(451, 34);
            this.txtManhanvien.TabIndex = 14;
            // 
            // txtQuequan
            // 
            this.txtQuequan.Location = new System.Drawing.Point(189, 210);
            this.txtQuequan.Multiline = true;
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(451, 36);
            this.txtQuequan.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 387);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(451, 37);
            this.txtEmail.TabIndex = 11;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(189, 272);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(451, 36);
            this.txtSDT.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(19, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(19, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ngày sinh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(16, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(19, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "SDT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(15, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(19, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ tên ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên ";
            // 
            // quanlynhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 887);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "quanlynhanvien";
            this.Text = "quanlynhanvien";
            this.Load += new System.EventHandler(this.quanlynhanvien_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aDMINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeNgaysinh;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button bttclear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtHoten;
    }
}