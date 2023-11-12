using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace form1
{
    public partial class frm_thongke : Form
    {
        public frm_thongke()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        void get_nam()
        {
            try
            {
                string query = "SELECT DISTINCT YEAR(ngaytaophieu) AS NamXuat FROM taophieudangky";//DISTINCT chỉ lấy 1 không lấy trùng
                DataSet ds = kn.selectData(query);
                cbx_nam.DataSource = ds.Tables[0];
                cbx_nam.DisplayMember = "Nam";
                cbx_nam.ValueMember = "NamXuat";
                cbx_nam.SelectedValue = "2023";// giá trị mặc định 2023
            }
            catch(Exception ex)
            {
                // dữ liệu đổ ra không có dữ liệu , bỏ đi không ảnh hưởng
            }
        }
        private void frm_thongke_Load(object sender, EventArgs e)
        {
            get_nam();
            thongke_sanpham();
          
        }
        void thongke()
        {
            try
            {
                int nam = Convert.ToInt32(cbx_nam.Text);

                chart_thongke.Series.Clear();// xóa những biểu đồ trước đó
                string query = $"select MONTH(ngaytaophieu) as thang , Sum(thanhtien) as tongtien from taophieudangky where year(ngaytaophieu) = {nam} group by MONTH(ngaytaophieu)";
                DataSet ds = kn.selectData(query);

                Series newcolum = new Series("tongtien_colum");
                newcolum.ChartType = SeriesChartType.Column;
                chart_thongke.Series.Add(newcolum);
                newcolum["PoitWidth"] = "0.2";

                Series newline = new Series("tongtien_line");
                newline.ChartType = SeriesChartType.Line;
                chart_thongke.Series.Add(newline);
                newline.BorderWidth = 2;

                foreach(DataRow row in ds.Tables[0].Rows)
                {
                    DataPoint dataPoint_colum = new DataPoint();
                    dataPoint_colum.SetValueXY(row["thang"], row["tongtien"]);
                    dataPoint_colum.LabelForeColor = Color.Red;
                    dataPoint_colum.Color = Color.Blue;
                    newcolum.Points.Add(dataPoint_colum);

                    DataPoint dataPoint_line = new DataPoint();
                    dataPoint_line.SetValueXY(row["thang"], row["tongtien"]);
                    dataPoint_line.Label = row["tongtien"].ToString();
                    dataPoint_line.LabelForeColor = Color.Red;
                    dataPoint_line.Color = Color.Blue;
                    newline.Points.Add(dataPoint_line);

                }

            }
            catch (Exception ex)
            {
                
            }
        }

        void thongke_sanpham()
        {
            try
            {
                chart_thongkeSanpham.Series.Clear();
                chart_thongkeSanpham.Titles.Add("Tour bán chạy");

                // Đặt loại biểu đồ là hình tròn
                Series series = new Series("SalesByProduct");
                series.ChartType = SeriesChartType.Pie;

                // Lấy dữ liệu từ CSDL của bạn
                string query = "SELECT MaTour, SUM(sovedat) AS TongSove FROM taophieudangky where Month(ngaytaophieu) = 9 GROUP BY Matour";
                DataSet ds = kn.selectData(query);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string productName = row["Matour"].ToString(); // Thay bằng cột chứa tên sản phẩm nếu có
                    int quantity = Convert.ToInt32(row["TongSove"]);

                    // Thêm dữ liệu vào series của biểu đồ
                    series.Points.AddXY(productName, quantity);
                }

                chart_thongkeSanpham.Series.Add(series);
            }
            catch(Exception ex)
            {
               
            }

        }

        private void cbx_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            thongke();
        }
    }
}
