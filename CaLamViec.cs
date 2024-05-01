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
    public partial class CaLamViec : Form
    {
        DBConnection db = new DBConnection();
        public CaLamViec()
        {
            InitializeComponent();
        }
        public void LoadCLV()
        {
            string query = "select * from V_CaLamViec";
            dgv_CLV.DataSource = db.LoadData(query);
        }
        private void CaLamViec_Load(object sender, EventArgs e)
        {
            LoadCLV();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string query = "select * from udf_CaLamViec('%%',N'%"+txt_Search.Text+"%')";
            dgv_CLV.DataSource = db.LoadData(query);
        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            string query = string.Format("exec p_Suacalamviec '{0}', '{1}'",txt_manv.Text, txt_maclv.Text);
            db.ThucThi(query);
            LoadCLV() ;
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            string query = string.Format("exec p_Xoacalamviec '{0}', '{1}'", txt_manv.Text, txt_maclv.Text);
            db.ThucThi(query);
            LoadCLV();
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
