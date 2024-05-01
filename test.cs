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
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void test_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = LoadImageFromFile("C:/Users/DELL/Downloads/IMAGE/IMAGEFOOD/PhoThinLoDuc.jpg");
        }
        public Image LoadImageFromFile(string filePath)
        {
            try
            {
                return Image.FromFile(filePath);
            }
            catch
            {
                // Handle file not found exception (e.g., display error message)
                MessageBox.Show("Error: Image file not found!");
                return null;
            }
        }
    }
}
