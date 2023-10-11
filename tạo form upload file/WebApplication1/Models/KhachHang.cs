using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class KhachHang
    {
        //1. ID khách hàng : số 1,2,3,4
        //2. Tên khách hàng
        //3. Số điện thoại
        //4. Địa chỉ nhận hàng
        //5. Email
        //6. Giới tính : Nam / Nữ (sử dụng select để nhập)
        public int ID { set; get; }
        public string TenKhachHang { set; get; }
        public string SoDienThoai { set; get; }
        public string DiaChiNhanHang { set; get; }
        public string Email { set; get; }
        public string GioiTinh { set; get; }
        public string UrlHinhAnh { get; set; }
    }
}