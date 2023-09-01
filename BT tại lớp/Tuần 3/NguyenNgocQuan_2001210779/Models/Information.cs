using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace NguyenNgocQuan_2001210779.Models
{
    public class Infomation
    {
        [Required()]
        [StringLength(50,ErrorMessage ="Chiều dài tên không quá 50 kí tự ")]
        public string FullName { get; set; }

        [Required()]
        [StringLength(10, ErrorMessage = "Nhập chiều dài không quá 10 ký số ")]
        public string IdStudent { get; set; }

        [Required()]
        [EmailAddress(ErrorMessage = "Địa chỉ email không hợp lệ")]
        public string Email { get; set; }
        public string FileImage { get; set; }
        public string Note { get; set; }
        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }

        [Required()]
        public string ChooseWorkTime { get; set; }

        [Required()]
        public string SelectCourse { get; set; }
    }
    
}