using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1.Model
{
    class TaophieTour
    {
        private int MaPhieu;
        private int MaTour;
        private DateTime NgayTaoPhieu;
        private int MaPhuongTien;
        private int MaKhachSan;
        private string HoTen;
        private string gioitinh;
        private string SDT;
        private string QueQuan;
        private DateTime NgaySinh;
        private string tenKs;
        private string diachiKS;
        private float giaKs;
       private double ThanhTien;
        private DateTime NgayBd;
        private DateTime NgayKt;

        public TaophieTour(int maPhieu, int maTour, DateTime ngayTaoPhieu, int maPhuongTien, int maKhachSan, string hoTen, string gioitinh, string sDT, string queQuan, DateTime ngaySinh, string tenKs, string diachiKS, float giaKs, double thanhTien, DateTime ngayBd, DateTime ngayKt)
        {
            MaPhieu = maPhieu;
            MaTour = maTour;
            NgayTaoPhieu = ngayTaoPhieu;
            MaPhuongTien = maPhuongTien;
            MaKhachSan = maKhachSan;
            HoTen = hoTen;
            this.gioitinh = gioitinh;
            SDT = sDT;
            QueQuan = queQuan;
            NgaySinh = ngaySinh;
            this.tenKs = tenKs;
            this.diachiKS = diachiKS;
            this.giaKs = giaKs;
            ThanhTien = thanhTien;
            NgayBd = ngayBd;
            NgayKt = ngayKt;
        }

        public int MaPhieu1 { get => MaPhieu; set => MaPhieu = value; }
        public int MaTour1 { get => MaTour; set => MaTour = value; }
        public DateTime NgayTaoPhieu1 { get => NgayTaoPhieu; set => NgayTaoPhieu = value; }
        public int MaPhuongTien1 { get => MaPhuongTien; set => MaPhuongTien = value; }
        public int MaKhachSan1 { get => MaKhachSan; set => MaKhachSan = value; }
        public string HoTen1 { get => HoTen; set => HoTen = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string SDT1 { get => SDT; set => SDT = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        public DateTime NgaySinh1 { get => NgaySinh; set => NgaySinh = value; }
        public string TenKs { get => tenKs; set => tenKs = value; }
        public string DiachiKS { get => diachiKS; set => diachiKS = value; }
        public float GiaKs { get => giaKs; set => giaKs = value; }
        public double ThanhTien1 { get => ThanhTien; set => ThanhTien = value; }
        public DateTime NgayBd1 { get => NgayBd; set => NgayBd = value; }
        public DateTime NgayKt1 { get => NgayKt; set => NgayKt = value; }
    }
}
