using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class DonHang
    {
        // ID đơn hàng; Kiểu số
        public int ID { set; get; }
        // Tên khách hàng
        public string TenKhachHang { set; get; }
        // Số điện thoại
        public string SoDienThoai { set; get; }
        // Địa chỉ giao hàng
        public string DiaChiGiaoHang { set; get; }
        // Ngày đặt hàng
        public DateTime? NgayDatHang { set; get; }


        // Danh sách máy tính đặt mua
         public List<MayTinh> MayTinhDatMua { set; get; }
        // Bước 1: Tạo class đơn hàng
        // Bước 2: Tạo trang danh sách đơn hàng
        // Bước 3: Tạo form thêm, sửa, xóa đơn hàng
        // Bước 4: Tạo trang chi tiết đơn hàng
        // Bước 5: Thêm sản phẩm đặt mua cho đơn hàng
        // Bước 6: Sửa, xóa chi tiết đơn hàng
    }
}