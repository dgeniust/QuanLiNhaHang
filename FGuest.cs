using QuanLiNhaHang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang
{
    public partial class FGuest : Form
    {
        DBConnection db = new DBConnection();
        public FGuest()
        {
            InitializeComponent();
        }

        private void FGuest_Load(object sender, EventArgs e)
        {
            string query = "Select * from udf_ThongTinKhachHang('%%')";
            dgv_Guest.DataSource = db.LoadData(query);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string query = "select * from udf_ThongTinKhachHang('%"+txt_Search.Text+"%')";
            dgv_Guest.DataSource = db.LoadData(query);
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
    }
}
