using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTour.Model
{
    class Taikhoan
    {
        private String taiKhoan;
        private String tenDn;
        private String matkhau;

        public Taikhoan(string taiKhoan, string tenDn, string matkhau)
        {
            this.TaiKhoan = taiKhoan;
            this.TenDn = tenDn;
            this.Matkhau = matkhau;
        }

        public string TaiKhoan { get => taiKhoan; set => taiKhoan = value; }
        public string TenDn { get => tenDn; set => tenDn = value; }
        public string Matkhau { get => matkhau; set => matkhau = value; }
        public void DangNhap(String taikhoan, String matkhau)
        {

        }
    }
}
