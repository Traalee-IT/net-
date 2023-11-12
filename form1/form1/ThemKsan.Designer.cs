
namespace form1
{
    partial class ThemKsan
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVitri = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btThem = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaks = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(542, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(603, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "KHÁCH SẠN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(40, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách sạn ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(40, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Vị trí ";
            // 
            // txtVitri
            // 
            this.txtVitri.Location = new System.Drawing.Point(232, 124);
            this.txtVitri.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVitri.Name = "txtVitri";
            this.txtVitri.Size = new System.Drawing.Size(473, 26);
            this.txtVitri.TabIndex = 5;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(232, 73);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(473, 26);
            this.txtTen.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 96);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(830, 163);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThem.ForeColor = System.Drawing.Color.Navy;
            this.btThem.Image = global::form1.Properties.Resources.plus__5_;
            this.btThem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThem.Location = new System.Drawing.Point(44, 175);
            this.btThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(165, 63);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Add";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.ForeColor = System.Drawing.Color.Navy;
            this.btXoa.Image = global::form1.Properties.Resources.delete__4_;
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.Location = new System.Drawing.Point(232, 175);
            this.btXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(165, 63);
            this.btXoa.TabIndex = 9;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSua.ForeColor = System.Drawing.Color.Navy;
            this.btSua.Image = global::form1.Properties.Resources.sync;
            this.btSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSua.Location = new System.Drawing.Point(433, 175);
            this.btSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(165, 63);
            this.btSua.TabIndex = 10;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtMaks);
            this.groupBox1.Controls.Add(this.btClear);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.txtVitri);
            this.groupBox1.Location = new System.Drawing.Point(225, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(848, 255);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(40, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 23);
            this.label6.TabIndex = 15;
            this.label6.Text = "Mã khách sạn";
            // 
            // txtMaks
            // 
            this.txtMaks.Location = new System.Drawing.Point(232, 24);
            this.txtMaks.Name = "txtMaks";
            this.txtMaks.Size = new System.Drawing.Size(473, 26);
            this.txtMaks.TabIndex = 12;
            // 
            // btClear
            // 
            this.btClear.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btClear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClear.ForeColor = System.Drawing.Color.Navy;
            this.btClear.Image = global::form1.Properties.Resources.clear__2_;
            this.btClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btClear.Location = new System.Drawing.Point(631, 175);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(165, 63);
            this.btClear.TabIndex = 11;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = false;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTim);
            this.groupBox2.Controls.Add(this.btSearch);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(225, 425);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(848, 267);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(232, 45);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(473, 26);
            this.txtTim.TabIndex = 9;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.Navy;
            this.btSearch.Image = global::form1.Properties.Resources.search__2_;
            this.btSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btSearch.Location = new System.Drawing.Point(44, 25);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(165, 63);
            this.btSearch.TabIndex = 8;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ThemKsan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThemKsan";
            this.Size = new System.Drawing.Size(1238, 837);
            this.Load += new System.EventHandler(this.ThemKsan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVitri;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaks;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
