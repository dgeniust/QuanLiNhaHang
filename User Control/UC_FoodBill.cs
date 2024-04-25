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

namespace QuanLiNhaHang.User_Control
{
    public partial class UC_FoodBill : UserControl
    {
        Food food;
        public UC_FoodBill(Food FOOD)
        {
            InitializeComponent();
            this.food = FOOD;
            this.lbl_Name.Text = FOOD.tenmon;
            this.lbl_Ma.Text = FOOD.mamon;
            this.lbl_Price.Text = FOOD.gia.ToString() + "đ";
        }

        private void UC_FoodBill_Load(object sender, EventArgs e)
        {

        }
    }
}
