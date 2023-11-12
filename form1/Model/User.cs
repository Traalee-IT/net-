using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelTour.Model
{
    class User
    {
        private String idUser;
        private String Hoten;
        private String GioiTinh;
        private int Tuoi;
        private String Phone;
        private String QueQuan;
        private DateTime ngaySinh;
        private String Email;
    

        public User()
        {
        }

        public User(string idUser, string hoten, string gioiTinh, int tuoi, string phone, string queQuan, DateTime ngaySinh, string email)
        {
            this.idUser = idUser;
            Hoten = hoten;
            GioiTinh = gioiTinh;
            Tuoi = tuoi;
            Phone = phone;
            QueQuan = queQuan;
            this.ngaySinh = ngaySinh;
            Email = email;
        }

        public string IdUser { get => idUser; set => idUser = value; }
        public string Hoten1 { get => Hoten; set => Hoten = value; }
        public string GioiTinh1 { get => GioiTinh; set => GioiTinh = value; }
        public int Tuoi1 { get => Tuoi; set => Tuoi = value; }
        public string Phone1 { get => Phone; set => Phone = value; }
        public string QueQuan1 { get => QueQuan; set => QueQuan = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string Email1 { get => Email; set => Email = value; }
      
      
    }
}
