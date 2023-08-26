using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TH2B3.Models
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string GT { get; set; }
        public string Hinh { get; set; }
        public NhanVien()
        {
            MaNV = 101;
            TenNV = "Mr.Trung";
            GT = "Nam";
            Hinh = "NV01.jpg";
        }
    }
}