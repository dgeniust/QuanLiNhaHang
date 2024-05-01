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
    public partial class FHome : Form
    {
        public FHome()
        {
            InitializeComponent();
            timer1.Start();
            pictureBox.Image = imageList1.Images[0];
        }
        int count = 1;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (count <= 9)
            {
                pictureBox.Image = imageList1.Images[count];
                count++;
            }
            else
            {
                count = 0;
            }
}

        private void btn_Home_Click(object sender, EventArgs e)
        {
            FHome fh = new FHome();
        }
    }
}
