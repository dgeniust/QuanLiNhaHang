using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang.Class
{
    public class BookTableDAO
    {
        DBConnection db = new DBConnection();
        public void AddTable(BookTable bt)
        {
            string query = string.Format("exec Themdatban '{0}', '{1}', {2}, '{3}', '{4}'", bt.madh, bt.matk,bt.slg, bt.maban, bt.ngaynhanban);
            MessageBox.Show(bt.matk);
            db.ThucThi(query);
        }
    }
}
