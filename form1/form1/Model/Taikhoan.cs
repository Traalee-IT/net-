using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1.Model
{
    class Taikhoan
    {


        private int MaUse;
        private string TenDangNhap;
        private string MatKhau;

        public Taikhoan(int maUse, string tenDangNhap, string matKhau)
        {
            MaUse = maUse;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
        }

        public int MaUse1 { get => MaUse; set => MaUse = value; }
        public string TenDangNhap1 { get => TenDangNhap; set => TenDangNhap = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
    }
}
