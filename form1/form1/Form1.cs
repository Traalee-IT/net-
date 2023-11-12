using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class Form1 : Form
    {
   
        public Form1()
        {
            InitializeComponent();
            this.panel3.Controls.Add(new Dangnhap());
          
              
        }
        private void ShowUserControl(UserControl userControl)
        {
            // Xóa UserControl hiện tại (nếu có)
            panel3.Controls.Clear();

            // Thêm UserControl mới vào Panel
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Add(userControl);
        }

        private void btDangnhap_Click(object sender, EventArgs e)
        {
            ShowUserControl(new Dangnhap());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowUserControl(new dangky());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
