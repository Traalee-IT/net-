
namespace form1
{
    partial class QuanlyThongKe
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
            this.dgvThongke = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttimkiemtheothang = new System.Windows.Forms.TextBox();
            this.txttongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongke
            // 
            this.dgvThongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongke.Location = new System.Drawing.Point(12, 234);
            this.dgvThongke.Name = "dgvThongke";
            this.dgvThongke.RowHeadersWidth = 62;
            this.dgvThongke.RowTemplate.Height = 28;
            this.dgvThongke.Size = new System.Drawing.Size(853, 231);
            this.dgvThongke.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thống kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm theo tháng ";
            // 
            // txttimkiemtheothang
            // 
            this.txttimkiemtheothang.Location = new System.Drawing.Point(285, 77);
            this.txttimkiemtheothang.Name = "txttimkiemtheothang";
            this.txttimkiemtheothang.Size = new System.Drawing.Size(343, 26);
            this.txttimkiemtheothang.TabIndex = 3;
            // 
            // txttongtien
            // 
            this.txttongtien.Location = new System.Drawing.Point(285, 138);
            this.txttongtien.Name = "txttongtien";
            this.txttongtien.Size = new System.Drawing.Size(343, 26);
            this.txttongtien.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng tiền";
            // 
            // QuanlyThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttongtien);
            this.Controls.Add(this.txttimkiemtheothang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvThongke);
            this.Name = "QuanlyThongKe";
            this.Text = "QLThongKe";
            this.Load += new System.EventHandler(this.QuanlyThongKe_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttimkiemtheothang;
        private System.Windows.Forms.TextBox txttongtien;
        private System.Windows.Forms.Label label3;
    }
}