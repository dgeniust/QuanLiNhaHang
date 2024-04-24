using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace QuanLiNhaHang.Class
{
    public class Table
    {
        public string maban;
        public string slghe;
        public string trangthai;

        public Table(string maban, string slghe, string trangthai)
        {
            this.maban = maban;
            this.slghe = slghe;
            this.trangthai = trangthai;
        }
        public Table(DataRow dr)
        {
            this.maban = dr[0].ToString();
            this.slghe = dr[1].ToString();
            this.trangthai = dr[2].ToString();
        }
    }
}
