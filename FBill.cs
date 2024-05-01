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
    public partial class FBill : Form
    {
        DBConnection db = new DBConnection();
        BookTable bt;
        string temp;
        public Guna2Button BTN_HOME => btn_Home;
        public Guna2Button BTN_DATHANG => btn_DatHang;
        public Guna2Button BTN_DATMON => btn_DatMon;
        public Guna2Button BTN_DATBAN => btn_DatBan;
        public Guna2Button BTN_THUCKHACH => btn_ThucKhach;
        public Guna2Button BTN_NV => btn_NV;
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

        private void btn_DatBan_Click(object sender, EventArgs e)
        {
            FBookTable fb = new FBookTable();
            fb.Show();
            this.Hide();
            fb.BTN_DATBAN.BackColor = Color.White;
            fb.BTN_DATBAN.ForeColor = Color.FromArgb(30, 40, 45);
        }

        private void btn_DatMon_Click(object sender, EventArgs e)
        {
            FFood ff = new FFood();
            ff.Show();
            this.Hide();
            ff.BTN_DATMON.BackColor = Color.White;
            ff.BTN_DATMON.ForeColor = Color.FromArgb(30, 40, 45);
        }

        private void btn_NV_Click(object sender, EventArgs e)
        {
            FEmployee fe = new FEmployee();
            fe.Show();
            this.Hide();
            fe.BTN_NV.BackColor = Color.White;
            fe.BTN_NV.ForeColor = Color.FromArgb(30, 40, 45);
        }
    }
}
