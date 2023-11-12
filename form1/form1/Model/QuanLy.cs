using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form1.Model
{
    class QuanLy:User
    {
        public QuanLy(string idUser, string hoten, string gioiTinh, int tuoi, string phone, string queQuan, DateTime ngaySinh, string email)
                      : base(idUser, hoten, gioiTinh, tuoi, phone, queQuan, ngaySinh, email)
        {

        }
    }
}
