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
    public partial class MonAn : Form
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
        public MonAn()
        {
            InitializeComponent();
        }
        public void LoadForm()
        {
            string query = "Select * from monan";
            GeneratePanel(query, Panel_Food);
        }
        private void MonAn_Load(object sender, EventArgs e)
        {
            LoadForm(); 
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
                UC_Food uC_Food = new UC_Food(FOOD);
                this.uc_f = uC_Food;
                panel.Controls.Add(uC_Food);
                storage_panel.Controls.Add(panel);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Food f = new Food(txt_MaMon.Text, txt_TenMon.Text, Convert.ToDouble(txt_Price.Text), "", pictureBox.ImageLocation);
            fD.Add(f);
            LoadForm();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Food f = new Food(txt_MaMon.Text, txt_TenMon.Text, Convert.ToDouble(txt_Price.Text), "", pictureBox.ImageLocation);
            fD.Delete(f);
            LoadForm();
        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            Food f = new Food(txt_MaMon.Text, txt_TenMon.Text, Convert.ToDouble(txt_Price.Text), "", pictureBox.ImageLocation);
            fD.Fix(f);
            LoadForm();
        }
        string imageLocation = "";
        private void btn_Upload_Click(object sender, EventArgs e)
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

        private void btn_Food_Click(object sender, EventArgs e)
        {
            MonAn ma = new MonAn();
            ma.Show();
            this.Hide();
        }

        private void btn_DT_Click(object sender, EventArgs e)
        {
            DoanhThu dt = new DoanhThu();
            dt.Show();
            this.Hide();
        }

        private void btn_Work_Click(object sender, EventArgs e)
        {
            CaLamViec clv = new CaLamViec();
            clv.Show();
            this.Hide();
        }

        private void btn_Emp_Click(object sender, EventArgs e)
        {
            FEmployee fe = new FEmployee();
            fe.Show();
            this.Hide();
        }

        private void btn_Guest_Click(object sender, EventArgs e)
        {
            FGuest fg = new FGuest();
            this.Hide();
            fg.Show();
        }
    }
}
