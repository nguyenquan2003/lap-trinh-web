using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MayTinh
    {
        //Tạo một class MayTinh gồm các thuộc tính:
        //1. MaMay: Là một dãy 10 chữ số
        //2. Tên dòng máy : vd : Asus x555
        //3. Giá bán: 50000000vnđ
        //4. Ngày sản xuất: Ngày/tháng/năm
        //5. Hãng sản xuất: Asus, Dell.Apple

        //Điền dữ liệu vào danh sách máy tính: 5 cái
        //Hiển thị 5 cái máy tính lên trang chủ(view)
        //Hiển thị 2 cái có giá thấp nhất(view)
        //Hiển thị sắp xếp từ giá cao đến thấp(view)
        //Hiển thị các máy thuộc hãng Asus(view)
        public string MaMay { get; set; }
        public string DongMay { get; set; }
        public double GiaBan { get; set; }
        public DateTime NgaySanXuat { get; set; }
        public string HangSanXuat { get; set; }

        public static List<MayTinh> KhoiTao5May()
        {
            List<MayTinh> DSMayTinh = new List<MayTinh>();

            DSMayTinh.Add(new MayTinh()
            {
                MaMay = "1234567890",
                DongMay = "Asus Nitro",
                GiaBan = 15000000,
                NgaySanXuat = new DateTime(2020, 3, 2),
                HangSanXuat = "Asus"
            });

            DSMayTinh.Add(new MayTinh()
            {
                MaMay = "2345678901",
                DongMay = "Dell Inspiron",
                GiaBan = 12000000,
                NgaySanXuat = new DateTime(2021, 5, 10),
                HangSanXuat = "Dell"
            });

            DSMayTinh.Add(new MayTinh()
            {
                MaMay = "3456789012",
                DongMay = "HP Pavilion",
                GiaBan = 18000000,
                NgaySanXuat = new DateTime(2019, 8, 15),
                HangSanXuat = "HP"
            });

            DSMayTinh.Add(new MayTinh()
            {
                MaMay = "4567890123",
                DongMay = "Lenovo ThinkPad",
                GiaBan = 20000000,
                NgaySanXuat = new DateTime(2022, 2, 28),
                HangSanXuat = "Lenovo"
            });

            DSMayTinh.Add(new MayTinh()
            {
                MaMay = "5678901234",
                DongMay = "Asus Predator",
                GiaBan = 17000000,
                NgaySanXuat = new DateTime(2023, 7, 15),
                HangSanXuat = "Asus"
            });
            return DSMayTinh;
        }
    }
}
