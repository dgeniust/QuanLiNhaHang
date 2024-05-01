using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Class
{
    internal class FoodDAO
    {
        DBConnection db = new DBConnection();
        public void Add(Food f)
        {
            string query = string.Format("exec p_AddMonan '{0}',N'{1}',{2},'{3}'",f.mamon, f.tenmon, f.gia,f.image);
            db.ThucThi(query);
        }
        public void Delete(Food f)
        {
            string query = string.Format("exec p_DeleteMonAn '{0}'", f.mamon);
            db.ThucThi(query);
        }
        public void Fix(Food f)
        {
            string query = string.Format("exec p_UpdateMonAn '{0}',N'{1}',{2}", f.mamon, f.tenmon, f.gia);
            db.ThucThi(query);
        }
    }
}
