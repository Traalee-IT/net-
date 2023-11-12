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
    public partial class Themtour : UserControl
    {
        public int matour;
        public string pathImage = "";
        public Themtour()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        public void getdata()
        {
            string query = "Select Row_number() over(ORDER BY MaTour) STT, * FROM TourDL  ";
            DataSet ds = kn.selectData(query);
            dgvTour.DataSource = ds.Tables[0];
        }
        public void laymaPt()
        {
            string query = "select * from PhuongTien";
            DataSet ds = kn.selectData(query);
            cmbpt.DataSource = ds.Tables[0];
            cmbpt.DisplayMember = "MaPhuongTien";
            cmbpt.ValueMember = "MaPhuongTien";
        }
        public void laymaKhs()
        {
            string query = "select * from KhachSan";
            DataSet ds = kn.selectData(query);
            cmbks.DataSource = ds.Tables[0];
            cmbks.DisplayMember = "MaKhachSan";
            cmbks.ValueMember = "MaKhachSan";
        }
        public void laymadiadiem()
        {
            string query = "select * from DiaDiem";
            DataSet ds = kn.selectData(query);
            cmbmadd.DataSource = ds.Tables[0];
            cmbmadd.DisplayMember = "MaDiaDiem";
            cmbmadd.ValueMember = "MaDiaDiem";
        }
        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedImagePath = openFileDialog1.FileName;
                pathImage = selectedImagePath;
                pictureBox1.Image = Image.FromFile(selectedImagePath);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;

        }

        private void Themtour_Load(object sender, EventArgs e)
        {
            getdata();
            laymaKhs();
            laymaPt();
            laymadiadiem();
        }
        public void clear()
        {
            txtTen.Text = "";
            txtmota.Text = "";
            cmbmadd.SelectedItem = "";
            txtgiatien.Text = "";
            ngaykh.Value = DateTime.Now;
            ngaykt.Value = DateTime.Now;
            txtDiemdon.Text = "";
            cmbpt.SelectedItem = "";
            cmbks.SelectedItem = "";
            numericUpDown2.Value = 0;
            pictureBox1.Image = null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (pathImage + "" == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin  ", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {

                string sql = string.Format("insert into TourDL(Anh,TenTour,Mota,MaDiaDiem,GiaTien,NgayKhoiHanh,NgayKetThuc,DiemDon,MaPhuongTien,MaKhachSan,SoVe)"
                + " Values('{0}', N'{1}', N'{2}','{3}','{4}','{5}','{6}', N'{7}','{8}','{9}','{10}')", pathImage + "", txtTen.Text, txtmota.Text, cmbmadd.SelectedValue,
                txtgiatien.Text, ngaykh.Value, ngaykt.Value, txtDiemdon.Text, cmbpt.SelectedValue, cmbks.SelectedValue, numericUpDown2.Value);
                bool kt = kn.Thucthi(sql);
                if (kt)
                {
                    MessageBox.Show("Them thanh cong!");
                    getdata();
                    btclear.PerformClick();
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
            int r = e.RowIndex;
            if (r >= 0)
            {
                Console.WriteLine(Image.FromFile(dgvTour.Rows[r].Cells["anh"].Value.ToString()));
                pictureBox1.Image = Image.FromFile(dgvTour.Rows[r].Cells["anh"].Value.ToString());
                txtTen.Text = dgvTour.Rows[r].Cells["TenTour"].Value.ToString();
                txtmota.Text = dgvTour.Rows[r].Cells["Mota"].Value.ToString(); ;
                cmbmadd.SelectedValue = dgvTour.Rows[r].Cells["MaDiaDiem"].Value.ToString();
                txtgiatien.Text = dgvTour.Rows[r].Cells["GiaTien"].Value.ToString();
                ngaykh.Text = dgvTour.Rows[r].Cells["NgayKhoiHanh"].Value.ToString();
                ngaykt.Text = dgvTour.Rows[r].Cells["NgayKetThuc"].Value.ToString();
                txtDiemdon.Text = dgvTour.Rows[r].Cells["DiemDon"].Value.ToString();
                matour = Convert.ToInt32(dgvTour.Rows[r].Cells["MaTour"].Value.ToString());
                cmbpt.SelectedValue = dgvTour.Rows[r].Cells["MaPhuongTien"].Value.ToString();
                cmbks.SelectedValue = dgvTour.Rows[r].Cells["MaKhachSan"].Value.ToString();
                string stringValue = dgvTour.Rows[r].Cells["SoVe"].Value.ToString();
                numericUpDown2.Value = int.Parse(stringValue);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Ketnoi.constr);
            try
            {
                conn.Open();
                string sql = string.Format("update TourDL" +
                " set Anh='{0}',TenTour= N'{1}',Mota= N'{2}',MaDiaDiem='{3}'," +
                " GiaTien='{4}',NgayKhoiHanh='{5}',NgayKetThuc='{6}',DiemDon= N'{7}'," +
                "MaPhuongTien='{8}',MaKhachSan='{9}',SoVe='{10}'"
                + " where MaTour='{11}'",pathImage , txtTen.Text, txtmota.Text, cmbmadd.SelectedValue,
                txtgiatien.Text, ngaykh.Value, ngaykt.Value, txtDiemdon.Text, cmbpt.SelectedValue, cmbks.SelectedValue, numericUpDown2.Value, matour);
                bool kt = kn.Thucthi(sql);
                if (kt)
                {
                    MessageBox.Show("Suathanh cong!");
                    getdata();
                    btclear.PerformClick();
                }
                else
                    MessageBox.Show("Sua that bai");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi :" + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = string.Format("Delete from TourDL"
                   + " where MaTour='{0}'", matour);

            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool kt = kn.Thucthi(sql);
                if (kt == true)
                {
                    MessageBox.Show("Xóa thành công!");
                    getdata();
                    btclear.PerformClick();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                }
            }
        }

        private void cmbpt_Click(object sender, EventArgs e)
        {

            string query = string.Format("select TenPhuongTien from PhuongTien where MaPhuongTien='{0}'", cmbpt.SelectedValue);
            DataSet ds = kn.selectData(query);
            txtphuongtien.Text = ds.Tables[0].Rows[0]["TenPhuongTien"].ToString();
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            clear();
            getdata();
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(" select * from TourDL  where TenTour like N'%{0}%'", txtTen.Text);
            DataSet ds = kn.selectData(query);
            dgvTour.DataSource = ds.Tables[0];

        }

        private void cmbks_Click(object sender, EventArgs e)
        {
            string query = string.Format("select Tenkhachsan from khachsan where makhachsan='{0}'", cmbks.SelectedValue);
            DataSet ds = kn.selectData(query);
            txttenkhs.Text = ds.Tables[0].Rows[0]["Tenkhachsan"].ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ngaykh_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

