using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace form1
{
    public partial class dangky : UserControl
    {
        
        public dangky()
        {
       
            InitializeComponent();
         
        }
        Ketnoi kn = new Ketnoi();
        public bool checkAccount(string ac)//check mk và tên tài khoản 
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");//Tên tk là abcd có chữ hoa và thường từ 0 -9 ko cho dấu chấm , có tầm 20 ký tự tức nhỏ < 24 ký tự  
            //Check  trả về true bắt buộc pải là từ a-z chữ hoa ...và check false khi ko may ấn @ có nghĩ là ko thuộc vào đây 
        }

        private void btDky_Click(object sender, EventArgs e)
        {
            string TenDangNhap = txtTendangnhap.Text;
            string MatKhau = txtMK.Text;
            string XacNhanMatKhau = txtXacnhanmk.Text;
          //  if (!checkAccount(TenDangNhap))
            //{
               // MessageBox.Show("Vui lòng nhập tên tài khoản dài 6 - 24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!");
              //  return;
         //   }
          //  if (!checkAccount(MatKhau))
           // {
               // MessageBox.Show("Vui lòng nhập mật khẩu dài 6 - 24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!");
               // return;
         //   }
            if (XacNhanMatKhau != MatKhau)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác !");
                return;
            }
            else
            {
                try
                {
                    
                    string query = string.Format("insert into TaiKhoan (TenDangNhap, MatKhau )" +
               " values (N'{0}', N'{1}')", txtTendangnhap.Text, txtMK.Text);
                bool kt = kn.Thucthi(query);
                if (kt)
                {
                  
               MessageBox.Show("đăng ký thành công ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                    MessageBox.Show("Them that bai");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi :" + ex.Message);
            }
          
            }

        }
     }
}

