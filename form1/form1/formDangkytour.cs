using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form1
{
    public partial class formDangkytour : Form
    {

        Ketnoi ketnoi = new Ketnoi();
        Toudulich tour;
        public double thanhtien = 0;
        public int soveconlai = 0;
        public formDangkytour(Toudulich tour)
        {

            InitializeComponent();
            this.tour = tour;
            txtmatour.Text = tour.MaTour1.ToString();
            txttentour.Text = tour.TenTour1.ToString();
            txtdongia.Text = tour.GiaTien.ToString();
            txtsove.Text = tour.Sove.ToString();
            numer_sovedat.Maximum = int.Parse(tour.Sove.ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double dongia;
            if (double.TryParse(txtdongia.Text, out dongia))
            {
                int sovedat;

                Console.WriteLine(numer_sovedat.Value);
                sovedat = (int)numer_sovedat.Value;

                Console.WriteLine(dongia);
                double thanhtien = dongia * sovedat;
                txtthanhtien.Text = thanhtien.ToString() + ".000";
            }
            else
            {

            }
        }
        public void laymanhanvien()
        {
            string query = "select MaNhanvien from NhanVien ";
            DataSet ds = ketnoi.selectData(query);
            cbbmanv.DataSource = ds.Tables[0];
            cbbmanv.DisplayMember = "MaNhanvien";
            cbbmanv.ValueMember = "MaNhanvien";
        }
        private void txtthanhtien_TextChanged(object sender, EventArgs e)
        {

        }
        private void btndnagkys_Click(object sender, EventArgs e)
        {
            string soDienThoaiTimKiem = txtsdt.Text;
            soveconlai = int.Parse(txtsove.Text) - (int)numer_sovedat.Value;
            if (soDienThoaiTimKiem.Length == 10)
            {
                // Kết nối cơ sở dữ liệu và thực hiện truy vấn
                string selectPhone = String.Format("select * from KhachHang where SDTKH='{0}'", soDienThoaiTimKiem);
                DataSet ds = ketnoi.selectData(selectPhone);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    try
                    {
                        string ThemDk = string.Format("insert into taophieudangky" +
                                                        "(sdtkh, thanhtien, matour, ngaytaophieu, manhanvien, sovedat)" +
                                                        "values('{0}','{1}','{2}','{3}','{4}','{5}')", 
                                                        txtsdt.Text, 
                                                        txtthanhtien.Text, 
                                                        txtmatour.Text, 
                                                        datengaytaophieu.Value.ToString("yyyy-MM-dd"), 
                                                        cbbmanv.SelectedValue,
                                                        numer_sovedat.Value);
                        bool dk = ketnoi.Thucthi(ThemDk);
                        string updatve = string.Format("update TourDL set sove = {0} where Matour={1} ", soveconlai, tour.MaTour1.ToString());
                        bool update = ketnoi.Thucthi(updatve);
                        if (update)
                        {
                            MessageBox.Show("Them thanh cong!");
                        }
                        else
                        {
                            MessageBox.Show("Them thât bại" +
                                "!");
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Loi ket noi :" + ex.Message);
                    }

                }
                else
                {
                    if (txtten.Text == "" || txtthanhtien.Text == "")
                    {
                        MessageBox.Show("vui lòng nhập lại thông tin");
                    }
                    else
                    {
                        Console.WriteLine("vào 1");
                        try
                        {

                            string query = string.Format("insert into KhachHang(HoTen, GioiTinh, SDTKH, QueQuan, NgaySinh)values(N'{0}',N'{1}','{2}',N'{3}','{4}')", txtten.Text, cbxgioitinh.SelectedItem, txtsdt.Text + "", txtquequan.Text, dateTimeNgay.Value.ToString("yyyy-MM-dd"));
                            bool kt = ketnoi.Thucthi(query);
                            Console.WriteLine("vào 4");
                            if (kt)
                            {
                                Console.WriteLine("vào 2");
                                string ThemDk = string.Format("insert into taophieudangky(sdtkh, thanhtien, matour, ngaytaophieu, manhanvien, sovedat)values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", txtsdt.Text, txtthanhtien.Text, txtmatour.Text, datengaytaophieu.Value.ToString("yyyy-MM-dd"), cbbmanv.SelectedValue, numer_sovedat.Value);
                                bool dk = ketnoi.Thucthi(ThemDk);
                                Console.WriteLine(kt && dk);
                                string updatve = string.Format("update TourDL set sove = {0} where Matour={1} ", soveconlai, tour.MaTour1.ToString());
                                bool update = ketnoi.Thucthi(updatve);
                                if (update)
                                {
                                    Console.WriteLine("vào 5");
                                    MessageBox.Show("Them thanh cong!");
                                }
                                else
                                {
                                    MessageBox.Show("Them thât bại" +
                                        "!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("vào 6");
                                MessageBox.Show("Them that bai");
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Loi ket noi :" + ex.Message);
                        }
                    }
                }

            }
        }

        private void formDangkytour_Load(object sender, EventArgs e)
        {
            laymanhanvien();
        }

        private void txtsdt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string soDienThoaiTimKiem = txtsdt.Text;
                if (soDienThoaiTimKiem.Length == 10)
                {

                    // Kết nối cơ sở dữ liệu và thực hiện truy vấn
                    string query = String.Format("select * from KhachHang where SDTKH='{0}'", soDienThoaiTimKiem);
                    DataSet ds = ketnoi.selectData(query);
                    txtten.Text = ds.Tables[0].Rows[0]["HoTen"].ToString();
                    string gioitinh = ds.Tables[0].Rows[0]["GioiTinh"].ToString();
                    cbxgioitinh.SelectedItem = gioitinh;
                    Console.WriteLine(gioitinh);
                    dateTimeNgay.Text = ds.Tables[0].Rows[0]["Ngaysinh"].ToString();
                    txtquequan.Text = ds.Tables[0].Rows[0]["Quequan"].ToString();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("lloi :" + ex);
            }
        }
    }
}