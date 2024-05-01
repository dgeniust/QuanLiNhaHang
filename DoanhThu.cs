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
    }
}
