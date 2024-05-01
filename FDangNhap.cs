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
        }
        public void ShowRegister(object sender, EventArgs e)
        {
            uC_Register1.Visible = true;
            uC_Login1.Visible = false;
            uC_Register1.BringToFront();
            uC_Register1.BTN_EXITR.Click += ExitRegister;
            uC_Register1.BTN_REGISTER.Click += Register;
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
            uC_Login1.BTN_EXIT.Click += ExitLogin;
            uC_Login1.BTN_LOGIN.Click += Login;
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
            /*try
            {
                conn.Open();
                if(uC_Login1.CB_GUEST.Checked)
                {
                    type = uC_Login1.CB_GUEST.Text;
                }
                string s = "Select * from Nhanvien where manv = '" + tk + "'";
                DataTable dt = new DataTable(); 
                SqlDataAdapter adapter = new SqlDataAdapter(s, conn);
                adapter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    MessageBox.Show(dr[0].ToString() + " " + dr[1].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }*/
            
        }
        public void ShowData(string type, string mathuchthe)
        {

        }
        public void Register(object sender, EventArgs e)
        {

        }
        /*string tk = Convert.ToString(Console.ReadLine());
        string mk = Convert.ToString(Console.ReadLine());
        string sqlstring = string.Format(@"Data Source=LAPTOP-GPLGAEAL\YORDLEYUU;Initial Catalog=quanlynhahang;User ID={0};Password={1};Encrypt=False", tk, mk);
        SqlConnection conn = new SqlConnection(sqlstring);
            try
            {
                conn.Open();
                string s = string.Format("select * from Nhanvien");
        DataTable dt = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter(s, conn);
        adapter.Fill(dt);
                foreach(DataRow dr in dt.Rows)
                {
                    Console.WriteLine(dr[0]);
                }
}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            conn.Close();
}
            Console.ReadLine();
        }*/
    }
}
