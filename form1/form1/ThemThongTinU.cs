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
    public partial class ThemThongTinU : UserControl
    {
     public  Panel parentPanel;
        public ThemThongTinU()
        {
            InitializeComponent();
            panel2.Controls.Add(new ThemKhachHang());

        }
        private void ShowUserControl(UserControl userControl)
        {
            // Xóa UserControl hiện tại (nếu có)
            panel2.Controls.Clear();

            // Thêm UserControl mới vào Panel
            userControl.Dock = DockStyle.Fill;
            panel2.Controls.Add(userControl);
        }

        private void ThemThongTinU_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedFile = openFileDialog1.FileName; 
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowUserControl(new Themtour());



        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowUserControl(new themphuongtien());




        }

        private void button3_Click(object sender, EventArgs e)
        {


            ShowUserControl(new ThemKsan());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ThemDiadiem());
        }

        private void Themkhachhang_Click(object sender, EventArgs e)
        {
            ShowUserControl(new ThemKhachHang());
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
              
        }
    }
}
