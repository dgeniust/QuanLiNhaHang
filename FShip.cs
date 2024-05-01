using Guna.UI2.WinForms;
using QuanLiNhaHang.Class;
using QuanLiNhaHang.User_Control;
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
    public partial class FShip : Form
    {
        DBConnection db = new DBConnection();
        DatHangDAO dhDAO = new DatHangDAO();
        Food food;
        public Guna2TextBox TXT_MAMON => txt_MaMon;
        public FShip()
        {
            InitializeComponent();
            string query = "Select * from monan";
            GeneratePanel(query, Panel_Food);
        }
        public void GeneratePanel(string query, Panel storage_panel)
        {
            storage_panel.Controls.Clear();
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            foreach (DataRow dr in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Size = new Size(330, 115),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Food FOOD = new Food(dr);
                this.food = FOOD;
                UC_Food uC_Food = new UC_Food(FOOD, this);

                panel.Controls.Add(uC_Food);
                storage_panel.Controls.Add(panel);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM udf_TimKiemMonAnTheoTen(N'%"+txt_Search.Text+"%')";
            GeneratePanel(query, Panel_Food);
        }

        private void btn_BookShip_Click(object sender, EventArgs e)
        {
            
            DatHang dh = new DatHang("",txt_MaTK.Text,txt_MaMon.Text,Convert.ToInt32(txt_slg.Text),txt_GhiChu.Text,txt_Address.Text,"");
            dhDAO.BookShip(dh);

            MessageBox.Show(dh.madh);
        }

        private void FShip_Load(object sender, EventArgs e)
        {
            
        }
    }
}
