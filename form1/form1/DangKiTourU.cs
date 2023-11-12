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
    public partial class DangKiTourU : UserControl
    {
        public DangKiTourU()
        {
            InitializeComponent();
        }
        Ketnoi kn = new Ketnoi();
        public void getdata()
        {
            string query = "select * from TaoPhieuDangKy, KhachHang where TaoPhieuDangKy.SDTKH = KhachHang.SDTKH";
            DataSet ds = kn.selectData(query);
            dataGridView1.DataSource = ds.Tables[0];
          
        }

        private void DangKiTourU_Load(object sender, EventArgs e)
        {
            getdata();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            DialogResult thongbao;
            thongbao = MessageBox.Show("Ban co muon xoa khong ?", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (thongbao == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(Ketnoi.constr);
                conn.Open();
                string query = string.Format("delete from NhanVien WHERE SDTKH = {0}", txtSDT.Text);
                bool kt = kn.Thucthi(query);
                if (kt)
                {
                    MessageBox.Show("Xóa thành công ");
                    getdata();
                 
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }

            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
           
        }
    }
}
