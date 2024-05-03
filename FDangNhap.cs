using QuanLiNhaHang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang
{
    public partial class FDangNhap : Form
    {
        DBConnection db = new DBConnection();
        public FDangNhap()
        {
            InitializeComponent();
            uC_Login1.LINK_REG.Click += ShowRegister;
            uC_Register1.LINK_LOG.Click += ShowLogin;
            uC_Register1.BTN_EXITR.Click += ExitRegister;
            uC_Register1.BTN_REGISTER.Click += Register;
            uC_Login1.BTN_EXIT.Click += ExitLogin;
            uC_Login1.BTN_LOGIN.Click += Login;
        }
        public void ShowRegister(object sender, EventArgs e)
        {
            uC_Register1.Visible = true;
            uC_Login1.Visible = false;
            uC_Register1.BringToFront();
        }

        private void ExitRegister(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowLogin(object sender, EventArgs e)
        {
            uC_Login1.Visible = true;
            uC_Register1.Visible = false;
            uC_Login1.BringToFront();
        }

        public void ExitLogin(object sender, EventArgs e)
        {
            this.Close();
        }
        string tk = "";
        string mk = "";
        public void Login(object sender, EventArgs e)
        {
            tk = uC_Login1.TXT_USER.Text;
            mk = uC_Login1.TXT_PASS.Text;
            string type = "";
            SqlConnection conn = new SqlConnection(string.Format(@"Data Source=DAT\SQLEXPRESS;Initial Catalog=quanlynhahang;User ID={0};Password={1};Encrypt=False", tk, mk));
            //MessageBox.Show("SQL: "+ string.Format(@"Data Source=DAT\SQLEXPRESS;Initial Catalog=quanlynhahang;User ID={0};Password={1};Encrypt=False", tk, mk));
            try
            {
                conn.Open();
                string query = "SELECT dbo.getRole('"+tk+"')"; 
                DataTable dt = new DataTable();
                dt = db.LoadData(query);
                foreach (DataRow dr in dt.Rows)
                {
                    type = dr[0].ToString();
                }

                if (uC_Login1.CB_GUEST.Checked || type == "Thuckhach")
                {
                    MessageBox.Show(type);
                    FBookTable fB = new FBookTable(tk, type);
                    fB.Show();
                    this.Hide();
                }
                if (uC_Login1.CB_EMPLOYEE.Checked || type == "Nhanvien")
                {
                    MessageBox.Show(type);
                    FBookTable fB = new FBookTable();
                    fB.Show();
                    this.Hide();
                }
                if (uC_Login1.CB_MANAGE.Checked || type == "Quanli")
                {
                    MessageBox.Show(type);
                    CaLamViec fh = new CaLamViec();
                    fh.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }
        public void Register(object sender, EventArgs e)
        {
            if(uC_Register1.CB_GUEST.Checked)
            {
                string query = string.Format("exec AddThuckhach '{0}','{1}','{2}'", uC_Register1.TXT_USER.Text, uC_Register1.TXT_NAME.Text, uC_Register1.TXT_SDT.Text);
                db.ThucThi(query);
            }
            else if(uC_Register1.CB_EMPLOYEE.Checked)
            {
                string query = string.Format("exec p_InsertNhanvien '{0}',N'{1}','{2}','{3}'", uC_Register1.TXT_USER.Text, uC_Register1.TXT_NAME.Text, uC_Register1.TXT_SDT.Text,"CV04");
                db.ThucThi(query);
            }
            else if(uC_Register1.CB_MANAGE.Checked)
            {
                string query = string.Format("exec p_InsertNhanvien '{0}',N'{1}','{2}','{3}'", uC_Register1.TXT_USER.Text, uC_Register1.TXT_NAME.Text, uC_Register1.TXT_SDT.Text, "CV07");
                db.ThucThi(query);
            }
            if (MessageBox.Show("Đăng kí thành công! Bạn có muốn đăng nhập không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                uC_Register1.Visible = false;
                uC_Login1.Visible = true;
                uC_Login1.BringToFront();
            }
        }
    }
}
