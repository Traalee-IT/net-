using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTour.Model
{
    class NganHang
    {
        private String SoTaiKhoan;
        private String TenNganHang;
        private String Nguoidung;

        public NganHang(string soTaiKhoan, string tenNganHang, string nguoidung)
        {
            SoTaiKhoan = soTaiKhoan;
            TenNganHang = tenNganHang;
            Nguoidung = nguoidung;
        }

        public string SoTaiKhoan1 { get => SoTaiKhoan; set => SoTaiKhoan = value; }
        public string TenNganHang1 { get => TenNganHang; set => TenNganHang = value; }
        public string Nguoidung1 { get => Nguoidung; set => Nguoidung = value; }
    }
}
