using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2001210779_NguyenNgocQuan_PC05.Models
{
    public class SanPhamM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Gia { get; set; }
        public string Mota { get; set; }
        public DateTime NgayCN { get; set; }
        public string Anh { get; set; }
        public int SLTon { get; set; }
        public int MaL { get; set; }
        public int Moi { get; set; }
    }
}