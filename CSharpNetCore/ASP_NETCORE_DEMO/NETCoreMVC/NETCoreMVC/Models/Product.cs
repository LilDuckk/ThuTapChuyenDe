using System.ComponentModel.DataAnnotations;

namespace NETcoreWebMVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [
            Display(Name="Họ và tên"),
            Required(ErrorMessage = "Họ tên không được để trống"),
            MinLength(6, ErrorMessage ="Họ tên ít nhất 6 ký tự"),
            MaxLength(20, ErrorMessage ="Họ tên tối đa 20 ký tự")
        ]
        public string Name { get; set; }
        [
            Display(Name = "Thông tin"),
            Required(ErrorMessage = "Thông tin không được để trống"),
            MaxLength(300, ErrorMessage = "Thông tin tối đa 300 ký tự"),
            RegularExpression(@"^(?!.*\b(die|admin|cunt|fuck|shit)\b).*$", ErrorMessage = "Mô tả không chứa từ nhạy cảm")
        ]
        public string Description { get; set; }
        [
            Display(Name = "Giá tiền"),
            Required(ErrorMessage = "Giá tiền không được để trống"),
            MinLength(3, ErrorMessage = "Giá tiền ít nhất 3 ký tự"),
        ]
        public float Price { get; set; }
        [
            Display(Name = "Giá khuyến mãi"),
            Required(ErrorMessage = "Giá tiền khuyến mãi không được để trống"),
            MinLength(3, ErrorMessage = "Giá khuyến mãi ít nhất 3 ký tự"),
        ]
        public float SalePrice { get; set; }
        [
            Display(Name = "Hình ảnh"),
            Required(ErrorMessage = "Hình ảnh không được để trống"),
        ]
        public string Image { get; set; }
        [
            Display(Name = "ID Mục"),
            Required(ErrorMessage = "ID mục không được để trống"),
        ]
        public int CategoryId { get; set; }
        [
            Display(Name = "Ngày tạo"),
            Required(ErrorMessage = "Ngày tạo không được để trống"),
        ]
        public DateTime CreateDate { get; set; }
        [
            Required(ErrorMessage ="Hãy chọn người tạo"),
            Display(Name="Người tạo")
        ]
        public string CreateBy { get; set; }
        [   
            Required(ErrorMessage ="Hãy chọn trạng thái")
        ]
        public bool Status { get; set; }

        //Tạo quan hệ ràng buộc với Category
        public virtual Category? Category { get; set; }
    }
}
