using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb_TranQuocHuy.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tiêu đề sách không được để trống.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Tên tác giả không được để trống.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Tên tác giả phải từ 5 đến 50 ký tự.")]
        public string Author { get; set; }

        [Range(0, double.MaxValue, ErrorMessage = "Giá sách phải là số >= 0.")]
        public decimal Price { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Số lượng phải là số nguyên >= 0.")]
        public int Quantilty { get; set; }
    }
}
