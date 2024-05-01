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

        private void CaLamViec_Load(object sender, EventArgs e)
        {
            string query = "select * from V_CaLamViec";
            dgv_CLV.DataSource = db.LoadData(query);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string query = "select * from udf_CaLamViec('%%','nv01')";
            dgv_CLV.DataSource = db.LoadData(query);
        }
    }
}
