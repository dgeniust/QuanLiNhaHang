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
        public Guna2CheckBox CB_GUEST => cb_Guest;
        public Guna2CheckBox CB_EMPLOYEE => cb_Employee;
        public Guna2CheckBox CB_MANAGE => cb_Manage;
        public UC_Register()
        {
            InitializeComponent();
        }
        public LinkLabel LINK_LOG => link_Login;

        private void cb_Guest_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Guest.Checked)
            {
                cb_Employee.Enabled = false;
                cb_Manage.Enabled = false;
            }
            else
            {
                cb_Employee.Enabled = true;
                cb_Manage.Enabled = true;
            }
        }

        private void cb_Employee_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Employee.Checked)
            {
                cb_Guest.Enabled = false;
                cb_Manage.Enabled = false;
            }
            else
            {
                cb_Guest.Enabled = true;
                cb_Manage.Enabled = true;
            }
        }

        private void cb_Manage_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Manage.Checked)
            {
                cb_Guest.Enabled = false;
                cb_Employee.Enabled = false;
            }
            else
            {
                cb_Guest.Enabled = true;
                cb_Employee.Enabled = true;
            }
        }
    }
}
