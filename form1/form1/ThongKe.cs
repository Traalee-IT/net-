using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace form1
{
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
            thongke();
        }
        Ketnoi kn = new Ketnoi();
        public void getdata()
        {
            string query = "select Row_number() over(ORDER BY MaThongKe) STT, * from ThongKe";
            DataSet ds = kn.selectData(query);
            dgvThongke.DataSource = ds.Tables[0];
        }

        private void thongke() { 
            Console.WriteLine("ddi did may");
              ThucHienThongKe(1,2023);
          /*  while (true)
            {
                // Lấy ngày hiện tại
                DateTime now = DateTime.Now;*/

                // Kiểm tra xem ngày hiện tại có phải là ngày mùng 1 không
               /* if (now.Day == 1)
                {

                    int thang = now.Month; // Lấy tháng hiện tại
                    int nam = now.Year;   // Lấy năm hiện tại
                    // Nếu ngày hiện tại là ngày mùng 1, thực hiện chức năng thống kê
                    ThucHienThongKe(thang, nam);
                }

                // Đợi một khoảng thời gian trước khi kiểm tra lại (ví dụ: 24 giờ)
                Thread.Sleep(TimeSpan.FromHours(24));*/
           // }
        }

        private void ThucHienThongKe(int thang, int nam)
        {
            // Thực hiện chức năng thống kê ở đây
            // Lấy dữ liệu, tính toán tổng tiền, sau đó thêm vào bảng thống kê
            // ...
            double giatien = 0.0;
            int TongSoPhieu = 0;
            Ketnoi kn = new Ketnoi();
            string query = string.Format("SELECT  SUM(ThanhTien) AS TongDoanhThu, count(MaPhieu) as TongSoPhieu FROM TaoPhieuDangKy WHERE DATEPART(yyyy, NgayTaoPhieu) = {0} AND DATEPART(mm, NgayTaoPhieu) = {1}", nam,thang);
            DataSet ds = kn.selectData(query);

            string value = ds.Tables[0].Rows[0]["TongDoanhThu"].ToString();
            string value2 = ds.Tables[0].Rows[0]["TongSoPhieu"].ToString();
        
           giatien = Convert.ToDouble(value);
            TongSoPhieu = Convert.ToInt32(value2);
            Console.WriteLine(giatien + "ngyf dhbfhudbhbdshfbhusdbfhudbfhubsdhubfhsdbfhdsbfhus");
            DateTime now = DateTime.Now;
            Console.WriteLine(TongSoPhieu + "ngyf dhbfhudbhbdshfbhusdbfhudbfhubsdhubfhsdbfhdsbfhus");
            int ngay = now.Day;     // Lấy ngày hiện tại
            int Thang = now.Month;  // Lấy tháng hiện tại
            int Nam = now.Year;
            string ngaythongke = "" + Nam + "-" + Thang + "-" + ngay + "-";
            if (value != null)
            {

                string sql = string.Format("insert into ThongKe(NgayThongKe , SoPhieuDangKy, TongSoTienDatTour)" +
                " values ('{0}', '{1}', '{2}'", ngaythongke, TongSoPhieu, giatien);
                bool kt = kn.Thucthi(sql);
                if (kt)
                {
                    MessageBox.Show("Them thanh cong!");

                    getdata();
                }
                else
                    MessageBox.Show("Them that bai");
            }
        }
    }
}
  

    
        
     

