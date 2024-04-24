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
    public partial class UC_BookTable : UserControl
    {
        Table tb;
        FBookTable fb;
        public UC_BookTable(Table TB, FBookTable FB)
        {
            InitializeComponent();
            this.tb = TB;
            this.fb = FB;
            //this.bt = BT;
            this.pictureBox.Click += ShowInfo;
            this.lbl_MaBan.Click += ShowInfo;   
            this.Click += ShowInfo;
            this.lbl_slg.Click += ShowInfo;
            this.lbl_MaBan.Text = TB.maban;
            //this.lbl_MaTK.Text = "Mã thực khách: "+BT.matk;
            this.lbl_slg.Text = "Số lượng: "+TB.slghe;
            if(TB.trangthai == "Available")
            {
                this.BackColor = Color.White;
            }
            else
            {
                this.BackColor = Color.LightCoral;
            }
        }
        public void ShowInfo(object sender, EventArgs e)
        {
            fb.TXT_MABAN.Text = this.lbl_MaBan.Text;
        }

    }
}
