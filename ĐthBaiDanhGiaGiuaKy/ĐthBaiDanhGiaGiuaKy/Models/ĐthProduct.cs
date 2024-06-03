using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ĐthBaiDanhGiaGiuaKy.Models
{
    public class ĐthProduct
    {
        [Key]
        public int ĐthID { get; set; }
        [DisplayName ("Đth:Họ và tên")]
        [Required(ErrorMessage ="Đth:Chưa nhập dữ liệu")]
        [RegularExpression(@"^[A-Za-z ]{2,25}$", ErrorMessage = "Họ tên chỉ chứa ký tự viết hoa và khoảng trắng")]
        [StringLength(100,MinimumLength =5, ErrorMessage ="Đth:Họ và tên chỉ chứa tối thiểu 5 ký tự tối đa 100")]
        public string ĐthName { get; set; }
        [DisplayName("Đth: Ảnh")]
        [Required(ErrorMessage = "Đth:Chưa nhập dữ liệu")]
        [DataType(DataType.ImageUrl, ErrorMessage = "Đth:Đây không phải là URL hình ảnh hợp lệ")]
        public string ĐthImage { get; set; }
        [DisplayName("Đth: Số lượng")]
        [Required(ErrorMessage = "Đth:Chưa nhập dữ liệu")]
        [Range(1,100, ErrorMessage ="Đth:Số lượng phải trong khoảng 1 đến 100")]
        public int ĐthQuanlity { get; set; }
        [DisplayName("Đth: Giá")]
        [Required(ErrorMessage = "Đth:Chưa nhập dữ liệu")]
        [Range(1,int.MaxValue, ErrorMessage ="Đth: Giá phải lớn hơn 0")]
        public int ĐthPrice { get; set; }
        public bool DdthIssActive { get; set; } = true;

    }
}