using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Class
{
    public class BookTable
    {
        public string madh;
        public string matk;
        public int slg;
        public string maban;
        public DateTime ngaynhanban;

        public BookTable(string madh, string matk, int slg, string maban, DateTime ngaynhanban)
        {
            this.madh = madh;
            this.matk = matk;
            this.slg = slg;
            this.maban = maban;
            this.ngaynhanban = ngaynhanban;
        }
        public BookTable(DataRow dr)
        {
            this.madh = dr[0].ToString();
            this.matk = dr[1].ToString();
            //this.slg = Convert.ToInt32(dr[2].ToString());
            this.maban = dr[3].ToString();
            this.ngaynhanban = Convert.ToDateTime(dr[4].ToString());
        }
    }
}
