using Guna.UI2.WinForms;
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
    public partial class UC_Register : UserControl
    {
        public Guna2PictureBox BTN_EXITR => pbox_btn_Exit;
        public Guna2Button BTN_REGISTER => btn_Register;
        public Guna2TextBox TXT_USER => txt_Username;
        public Guna2TextBox TXT_SDT => txt_sdt;
        public Guna2TextBox TXT_NAME => txt_Ten;
        public UC_Register()
        {
            InitializeComponent();
        }
        public LinkLabel LINK_LOG => link_Login;
    }
}
