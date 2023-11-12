using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using form1.Model;
namespace form1
{
    class Ketnoi
    {
        public static string  constr = @"Data Source=DESKTOP-UCK7P15\SQLEXPRESS;Initial Catalog=DatTour;Integrated Security=True";
        SqlConnection conn;
        public Ketnoi()
        {
            conn = new SqlConnection(constr);
        }
        public DataSet selectData(string truyvan)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(truyvan, conn);
                da.Fill(ds);
                return ds;
            }
            catch(Exception EX)
            {
                Console.WriteLine("loi" + EX.Message);
            }return null;
        }
        public bool Thucthi(string truyvan)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand(truyvan, conn);
            int result = cmd.ExecuteNonQuery();
            conn.Close();
            return result > 0;
        }
        public List<Toudulich> SelectAll()
        {
            List<Toudulich> danhsach = new List<Toudulich>();

            try
            {

                {
                    conn.Open();
                    string SelectTour = "SELECT * FROM TourDL,Diadiem,KhachSan,PhuongTien where Diadiem.MaDiaDiem = TourDL.MaDiaDiem and TourDL.MaKhachSan = KhachSan.MaKhachSan and TourDL.MaPhuongTien = PhuongTien.MaPhuongTien";
                           

                    SqlCommand command = new SqlCommand(SelectTour, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    {
                        while (reader.Read())
                        {

                            int MaTour = Convert.ToInt32(reader["MaTour"]);
                            string anh = reader["Anh"].ToString();
                            string TenTour = reader["TenTour"].ToString();
                            DateTime ngaykh = DateTime.Parse(reader["NgayKhoiHanh"].ToString());
                            DateTime ngaykt = DateTime.Parse(reader["NgayKetThuc"].ToString());
                            string diemdon = reader["DiemDon"].ToString();
                            string Ghichu = reader["Mota"].ToString();
                            float GiaTien = Convert.ToSingle(reader["GiaTien"]);
                            string Diachi= reader["TenDiaDiem"].ToString();
                            string tenks = reader["TenKhachSan"].ToString();
                            string tenphuongtien = reader["TenPhuongTien"].ToString();
                            int sove = Convert.ToInt32(reader["SoVe"]);
                            danhsach.Add( new Toudulich(MaTour, TenTour,  anh, Ghichu, GiaTien,  Diachi, ngaykh, ngaykt, diemdon,  tenks,  tenphuongtien, sove));
                        }
                         
                    } 
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return danhsach;
        }
    }
}
