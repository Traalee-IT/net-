using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTour.Model
{
    class TourDulich
    {
        private int MaTour;
        private String TenTour;
        private DateTime Ngaybd;
        private DateTime Ngaykt;
        private String tenPhuongTien;
        private String Ghichu;
        private float giaTien;
        private String diemKhoihanh;
        private String DiemDen;
        private string anh;
        private int maDiaDiem;
        private int songuoiThamgia;
        private string maphuongtien;

        public TourDulich(int maTour, string tenTour, string tenTour1, DateTime ngaybd, DateTime ngaykt, string tenPhuongTien, string ghichu, float giaTien, string diemKhoihanh, string diemDen)
        {
            MaTour = maTour;
            TenTour = tenTour;
            Ngaybd = ngaybd;
            Ngaykt = ngaykt;
            this.tenPhuongTien = tenPhuongTien;
            Ghichu = ghichu;
            this.giaTien = giaTien;
            this.diemKhoihanh = diemKhoihanh;
            DiemDen = diemDen;
        }

        public TourDulich(int maTour, string anh, string tenTour, DateTime ngaybd, DateTime ngaykt, int maDiaDiem, string ghichu, float giaTien, int songuoiThamgia, string maphuongtien)
        {
            MaTour = maTour;
            this.anh = anh;
            TenTour = tenTour;
            Ngaybd = ngaybd;
            Ngaykt = ngaykt;
            this.maDiaDiem = maDiaDiem;
            Ghichu = ghichu;
            this.giaTien = giaTien;
            this.songuoiThamgia = songuoiThamgia;
            this.maphuongtien = maphuongtien;
        }

        public void ThongTinTour()
        {

        }
      
    }
}
