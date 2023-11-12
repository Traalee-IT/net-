using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1.Model
{
    class diaDiem
    {
        private int MaKhachSan;
        private string TenKhachSan;
        private string DiaChi;
        private string Gia;

        public diaDiem(int maKhachSan, string tenKhachSan, string diaChi, string gia)
        {
            MaKhachSan = maKhachSan;
            TenKhachSan = tenKhachSan;
            DiaChi = diaChi;
            Gia = gia;
        }

        public override bool Equals(object obj)
        {
            return obj is diaDiem diem &&
                   MaKhachSan == diem.MaKhachSan &&
                   TenKhachSan == diem.TenKhachSan &&
                   DiaChi == diem.DiaChi &&
                   Gia == diem.Gia;
        }

        public override int GetHashCode()
        {
            int hashCode = -1827010684;
            hashCode = hashCode * -1521134295 + MaKhachSan.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TenKhachSan);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DiaChi);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Gia);
            return hashCode;
        }
    }
}
