using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1
{
    public class Toudulich
    {
        private int MaTour;
        private String TenTour;
        private string anh;
        private String Mota;
        private float giaTien;
        private string diachi;
        private DateTime ngaykh;
        private DateTime ngaykt;
        private string diemdon;
        private string tenks;
        private string  tenphuongtien;
        private int sove;

        public Toudulich(int maTour, string tenTour, string anh, string mota, float giaTien, string diachi, DateTime ngaykh, DateTime ngaykt, string diemdon, string tenks, string tenphuongtien, int sove)
        {
            MaTour = maTour;
            TenTour = tenTour;
            this.anh = anh;
  
            Mota = mota;
            this.giaTien = giaTien;
            this.diachi = diachi;
           
            this.ngaykh = ngaykh;
            this.ngaykt = ngaykt;
            this.diemdon = diemdon;
            this.tenks = tenks;
            this.tenphuongtien = tenphuongtien;
            this.sove = sove;
        }

        public int MaTour1 { get => MaTour; set => MaTour = value; }
        public string TenTour1 { get => TenTour; set => TenTour = value; }
        public string Anh { get => anh; set => anh = value; }
        public string Mota1 { get => Mota; set => Mota = value; }
        public float GiaTien { get => giaTien; set => giaTien = value; }
        public string Diachi { get => diachi; set => diachi = value; }

        public DateTime Ngaykh { get => ngaykh; set => ngaykh = value; }
        public DateTime Ngaykt { get => ngaykt; set => ngaykt = value; }
        public string Diemdon { get => diemdon; set => diemdon = value; }
        public string Tenks { get => tenks; set => tenks = value; }
        public string Tenphuongtien { get => tenphuongtien; set => tenphuongtien = value; }
        public int Sove { get => sove; set => sove = value; }
    }

}
