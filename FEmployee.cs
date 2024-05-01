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
        public FEmployee()
        {
            InitializeComponent();
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

        private void btn_Guest_Click(object sender, EventArgs e)
        {
            FGuest fg = new FGuest();
            this.Hide();
            fg.Show();
        }

        private void btn_Emp_Click(object sender, EventArgs e)
        {
            FEmployee fe = new FEmployee();
            fe.Show();
            this.Hide();
        }

        private void btn_Work_Click(object sender, EventArgs e)
        {
            CaLamViec clv = new CaLamViec();
            clv.Show();
            this.Hide();
        }
    }
}
