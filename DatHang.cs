using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang
{
    public class DatHang
    {
        public string madh;
        public string matk;
        public string mamon;
        public int slg;
        public string ghichu;
        public string diachi;
        public string manv;

        public DatHang(string madh, string matk, string mamon, int slg, string ghichu, string diachi, string manv)
        {
            this.madh = madh;
            this.matk = matk;
            this.mamon = mamon;
            this.slg = slg;
            this.ghichu = ghichu;
            this.diachi = diachi;
            this.manv = manv;
        }
    }
}
