using Guna.UI2.WinForms;
using QuanLiNhaHang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.User_Control
{
    public partial class UC_Food : UserControl
    {
        Food food;
        FFood ff;
        FShip fs;
        //BookTable bt;
        string mamon = "";
        DatMonDAO dmD = new DatMonDAO();
        public Guna2Button BTN_PLUS => btn_Plus;
        public Guna2Button BTN_MINUS => btn_Minus;
        public Guna2Button BTN_ADDFOOD => btn_Add;
        public Label LBL_NUMBER => lbl_Number;
        public Label LBL_MA => lbl_Ma;
        public UC_Food(Food FOOD,FFood FF)
        {
            InitializeComponent();
            this.btn_Add.Click += AddFood;
            this.ff = FF;
            this.BTN_MINUS.Click += Minus;
            this.BTN_PLUS.Click += Plus;
            this.lbl_Ma.Text = FOOD.mamon;
            this.food = FOOD;
            this.lbl_Name.Text = FOOD.tenmon;
            this.lbl_Price.Text = FOOD.gia.ToString()+"đ";
            this.pictureBox.Image = LoadImageFromFile(FOOD.image);
        }
        public UC_Food(Food FOOD)
        {
            InitializeComponent();
            this.lbl_Ma.Text = FOOD.mamon;
            this.food = FOOD;
            this.lbl_Name.Text = FOOD.tenmon;
            this.lbl_Price.Text = FOOD.gia.ToString() + "đ";
            this.pictureBox.Image = LoadImageFromFile(FOOD.image);
        }
        public void AddFood(object sender, EventArgs e)
        {
            DatMon dm = new DatMon(ff.bt.madh, ff.bt.matk, lbl_Ma.Text, Convert.ToInt32(lbl_Number.Text), "NOTE", ff.bt.maban);
            dmD.AddTable(dm);
            ff.tempdh = dm.madh;
            //MessageBox.Show(lbl_Number.Text);
        }
        public UC_Food(Food FOOD, FShip FS)
        {
            InitializeComponent();
            this.fs = FS;
            this.food = FOOD;
            this.Click += ShowInfo;
            this.btn_Plus.Enabled = false;
            this.btn_Minus.Enabled = false;
            this.lbl_Number.Enabled = false;
            this.lbl_Ma.Text = FOOD.mamon;
            this.food = FOOD;
            this.lbl_Name.Text = FOOD.tenmon;
            this.lbl_Price.Text = FOOD.gia.ToString() + "đ";
            this.pictureBox.Image = LoadImageFromFile(FOOD.image);
        }
        public Image LoadImageFromFile(string filePath)
        {
            try
            {
                return Image.FromFile(filePath);
            }
            catch (Exception ex)
            {
                // Handle file not found exception (e.g., display error message)
                MessageBox.Show("Lỗi: "+ex);
                return null;
            }
        }
        public void Plus(object sender, EventArgs e)
        {
            int plus = Convert.ToInt32(this.lbl_Number.Text);
            plus += 1;
            this.lbl_Number.Text = plus.ToString();
        }
        public void Minus(object sender, EventArgs e)
        {
            int minus = Convert.ToInt32(this.lbl_Number.Text);
            minus -= 1;
            this.lbl_Number.Text = minus.ToString();
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            int add = Convert.ToInt32(ff.LBL_NUMBEROGFOOD.Text);
            add += 1;
            ff.LBL_NUMBEROGFOOD.Text = add.ToString();
            ff.mamon = this.lbl_Ma.Text;
        }
        public void ShowInfo(object sender, EventArgs e)
        {
            fs.TXT_MAMON.Text = this.lbl_Ma.Text;
        }
    }
}
