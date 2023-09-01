using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bai1.Models
{
    public class KhoaModels
    {
        public string TenKhoa { get; set; }

        public int NamThanhLap { get; set; }

        public string Message { get; set; }

        public KhoaModels()
        {
            TenKhoa = "Khoa Công nghệ Thông tin";
            NamThanhLap = 2003;
            Message = "Chào mừng các bạn đến với FIT -HUIT";
        }
    }
}