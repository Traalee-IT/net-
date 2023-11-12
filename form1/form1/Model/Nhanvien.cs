using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1.Model
{
    class Nhanvien:User
    {
        private int matour;
        private int maphieu;

       

        public Nhanvien(string idUser, string hoten, string gioiTinh, int tuoi, string phone, string queQuan, DateTime ngaySinh, string email,int matour,int maphieu)
                  : base(idUser, hoten, gioiTinh, tuoi, phone, queQuan, ngaySinh, email)
        {
            this.maphieu = maphieu;
            this.matour = matour;
        }

        public int Matour { get => matour; set => matour = value; }
        public int Maphieu { get => maphieu; set => maphieu = value; }
    }
}
