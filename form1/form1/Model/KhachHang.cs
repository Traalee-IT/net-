using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1.Model
{
    class KhachHang
    {
        private int makh;
        private string tenkh;
        private string gioitinh;
        private string namsinh;
        private string sdt;
        private string quequan;

        public KhachHang(int makh, string tenkh, string gioitinh, string namsinh, string sdt, string quequan)
        {
            this.makh = makh;
            this.tenkh = tenkh;
            this.gioitinh = gioitinh;
            this.namsinh = namsinh;
            this.sdt = sdt;
            this.quequan = quequan;
        }

        public int Makh { get => makh; set => makh = value; }
        public string Tenkh { get => tenkh; set => tenkh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Namsinh { get => namsinh; set => namsinh = value; }
        public string Sdt { get => sdt; set => sdt = value; }
        public string Quequan { get => quequan; set => quequan = value; }
    }
}
