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
    public partial class Dangnhap : UserControl
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();

        private void btDangnhap1_Click(object sender, EventArgs e)
        {
            string query = string.Format("select * from TaiKhoan where TenDangNhap = '{0}' and MatKhau = '{1}'", txtEmail.Text, txtMatkhau.Text);
            DataSet ds = kn.selectData(query);
            if (ds.Tables[0].Rows.Count == 1)
            {
                MessageBox.Show("Đăng nhập thành công ");
                new FormTrangchuNhanVien().Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại ");
            }
        }

       
    }
 }
 
