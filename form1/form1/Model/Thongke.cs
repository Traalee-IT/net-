using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1.Model
{
    class Thongke
    {
        private int MaThongKe;
       private DateTime NgayThongKe;
        private int TongsoTour;
        private double Sotien;
      private int MaPhieu;

        public Thongke(int maThongKe, DateTime ngayThongKe, int tongsoTour, double sotien, int maPhieu)
        {
            MaThongKe = maThongKe;
            NgayThongKe = ngayThongKe;
            TongsoTour = tongsoTour;
            Sotien = sotien;
            MaPhieu = maPhieu;
        }

        public int MaThongKe1 { get => MaThongKe; set => MaThongKe = value; }
        public DateTime NgayThongKe1 { get => NgayThongKe; set => NgayThongKe = value; }
        public int TongsoTour1 { get => TongsoTour; set => TongsoTour = value; }
        public double Sotien1 { get => Sotien; set => Sotien = value; }
        public int MaPhieu1 { get => MaPhieu; set => MaPhieu = value; }
    }
}
