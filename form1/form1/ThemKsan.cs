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
    public partial class ThemKsan : UserControl
    {
        public ThemKsan()
        {
            InitializeComponent();
        }

        Ketnoi kn = new Ketnoi();
        public void getdata()
       {
            string query = "select * from KhachSan";
            DataSet ds = kn.selectData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ThemKsan_Load(object sender, EventArgs e)
        {
            getdata();
        }
        public void Clear()
        {
            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;

            txtTen.Text = "";
            txtVitri.Text = "";

        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
            getdata();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Ketnoi.constr);
            try
            {
                conn.Open();
                string query = string.Format("insert into KhachSan (TenKhachSan, DiaChi)" +
                " values (N'{0}', N'{1}')", txtTen.Text, txtVitri.Text);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ScrollBars = ScrollBars.Both;
            int r = e.RowIndex;
            if (r >= 0)
            {
                btThem.Enabled = false;
                btSua.Enabled = true;
                btXoa.Enabled = true;

                txtMaks.Text = dataGridView1.Rows[r].Cells["MaKhachSan"].Value.ToString();
                txtTen.Text = dataGridView1.Rows[r].Cells["TenKhachSan"].Value.ToString();
                txtVitri.Text = dataGridView1.Rows[r].Cells["DiaChi"].Value.ToString();


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
                string query = string.Format("delete from KhachSan WHERE TenKhachSan like N'%{0}%'", txtTen.Text);
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

        private void btSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Ketnoi.constr);
            try
            {
                conn.Open();
                string query = string.Format("update KhachSan set TenKhachSan = N'{0}', DiaChi = N'{1}' where  MaKhachSan= N'{2}'",
                txtTen.Text, txtVitri.Text, txtMaks.Text);
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

        private void btSearch_Click(object sender, EventArgs e)
        {
            string query = string.Format(" select * from KhachSan where TenKhachSan like N'%{0}%'", txtTim.Text);
            DataSet ds = kn.selectData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
