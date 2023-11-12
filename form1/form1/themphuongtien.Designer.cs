
namespace form1
{
    partial class themphuongtien
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
            this.txtl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtmapt = new System.Windows.Forms.TextBox();
            this.txtloaipt = new System.Windows.Forms.TextBox();
            this.txttiemkiem = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btntkiem = new System.Windows.Forms.Button();
            this.btnclean = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.bntthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(465, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHƯƠNG TIỆN ";
            // 
            // txtl
            // 
            this.txtl.AutoSize = true;
            this.txtl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtl.ForeColor = System.Drawing.Color.Navy;
            this.txtl.Location = new System.Drawing.Point(21, 135);
            this.txtl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(194, 26);
            this.txtl.TabIndex = 2;
            this.txtl.Text = "Loại phương tiện ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(21, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mã phương tiện ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 197);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txtmapt
            // 
            this.txtmapt.Location = new System.Drawing.Point(246, 60);
            this.txtmapt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtmapt.Multiline = true;
            this.txtmapt.Name = "txtmapt";
            this.txtmapt.Size = new System.Drawing.Size(240, 37);
            this.txtmapt.TabIndex = 13;
            // 
            // txtloaipt
            // 
            this.txtloaipt.Location = new System.Drawing.Point(246, 129);
            this.txtloaipt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtloaipt.Multiline = true;
            this.txtloaipt.Name = "txtloaipt";
            this.txtloaipt.Size = new System.Drawing.Size(347, 32);
            this.txtloaipt.TabIndex = 14;
            // 
            // txttiemkiem
            // 
            this.txttiemkiem.Location = new System.Drawing.Point(313, 42);
            this.txttiemkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttiemkiem.Multiline = true;
            this.txttiemkiem.Name = "txttiemkiem";
            this.txttiemkiem.Size = new System.Drawing.Size(605, 34);
            this.txttiemkiem.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtmapt);
            this.groupBox1.Controls.Add(this.btnclean);
            this.groupBox1.Controls.Add(this.txtl);
            this.groupBox1.Controls.Add(this.txtloaipt);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.bntthem);
            this.groupBox1.Location = new System.Drawing.Point(97, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 241);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttiemkiem);
            this.groupBox2.Controls.Add(this.btntkiem);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(97, 389);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1039, 327);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::form1.Properties.Resources.icons8_bus_48;
            this.pictureBox1.Location = new System.Drawing.Point(720, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // btntkiem
            // 
            this.btntkiem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btntkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntkiem.ForeColor = System.Drawing.Color.Navy;
            this.btntkiem.Image = global::form1.Properties.Resources.search__2_;
            this.btntkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btntkiem.Location = new System.Drawing.Point(70, 27);
            this.btntkiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntkiem.Name = "btntkiem";
            this.btntkiem.Size = new System.Drawing.Size(164, 60);
            this.btntkiem.TabIndex = 11;
            this.btntkiem.Text = "Search";
            this.btntkiem.UseVisualStyleBackColor = false;
            this.btntkiem.Click += new System.EventHandler(this.btntkiem_Click);
            // 
            // btnclean
            // 
            this.btnclean.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclean.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclean.ForeColor = System.Drawing.Color.Navy;
            this.btnclean.Image = global::form1.Properties.Resources.clear__2_;
            this.btnclean.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclean.Location = new System.Drawing.Point(841, 146);
            this.btnclean.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclean.Name = "btnclean";
            this.btnclean.Size = new System.Drawing.Size(167, 63);
            this.btnclean.TabIndex = 16;
            this.btnclean.Text = "Clear";
            this.btnclean.UseVisualStyleBackColor = false;
            this.btnclean.Click += new System.EventHandler(this.btnclean_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.Color.Navy;
            this.btnxoa.Image = global::form1.Properties.Resources.delete__4_;
            this.btnxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.Location = new System.Drawing.Point(841, 40);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(170, 63);
            this.btnxoa.TabIndex = 7;
            this.btnxoa.Text = "Delete";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.Color.Navy;
            this.btnsua.Image = global::form1.Properties.Resources.sync;
            this.btnsua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.Location = new System.Drawing.Point(633, 40);
            this.btnsua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(165, 63);
            this.btnsua.TabIndex = 9;
            this.btnsua.Text = "Update";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // bntthem
            // 
            this.bntthem.AutoSize = true;
            this.bntthem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bntthem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntthem.ForeColor = System.Drawing.Color.Navy;
            this.bntthem.Image = global::form1.Properties.Resources.plus__5_;
            this.bntthem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntthem.Location = new System.Drawing.Point(633, 146);
            this.bntthem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bntthem.Name = "bntthem";
            this.bntthem.Size = new System.Drawing.Size(165, 63);
            this.bntthem.TabIndex = 8;
            this.bntthem.Text = "Add";
            this.bntthem.UseVisualStyleBackColor = false;
            this.bntthem.Click += new System.EventHandler(this.button2_Click);
            // 
            // themphuongtien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "themphuongtien";
            this.Size = new System.Drawing.Size(1233, 758);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label txtl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button bntthem;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btntkiem;
        private System.Windows.Forms.TextBox txtmapt;
        private System.Windows.Forms.TextBox txtloaipt;
        private System.Windows.Forms.TextBox txttiemkiem;
        private System.Windows.Forms.Button btnclean;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
