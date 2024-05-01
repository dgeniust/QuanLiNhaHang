using QuanLiNhaHang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang
{
    public partial class DoanhThu : Form
    {
        DBConnection db = new DBConnection();
        public DoanhThu()
        {
            InitializeComponent();
        }

        private void DoanhThu_Load(object sender, EventArgs e)
        {
            string query = "select * from V_DoanhThuNgay";
            dgv_DoanhThu.DataSource = db.LoadData(query);
        }

        private void btn_Guest_Click(object sender, EventArgs e)
        {
            FGuest fg = new FGuest();
            this.Hide();
            fg.Show();
        }

        private void btn_Emp_Click(object sender, EventArgs e)
        {
            FEmployee fe = new FEmployee();
            fe.Show();
            this.Hide();
        }

        private void btn_Work_Click(object sender, EventArgs e)
        {
            CaLamViec clv = new CaLamViec();
            clv.Show();
            this.Hide();
        }

        private void btn_DT_Click(object sender, EventArgs e)
        {
            DoanhThu dt = new DoanhThu();
            dt.Show();
            this.Hide();
        }
    }
}
