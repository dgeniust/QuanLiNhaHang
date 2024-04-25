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
    public partial class FBill : Form
    {
        DBConnection db = new DBConnection();
        BookTable bt;
        string temp;
        public FBill(BookTable BT, string madhtemp)
        {
            InitializeComponent();
            this.temp = madhtemp;
            this.bt = BT;
            LoadForm();
        }
        public FBill()
        {
            InitializeComponent();
            LoadForm();
        }
        public void LoadForm()
        {
            string query = "select * from GetHoaDonDetails('%"+ temp + "%')";
            GeneratePanel(query, Panel_Bill);
        }
        public void GeneratePanel(string query, Panel storage_panel)
        {
            storage_panel.Controls.Clear();
            DataTable dt = new DataTable();
            dt = db.LoadData(query);
            int x = 0;
            foreach (DataRow dr in dt.Rows)
            {
                Panel panel = new Panel
                {
                    Size = new Size(330, 115),
                    Location = new Point(0, x),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Food FOOD = new Food(dr);
                UC_FoodBill uC_Food = new UC_FoodBill(FOOD);
                x += 115;
                panel.Controls.Add(uC_Food);
                storage_panel.Controls.Add(panel);
            }
        }
    }
}
