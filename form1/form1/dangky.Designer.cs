namespace form1
{
    partial class dangky
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDky = new System.Windows.Forms.Button();
            this.txtXacnhanmk = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTendangnhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbdangly = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.btDky);
            this.panel1.Controls.Add(this.txtXacnhanmk);
            this.panel1.Controls.Add(this.txtMK);
            this.panel1.Controls.Add(this.txtTendangnhap);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbdangly);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 513);
            this.panel1.TabIndex = 0;
            // 
            // btDky
            // 
            this.btDky.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDky.Location = new System.Drawing.Point(368, 430);
            this.btDky.Name = "btDky";
            this.btDky.Size = new System.Drawing.Size(136, 52);
            this.btDky.TabIndex = 4;
            this.btDky.Text = "Đăng ký";
            this.btDky.UseVisualStyleBackColor = true;
            this.btDky.Click += new System.EventHandler(this.btDky_Click);
            // 
            // txtXacnhanmk
            // 
            this.txtXacnhanmk.Location = new System.Drawing.Point(53, 362);
            this.txtXacnhanmk.Multiline = true;
            this.txtXacnhanmk.Name = "txtXacnhanmk";
            this.txtXacnhanmk.Size = new System.Drawing.Size(451, 37);
            this.txtXacnhanmk.TabIndex = 3;
            this.txtXacnhanmk.UseSystemPasswordChar = true;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(53, 252);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(451, 38);
            this.txtMK.TabIndex = 2;
            this.txtMK.UseSystemPasswordChar = true;
            // 
            // txtTendangnhap
            // 
            this.txtTendangnhap.Location = new System.Drawing.Point(53, 142);
            this.txtTendangnhap.Multiline = true;
            this.txtTendangnhap.Name = "txtTendangnhap";
            this.txtTendangnhap.Size = new System.Drawing.Size(451, 36);
            this.txtTendangnhap.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Xác nhận mật khẩu ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mật khẩu ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tài khoản";
            // 
            // lbdangly
            // 
            this.lbdangly.AutoSize = true;
            this.lbdangly.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdangly.ForeColor = System.Drawing.Color.Black;
            this.lbdangly.Location = new System.Drawing.Point(158, 30);
            this.lbdangly.Name = "lbdangly";
            this.lbdangly.Size = new System.Drawing.Size(270, 25);
            this.lbdangly.TabIndex = 0;
            this.lbdangly.Text = "ĐĂNG KÝ TRAVELTOUR";
            // 
            // dangky
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "dangky";
            this.Size = new System.Drawing.Size(588, 516);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbdangly;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXacnhanmk;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTendangnhap;
        private System.Windows.Forms.Button btDky;
    }
}
