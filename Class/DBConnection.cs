using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.Class
{
    public class DBConnection
    {
        //FDangNhap fd;
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.cnnStr);
        public SqlConnection GetConnectionString()
        {
            return conn;
        }
        public DataTable LoadData(string query)
        {
            string sqlStr = string.Format(query);
            SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
        public void ThucThi(string thucthi)
        {
            try
            {
                conn.Open();
                string sql = thucthi;
                SqlCommand cmd = new SqlCommand(sql, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
