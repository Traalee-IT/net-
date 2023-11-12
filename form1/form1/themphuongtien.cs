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
    public partial class themphuongtien : UserControl
    {

        Ketnoi ketnoi = new Ketnoi();
        public themphuongtien()
        {
            InitializeComponent();
            getdata();
        }
        public void clean()
        {
            txtmapt.Text = "";
            txtloaipt.Text = "";
        }
        private void themThongTinU1_Load(object sender, EventArgs e)
        {
            clean();
        }

        private void btnclean_Click(object sender, EventArgs e)
        {

        }
        public void getdata()
        {
            string query = "Select Row_number() over(ORDER BY Maphuongtien) STT, * FROM phuongtien";
            DataSet ds = ketnoi.selectData(query);
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into phuongtien(maphuongtien,tenphuongtien)values(N'{0}',N'{1}')", txtmapt.Text, txtloaipt.Text);
            bool kt = ketnoi.Thucthi(sql);
            if (kt)
            {
                MessageBox.Show("Them thanh cong!");
                getdata();
                clean();
            }
            else
                MessageBox.Show("Them that bai");

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Ban co muon xoa khong !", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                Console.WriteLine(txtmapt.Text);
                string query = string.Format("delete from phuongtien WHERE Maphuongtien='{0}'",txtmapt.Text);
                bool kt = ketnoi.Thucthi(query);
                if (kt)
                {
                    MessageBox.Show("Xóa thành công ");
                    getdata();

                }
                else
                {
                    MessageBox.Show("Thất bại");
                }

                clean();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int r = e.RowIndex;
            if (r >= 0)
            {
                txtmapt.Text= dataGridView1.Rows[r].Cells["maphuongtien"].Value.ToString();
                txtloaipt.Text = dataGridView1.Rows[r].Cells["tenphuongtien"].Value.ToString();
               

            }
            bntthem.Enabled = false;
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            txtmapt.Enabled = false;
      
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            try
            {

                string query = string.Format("update phuongtien set tenphuongtien = '{0}'  where maphuongtien={1} ",
                txtloaipt.Text, txtmapt.Text);

                bool kt = ketnoi.Thucthi(query);
                if (kt)
                {
                    MessageBox.Show("Sua thanh cong!");
                    getdata();
                    clean();
                }
                else
                    MessageBox.Show("Sua that bai");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi ket noi :" + ex.Message);
            }
        }

        private void btntkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(" select * from phuongtien where tenphuongtien like N'%{0}%'", txtloaipt.Text);
            DataSet ds = ketnoi.selectData(query);
            dataGridView1.DataSource = ds.Tables[0];
            txttiemkiem.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
