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

        private void FEmployee_Load(object sender, EventArgs e)
        {
            string query = "Select * from V_ThongTinNhanVien";
            GeneratePanel(query, Panel_NV);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from f_TimkiemNhanvien(N'" + txt_Search.Text + "')";
            GeneratePanel(query, Panel_NV);
        }
    }
}
