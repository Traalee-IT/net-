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
    public partial class HomeU : UserControl
    {
        Ketnoi ketnoi;
       

        public HomeU()
        {
            ketnoi = new Ketnoi(); 
            InitializeComponent();
           this.flowLayoutPanel1.Controls.Clear();
          
           List<Toudulich> danhsach = ketnoi.SelectAll();
            //Console.WriteLine(danhsach + "dnah sachs ");
            this.flowLayoutPanel1.Controls.Clear();
            foreach (Toudulich tour in danhsach)
              {
               flowLayoutPanel1.Controls.Add(new UseControlBaiViet(tour));
             }
          
        }

        private void HomeU_Load(object sender, EventArgs e)
        {
           
        }
    }
}
