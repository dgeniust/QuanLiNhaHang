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
        public Guna2Button BTN_PLUS => btn_Plus;
        public Guna2Button BTN_MINUS => btn_Minus;
        public Guna2Button BTN_ADDFOOD => btn_Add;
        public Label LBL_NUMBER => lbl_Number;
        public Label LBL_MA => lbl_Ma;
        public UC_Food(Food FOOD,FFood FF)
        {
            InitializeComponent();
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
            this.BTN_MINUS.Click += Minus;
            this.BTN_PLUS.Click += Plus;
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
            catch (FileNotFoundException)
            {
                // Handle file not found exception (e.g., display error message)
                MessageBox.Show("Error: Image file not found!");
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
    }
}
