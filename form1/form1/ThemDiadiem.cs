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
    public partial class ThemDiadiem : UserControl
    {
        Ketnoi ketnoi = new Ketnoi();
        string iddd = "";
        public ThemDiadiem()
        {
            InitializeComponent();
            getdata();
        }

        private void ThemDiadiem_Load(object sender, EventArgs e)
        {

        }
        public void clean()
        {
            txtdiachi.Text = "";
            txtdiadiem.Text = "";
        }
        public void getdata()
        {
            string query = "Select Row_number() over(ORDER BY Madiadiem) STT, * FROM diadiem";
            DataSet ds = ketnoi.selectData(query);
            dvgdiadiem.DataSource = ds.Tables[0];
            dvgdiadiem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string sql = string.Format("insert into DiaDiem(tendiadiem,diachi)values(N'{0}',N'{1}')",txtdiadiem.Text,txtdiachi.Text);
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

        private void dvgdiadiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            if (r >= 0)
            {
                iddd = dvgdiadiem.Rows[r].Cells["Madiadiem"].Value.ToString();
                txtdiadiem.Text = dvgdiadiem.Rows[r].Cells["Tendiadiem"].Value.ToString();
                txtdiachi.Text = dvgdiadiem.Rows[r].Cells["Diachi"].Value.ToString();
                
            }
            bntthem.Enabled = false;
            btnsua.Enabled = true;
            bntxoa.Enabled = true;
            
        }

        private void bntxoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Ban co muon xoa khong với id=" + iddd, "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                string query = string.Format("delete from diadiem WHERE Madiadiem= {0}", iddd);
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

        private void btnsua_Click(object sender, EventArgs e)
        {
            

                try
                {

                    string query = string.Format("update diadiem set tendiadiem = '{0}', Diachi = '{1}' where madiadiem={2} ",
                    txtdiadiem.Text, txtdiachi.Text,iddd);

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
            

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string query = string.Format(" select * from Diadiem where Tendiadiem like N'%{0}%'", txttimkiem.Text);
            DataSet ds = ketnoi.selectData(query);
            dvgdiadiem.DataSource = ds.Tables[0];
            txttimkiem.Text = "";
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            clean();
        }
    }
}
