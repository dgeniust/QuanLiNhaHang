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
    public partial class UC_Employee : UserControl
    {
        Employee ep;
        public UC_Employee(Employee EP)
        {
            InitializeComponent();
            this.ep = EP;
            this.lbl_Name.Text = EP.tennv;
            this.lbl_Job.Text = EP.tencv;
        }
    }
}
