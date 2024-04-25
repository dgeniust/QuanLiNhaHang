using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.Class
{
    public class EmployeeDAO
    {
        DBConnection db = new DBConnection();
        public void Add(Employee emp)
        {
            string query = string.Format("exec p_InsertNhanvien '{0}',N'{1}','{2}','{3}'",emp.manv,emp.tennv,emp.sdt,emp.macv);
            db.ThucThi(query);
        }
        public void Fix(Employee emp)
        {
            string query = string.Format("exec p_UpdateNhanvien '{0}',N'{1}','{2}','{3}'", emp.manv, emp.tennv, emp.sdt, emp.macv);
            db.ThucThi(query);
        }
        public void Delete(Employee emp)
        {
            string query = string.Format("exec p_DeleteNhanvien '{0}'", emp.manv);
            db.ThucThi(query);
        }
    }
}
