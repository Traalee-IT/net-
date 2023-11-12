using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace form1
{
    public partial class ThemKhachHang : UserControl
    {
        public ThemKhachHang()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();
        public void getdata()
        {
            string query = "select * from KhachHang";
            DataSet ds = kn.selectData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ThemKhachHang_Load(object sender, EventArgs e)
        {
            getdata();
        }
        public void Clear()
        {
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;

            txtTen.Text = "";
            txtSDT.Text = "";
            txtDiachi.Text = "";
         
        }

       
        private void btSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Ketnoi.constr);
            try
            {
                conn.Open();
                string query = string.Format("update KhachHang set HoTen = N'{0}', Gioitinh = N'{1}', QueQuan = N'{2}' , NgaySinh = N'{3}' , Email = N'{4}'  where  SDTKH = N'{5}'",
                txtTen.Text, cbGioitinh.Text, txtSDT.Text, dateTimeNgay.Value.ToString("yyyy/MM/dd"), txtEmail.Text, txtSDT.Text);
                bool kt = kn.Thucthi(query);
                if (kt)
                {
                    MessageBox.Show("Sua thanh cong!");
                    getdata();
                    btClear.PerformClick();
                }
                else
                    MessageBox.Show("Sua that bai");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi :" + ex.Message);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
            getdata();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ScrollBars = ScrollBars.Both;
            int r = e.RowIndex;
            if (r >= 0)
            {
                btThem.Enabled = true;
                btSua.Enabled = false;
                btXoa.Enabled = false;

                txtSDT.Text = dataGridView1.Rows[r].Cells["SDTKH"].Value.ToString();
                txtTen.Text = dataGridView1.Rows[r].Cells["HoTen"].Value.ToString();
                cbGioitinh.Text = dataGridView1.Rows[r].Cells["GioiTinh"].Value.ToString();
                txtDiachi.Text = dataGridView1.Rows[r].Cells["QueQuan"].Value.ToString();
                dateTimeNgay.Text = dataGridView1.Rows[r].Cells["NgaySinh"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[r].Cells["Email"].Value.ToString();
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Ban co muon xoa khong ?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(Ketnoi.constr);
                conn.Open();
                string query = string.Format("delete from KhachHang WHERE SDTKH = {0}", txtSDT.Text);
                bool kt = kn.Thucthi(query);
                if (kt)
                {
                    MessageBox.Show("Xóa thành công ");
                    getdata();
                    btClear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }

            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Ketnoi.constr);
            try
            {
                conn.Open();
                string query = string.Format("insert into KhachHang(SDTKH, HoTen, GioiTinh, QueQuan, NgaySinh, Email)" +
                " values (N'{0}', N'{1}', N'{2}' , N'{3}', '{4}' , N'{5}' )",
                txtSDT.Text, txtTen.Text, cbGioitinh.Text, txtDiachi.Text, dateTimeNgay.Value.ToString("yyyy/MM/dd"),
                txtEmail.Text);
                bool kt = kn.Thucthi(query);
                if (kt)
                {
                    MessageBox.Show("Them thanh cong!");
                    getdata();
                    btClear.PerformClick();
                }
                else
                    MessageBox.Show("Them that bai");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi :" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = string.Format(" select * from KhachHang where HoTen like N'%{0}%'", txtSearch.Text);
            DataSet ds = kn.selectData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
