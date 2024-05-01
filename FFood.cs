using Guna.UI2.WinForms;
using QuanLiNhaHang.Class;
using QuanLiNhaHang.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang
{
    public partial class FFood : Form
    {
        DBConnection db = new DBConnection();
        public BookTable bt;
        Food food;
        UC_Food uc_f;
        public int slg;
        public string mamon;
        public string madhtemp = "";
        DatMonDAO dmD = new DatMonDAO();
        FoodDAO fD = new FoodDAO();
        string type = "";
        public Guna2Button BTN_DATMON => btn_DatMon;
        public FFood()
        {
            InitializeComponent();
        }
        public FFood(BookTable BT, string TYPE)
        {
            InitializeComponent();
            this.bt = BT;
            this.type = TYPE;
            
        }
        bool sidebar_timer;
        public Label LBL_NUMBEROGFOOD => lbl_NumberOfFood;
        
        public void LoadForm()
        {
            string query = "Select * from monan";
            GeneratePanel(query, Panel_Food);
        }
        private void FFood_Load(object sender, EventArgs e)
        {
            LoadForm();
            string query1 = "select MAX(madh) from donhang";
            DataTable dt = db.LoadData(query1);
            foreach (DataRow dr in dt.Rows)
            {
                bt.madh = dr[0].ToString();
            }
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
                this.uc_f = uC_Food;
                panel.Controls.Add(uC_Food);
                storage_panel.Controls.Add(panel);
            }
        }
        public string tempdh = "";

        private void btn_ShowFood_Click(object sender, EventArgs e)
        {
            FBill fb = new FBill(bt, tempdh);
            fb.ShowDialog();
            this.Hide();
        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebar_timer)
            {
                SideBar_FlowPanel.Width -= 30;
                if (SideBar_FlowPanel.Width == SideBar_FlowPanel.MinimumSize.Width)
                {
                    sidebar_timer = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                SideBar_FlowPanel.Width += 30;
                if (SideBar_FlowPanel.Width == SideBar_FlowPanel.MaximumSize.Width)
                {
                    sidebar_timer = true;
                    sidebarTimer.Stop();
                }
            }
        }

        
        string imageLocation = "";

        private void btn_DatBan_Click(object sender, EventArgs e)
        {
            FBookTable fb = new FBookTable(bt.matk,type);
            fb.Show();
            this.Hide();
            fb.BTN_DATBAN.BackColor = Color.White;
            fb.BTN_DATBAN.ForeColor = Color.FromArgb(30, 40, 45);
        }

        private void btn_DatMon_Click(object sender, EventArgs e)
        {
            FFood ff = new FFood(bt,type);
            ff.Show();
            this.Hide();
            ff.BTN_DATMON.BackColor = Color.White;
            ff.BTN_DATMON.ForeColor = Color.FromArgb(30, 40, 45);
        }
        private void btn_Fix_Click_1(object sender, EventArgs e)
        {
            Food f = new Food(txt_MaMon.Text, txt_TenMon.Text, Convert.ToDouble(txt_Price.Text), "", pictureBox.ImageLocation);
            fD.Fix(f);
            LoadForm();
        }

        private void btn_Delete_Click_1(object sender, EventArgs e)
        {
            Food f = new Food(txt_MaMon.Text, txt_TenMon.Text, Convert.ToDouble(txt_Price.Text), "", pictureBox.ImageLocation);
            fD.Delete(f);
            LoadForm();

        }

        private void btn_Add_Click_1(object sender, EventArgs e)
        {

            Food f = new Food(txt_MaMon.Text, txt_TenMon.Text, Convert.ToDouble(txt_Price.Text), "", pictureBox.ImageLocation);
            fD.Add(f);
            LoadForm();
        }

        private void btn_Upload_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg|PNG files(*.png)|*.png|All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
