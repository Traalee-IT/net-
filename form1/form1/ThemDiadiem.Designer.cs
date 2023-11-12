
namespace form1
{
    partial class ThemDiadiem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dvgdiadiem = new System.Windows.Forms.DataGridView();
            this.txtdiadiem = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.bntthem = new System.Windows.Forms.Button();
            this.bntxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgdiadiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(543, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỊA ĐIỂM ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(27, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên địa điểm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(27, 111);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // dvgdiadiem
            // 
            this.dvgdiadiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dvgdiadiem.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dvgdiadiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgdiadiem.Location = new System.Drawing.Point(7, 102);
            this.dvgdiadiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvgdiadiem.Name = "dvgdiadiem";
            this.dvgdiadiem.RowHeadersWidth = 62;
            this.dvgdiadiem.Size = new System.Drawing.Size(830, 150);
            this.dvgdiadiem.TabIndex = 9;
            this.dvgdiadiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgdiadiem_CellClick);
            // 
            // txtdiadiem
            // 
            this.txtdiadiem.Location = new System.Drawing.Point(218, 38);
            this.txtdiadiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdiadiem.Name = "txtdiadiem";
            this.txtdiadiem.Size = new System.Drawing.Size(523, 26);
            this.txtdiadiem.TabIndex = 11;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(218, 113);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(523, 26);
            this.txtdiachi.TabIndex = 12;
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(207, 47);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(523, 26);
            this.txttimkiem.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnclean);
            this.groupBox1.Controls.Add(this.txtdiadiem);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.bntthem);
            this.groupBox1.Controls.Add(this.bntxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Location = new System.Drawing.Point(185, 138);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 255);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttimkiem);
            this.groupBox2.Controls.Add(this.dvgdiadiem);
            this.groupBox2.Controls.Add(this.btnTimkiem);
            this.groupBox2.Location = new System.Drawing.Point(185, 422);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 269);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::form1.Properties.Resources.icons8_location_48;
            this.pictureBox1.Location = new System.Drawing.Point(693, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimkiem.ForeColor = System.Drawing.Color.Navy;
            this.btnTimkiem.Image = global::form1.Properties.Resources.search__2_;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimkiem.Location = new System.Drawing.Point(21, 27);
            this.btnTimkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(165, 63);
            this.btnTimkiem.TabIndex = 15;
            this.btnTimkiem.Text = "Search";
            this.btnTimkiem.UseVisualStyleBackColor = false;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclean.ForeColor = System.Drawing.Color.Navy;
            this.btnclean.Image = global::form1.Properties.Resources.clear__2_;
            this.btnclean.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclean.Location = new System.Drawing.Point(233, 170);
            this.btnclean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(165, 63);
            this.btnclean.TabIndex = 16;
            this.btnclean.Text = "Clear";
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // bntthem
            // 
            this.bntthem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bntthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntthem.ForeColor = System.Drawing.Color.Navy;
            this.bntthem.Image = global::form1.Properties.Resources.plus__5_;
            this.bntthem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntthem.Location = new System.Drawing.Point(659, 170);
            this.bntthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(165, 63);
            this.bntthem.TabIndex = 6;
            this.bntthem.Text = "Add";
            this.bntthem.UseVisualStyleBackColor = false;
            this.bntthem.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntxoa
            // 
            this.bntxoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bntxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntxoa.ForeColor = System.Drawing.Color.Navy;
            this.bntxoa.Image = global::form1.Properties.Resources.delete__4_;
            this.bntxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntxoa.Location = new System.Drawing.Point(448, 170);
            this.bntxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntxoa.Name = "bntxoa";
            this.bntxoa.Size = new System.Drawing.Size(165, 63);
            this.bntxoa.TabIndex = 7;
            this.bntxoa.Text = "Delete";
            this.bntxoa.UseVisualStyleBackColor = false;
            this.bntxoa.Click += new System.EventHandler(this.bntxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Navy;
            this.btnsua.Image = global::form1.Properties.Resources.sync;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.Location = new System.Drawing.Point(32, 170);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(165, 63);
            this.btnsua.TabIndex = 8;
            this.btnsua.Text = "Update";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // ThemDiadiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThemDiadiem";
            this.Size = new System.Drawing.Size(1233, 758);
            this.Load += new System.EventHandler(this.ThemDiadiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgdiadiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.Button bntxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridView dvgdiadiem;
        private System.Windows.Forms.TextBox txtdiadiem;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
