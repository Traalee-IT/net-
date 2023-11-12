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
    public partial class QLnhanvien : Form
    {
       
        public QLnhanvien()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        public void getdata()
        {
            string query = "select * from NhanVien  ";
            DataSet ds = kn.selectData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void QLnhanvien_Load(object sender, EventArgs e)
        {
            getdata();
        }
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            new Button();
        }
        public void Clear()
        {

            btThem.Enabled = true;
            btSua.Enabled = false;
            btXoa.Enabled = false;

            txtManhanvien.Text = "";
            txtHoten.Text = "";
            txtQuequan.Text = "";
            txtSDT.Text = "";
            txtEmail.Text = "";
        }

        private void bttclear_Click(object sender, EventArgs e)
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
                string query = string.Format("insert into NhanVien(HoTen, GioiTinh, SDT, QueQuan, NgaySinh, Email)" +
                " values (N'{0}', N'{1}', N'{2}' , N'{3}', '{4}' , N'{5}' )",
                txtHoten.Text, cbGioitinh.SelectedValue, txtSDT.Text, txtQuequan.Text, dateTimeNgaysinh.Value.ToString("yyyy/MM/dd"),
                txtEmail.Text);
                bool kt = kn.Thucthi(query);
                if (kt)
                {
                    MessageBox.Show("Them thanh cong!");
                    getdata();
                    bttclear.PerformClick();
                }
                else
                    MessageBox.Show("Them that bai");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi :" + ex.Message);
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Ketnoi.constr);
            try
            {
                conn.Open();
                string query = string.Format("update NhanVien set HoTen = '{0}', Gioitinh = '{1}', SDT = '{2}' , QueQuan = '{3}' , NgaySinh = '{4}' , Email = '{5}' where MaNhanVien = N'{6}'",
                txtHoten.Text, cbGioitinh.SelectedValue, txtSDT.Text, txtQuequan.Text, dateTimeNgaysinh.Value.ToString("yyyy/MM/dd"),
                txtEmail.Text, txtManhanvien.Text);
                bool kt = kn.Thucthi(query);
                if (kt)
                {
                    MessageBox.Show("Sua thanh cong!");
                    getdata();
                    bttclear.PerformClick();
                }
                else
                    MessageBox.Show("Sua that bai");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi :" + ex.Message);
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
                string query = string.Format("delete from NhanVien WHERE MaNhanVien = {0}", txtManhanvien.Text);
                bool kt = kn.Thucthi(query);
                if (kt)
                {
                    MessageBox.Show("Xóa thành công ");
                    getdata();
                    bttclear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = string.Format(" select * from NhanVien where HoTen like N'%{0}%'", txtTim.Text);
            DataSet ds = kn.selectData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ScrollBars = ScrollBars.Both;
            int r = e.RowIndex;
            if (r >= 0)
            {


                btThem.Enabled = false;
                btSua.Enabled = true;
                btXoa.Enabled = true;

                txtManhanvien.Text = dataGridView1.Rows[r].Cells["MaNhanVien"].Value.ToString();
                txtHoten.Text = dataGridView1.Rows[r].Cells["HoTen"].Value.ToString();
                cbGioitinh.SelectedValue = dataGridView1.Rows[r].Cells["GioiTinh"].Value.ToString();
                txtSDT.Text = dataGridView1.Rows[r].Cells["SDT"].Value.ToString();
                txtQuequan.Text = dataGridView1.Rows[r].Cells["QueQuan"].Value.ToString();
                dateTimeNgaysinh.Text = dataGridView1.Rows[r].Cells["NgaySinh"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[r].Cells["Email"].Value.ToString();
            }
        }
    }
}
