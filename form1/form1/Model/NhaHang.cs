using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1.Model
{
    class NhaHang
    {
        private int MaKhachSan;
        private string TenKhachSan;
        private string DiaChi;
        private float Gia;

        public NhaHang(int maKhachSan, string tenKhachSan, string diaChi, float gia)
        {
            MaKhachSan = maKhachSan;
            TenKhachSan = tenKhachSan;
            DiaChi = diaChi;
            Gia = gia;
        }

        public int MaKhachSan1 { get => MaKhachSan; set => MaKhachSan = value; }
        public string TenKhachSan1 { get => TenKhachSan; set => TenKhachSan = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public float Gia1 { get => Gia; set => Gia = value; }
    }
}
