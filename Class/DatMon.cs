using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.Class
{
    public class DatMon
    {
        public string madh;
        public string matk;
        public string mamon;
        public int slg;
        public string ghichu;
        public string maban;

        public DatMon(string madh, string matk, string mamon, int slg, string ghichu, string maban)
        {
            this.madh = madh;
            this.matk = matk;
            this.mamon = mamon;
            this.slg = slg;
            this.ghichu = ghichu;
            this.maban = maban;
        }
    }
}
