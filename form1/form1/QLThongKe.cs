using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class QuanlyThongKe : Form
    {
        Ketnoi kn = new Ketnoi();
        public QuanlyThongKe()
        {
            InitializeComponent();
            thongke();
        }


        public void getdata()
        {
            string query = "select Row_number() over(ORDER BY MaThongKe) STT, * from ThongKe";
            DataSet ds = kn.selectData(query);
            dgvThongke.DataSource = ds.Tables[0];
        }

        private void thongke()
        {
            DateTime now = DateTime.Now;
            if (now.Day == 1)
            {
                int thang = now.Month; // Lấy tháng hiện tại
                int nam = now.Year;   // Lấy năm hiện tại
                                      // Nếu ngày hiện tại là ngày mùng 1, thực hiện chức năng thống kê
                ThucHienThongKe(thang, nam);
            }
            else if (now.Day != 1)
            {
                ThucHienThongKe(2023, 9);

                getdata();
            }
        }

        private void ThucHienThongKe(int nam, int month)
        {


            // Thực hiện chức năng thống kê ở đây
            // Lấy dữ liệu, tính toán tổng tiền, sau đó thêm vào bảng thống kê
            // ...
            double giatien = 0.0;

            Ketnoi kn = new Ketnoi();
            int thang = month - 1;
            int year = nam;
            int thangtk = 0;
            int namtk = 0;
            string query = "";
            string selectphieu = "";

            if (thang == 1)
            {
                namtk = year - 1;
                thangtk = 12;
                query = string.Format("SELECT SUM(ThanhTien) AS TongDoanhThu, count(MaPhieu) as TongSoPhieu FROM TaoPhieuDangKy WHERE DATEPART(yyyy, NgayTaoPhieu) = {0} AND DATEPART(mm, NgayTaoPhieu) = {1}", year - 1, 12);
                selectphieu = string.Format("SELECT SUM(sovedat) AS Tongsovedate FROM TaoPhieuDangKy WHERE DATEPART(yyyy, NgayTaoPhieu) ={0} AND DATEPART(mm, NgayTaoPhieu) = {1}", year - 1, 12);
            }
            else
            {
                selectphieu = string.Format("SELECT SUM(sovedat) AS Tongsovedate FROM TaoPhieuDangKy WHERE DATEPART(yyyy, NgayTaoPhieu) ={0} AND DATEPART(mm, NgayTaoPhieu) ={1}", nam, thang);
                namtk = nam;
                thangtk = thang;

                query = string.Format("SELECT SUM(ThanhTien) AS TongDoanhThu, count(MaPhieu) as TongSoPhieu FROM TaoPhieuDangKy WHERE DATEPART(yyyy, NgayTaoPhieu) = {0} AND DATEPART(mm, NgayTaoPhieu) = {1}", nam, thang);
            }

            DataSet sophieutao = kn.selectData(selectphieu);
            string tongsove = sophieutao.Tables[0].Rows[0]["Tongsovedate"].ToString();

            int TongSove = Convert.ToInt32(tongsove);
            DataSet ds = kn.selectData(query); Console.WriteLine(ds + "fshjsnkdsmfcvdsibgfd");
            string value = ds.Tables[0].Rows[0]["TongDoanhThu"].ToString();
            giatien = Double.Parse(value);
            DateTime now = DateTime.Now;

            int ngay = now.Day;     // Lấy ngày hiện tại
            int Thang = now.Month;  // Lấy tháng hiện tại
            int Nam = now.Year;
            string ngaythongke = "" + Nam + "-" + Thang + "-" + ngay;
            if (value != null)
            {
                string sql = string.Format("SELECT * FROM Thongke  WHERE DATEPART(yyyy, NgayThongKe) = {0} AND DATEPART(mm, NgayThongKe) ={1} insert into ThongKe(NgayThongKe, SoPhieuDangKy, TongSoTienDatTour, thangthongke)values('{0}', {1}, {2},'{3}')", ngaythongke, TongSove, giatien, namtk + " /" + thangtk);

                bool kt = kn.Thucthi(sql);
                if (kt)
                {
                    MessageBox.Show("Them thanh cong!");

                    getdata();
                }
                else
                    MessageBox.Show("Bạn đã thống kê tháng này rồi" + Nam + "/" + Thang);
            }
        }

        private void QuanlyThongKe_Load(object sender, EventArgs e)
        {

        }

        private void QuanlyThongKe_Load_1(object sender, EventArgs e)
        {

        }
    }
}
