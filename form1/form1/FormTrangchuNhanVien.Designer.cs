
namespace form1
{
    partial class FormTrangchuNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnttcanhan = new System.Windows.Forms.Button();
            this.btnThme = new System.Windows.Forms.Button();
            this.btnDangky = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelUserControl = new System.Windows.Forms.Panel();
            this.homeU1 = new form1.HomeU();
            this.panel1.SuspendLayout();
            this.panelUserControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.btnttcanhan);
            this.panel1.Controls.Add(this.btnThme);
            this.panel1.Controls.Add(this.btnDangky);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1704, 88);
            this.panel1.TabIndex = 0;
            // 
            // btnttcanhan
            // 
            this.btnttcanhan.Location = new System.Drawing.Point(782, 18);
            this.btnttcanhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnttcanhan.Name = "btnttcanhan";
            this.btnttcanhan.Size = new System.Drawing.Size(262, 62);
            this.btnttcanhan.TabIndex = 1;
            this.btnttcanhan.Text = "NhânCá ";
            this.btnttcanhan.UseVisualStyleBackColor = true;
            this.btnttcanhan.Click += new System.EventHandler(this.btnttcanhan_Click);
            // 
            // btnThme
            // 
            this.btnThme.BackColor = System.Drawing.Color.Wheat;
            this.btnThme.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThme.ForeColor = System.Drawing.Color.Navy;
            this.btnThme.Image = global::form1.Properties.Resources.business;
            this.btnThme.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThme.Location = new System.Drawing.Point(524, 12);
            this.btnThme.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThme.Name = "btnThme";
            this.btnThme.Size = new System.Drawing.Size(220, 71);
            this.btnThme.TabIndex = 2;
            this.btnThme.Text = "Thông Tin";
            this.btnThme.UseVisualStyleBackColor = false;
            this.btnThme.Click += new System.EventHandler(this.btnThme_Click);
            // 
            // btnDangky
            // 
            this.btnDangky.BackColor = System.Drawing.Color.Wheat;
            this.btnDangky.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangky.ForeColor = System.Drawing.Color.Navy;
            this.btnDangky.Image = global::form1.Properties.Resources.route;
            this.btnDangky.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangky.Location = new System.Drawing.Point(253, 12);
            this.btnDangky.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangky.Name = "btnDangky";
            this.btnDangky.Size = new System.Drawing.Size(244, 71);
            this.btnDangky.TabIndex = 1;
            this.btnDangky.Text = "Đăng Ký Tour";
            this.btnDangky.UseVisualStyleBackColor = false;
            this.btnDangky.Click += new System.EventHandler(this.btnDangky_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Wheat;
            this.btnHome.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.Navy;
            this.btnHome.Image = global::form1.Properties.Resources.home_button;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHome.Location = new System.Drawing.Point(9, 12);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(216, 71);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Trang Chủ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelUserControl
            // 
            this.panelUserControl.AutoSize = true;
            this.panelUserControl.BackColor = System.Drawing.Color.DarkRed;
            this.panelUserControl.Controls.Add(this.homeU1);
            this.panelUserControl.Location = new System.Drawing.Point(4, 95);
            this.panelUserControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelUserControl.Name = "panelUserControl";
            this.panelUserControl.Size = new System.Drawing.Size(1710, 1015);
            this.panelUserControl.TabIndex = 1;
            this.panelUserControl.Paint += new System.Windows.Forms.PaintEventHandler(this.panelUserControl_Paint);
            // 
            // homeU1
            // 
            this.homeU1.BackColor = System.Drawing.Color.Snow;
            this.homeU1.Location = new System.Drawing.Point(3, 8);
            this.homeU1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.homeU1.Name = "homeU1";
            this.homeU1.Size = new System.Drawing.Size(1701, 976);
            this.homeU1.TabIndex = 0;
            this.homeU1.Load += new System.EventHandler(this.homeU1_Load);
            // 
            // FormTrangchuNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1712, 1050);
            this.Controls.Add(this.panelUserControl);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormTrangchuNhanVien";
            this.Text = "FormTrangchuNhanVien";
            this.Load += new System.EventHandler(this.FormTrangchuNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panelUserControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnttcanhan;
        private System.Windows.Forms.Button btnThme;
        private System.Windows.Forms.Button btnDangky;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panelUserControl;
        private HomeU homeU1;
    }
}