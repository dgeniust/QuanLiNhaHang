using Guna.UI2.WinForms;
using QuanLiNhaHang.Class;
using QuanLiNhaHang.User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang
{
    public partial class FEmployee : Form
    {
        DBConnection db = new DBConnection();
        bool sidebar_timer;
        EmployeeDAO empDAO = new EmployeeDAO();
        public Guna2Button BTN_HOME => btn_Home;
        public Guna2Button BTN_DATHANG => btn_DatHang;
        public Guna2Button BTN_DATMON => btn_DatMon;
        public Guna2Button BTN_DATBAN => btn_DatBan;
        public Guna2Button BTN_THUCKHACH => btn_ThucKhach;
        public Guna2Button BTN_NV => btn_NV;
        public FEmployee()
        {
            InitializeComponent();
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (sidebar_timer)
            {
                SideBar_FlowPanel.Width -= 30;
                if (SideBar_FlowPanel.Width == SideBar_FlowPanel.MinimumSize.Width)
                {
                    sidebar_timer = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                SideBar_FlowPanel.Width += 30;
                if (SideBar_FlowPanel.Width == SideBar_FlowPanel.MaximumSize.Width)
                {
                    sidebar_timer = true;
                    sidebarTimer.Stop();
                }
            }
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
                    Size = new Size(165, 215),
                    BorderStyle = BorderStyle.FixedSingle
                };
                Employee ep = new Employee(dr);

                UC_Employee uC_Employee = new UC_Employee(ep);
                panel.Controls.Add(uC_Employee);
                storage_panel.Controls.Add(panel);
            }
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }
        public void LoadForm()
        {
            string query = "SELECT * FROM udf_ThongTinNhanVien('%%')";
            GeneratePanel(query, Panel_NV);
        }
        private void FEmployee_Load(object sender, EventArgs e)
        {
            string query = "Select * from V_ThongTinNhanVien";
            GeneratePanel(query, Panel_NV);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from f_TimkiemNhanvien(N'%" + txt_Search.Text + "%')";
            GeneratePanel(query, Panel_NV);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(txt_MaNV.Text.ToUpper(), txt_Name.Text, txt_SDT.Text,txt_CV.Text.ToUpper(), Convert.ToDateTime(null), null);
            empDAO.Add(emp);
            LoadForm();
        }

        private void btn_Fix_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(txt_MaNV.Text.ToUpper(), txt_Name.Text, txt_SDT.Text, txt_CV.Text.ToUpper(), Convert.ToDateTime(null), null);
            empDAO.Fix(emp);
            LoadForm();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee(txt_MaNV.Text.ToUpper(), txt_Name.Text, txt_SDT.Text, txt_CV.Text.ToUpper(), Convert.ToDateTime(null), null);
            empDAO.Delete(emp);
            LoadForm();
        }

        private void btn_NV_Click(object sender, EventArgs e)
        {
            FEmployee fe = new FEmployee();
            fe.Show();
            this.Hide();
            fe.BTN_NV.BackColor = Color.White;
            fe.BTN_NV.ForeColor = Color.FromArgb(30, 40, 45);
        }

        private void btn_DatMon_Click(object sender, EventArgs e)
        {
            FFood ff = new FFood();
            ff.Show();
            this.Hide();
            ff.BTN_DATMON.BackColor = Color.White;
            ff.BTN_DATMON.ForeColor = Color.FromArgb(30, 40, 45);
        }

        private void btn_DatBan_Click(object sender, EventArgs e)
        {
            FBookTable fb = new FBookTable();
            fb.Show();
            this.Hide();
            fb.BTN_DATBAN.BackColor = Color.White;
            fb.BTN_DATBAN.ForeColor = Color.FromArgb(30, 40, 45);
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            FHome fh = new FHome();
            fh.Show();
            this.Hide();
        }
    }
}
