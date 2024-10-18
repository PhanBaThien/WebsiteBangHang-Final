using System;
using System.ComponentModel.DataAnnotations;

namespace WebsiteBanHang_Final.Models
{
    public class ProductReview
    {
        [Key] // Đánh dấu ReviewID là khóa chính
        public int ReviewID { get; set; }

        public int CustomerID { get; set; } // Foreign key
        public Customer Customer { get; set; } // Navigation property

        public int ProductID { get; set; } // Foreign key
        public Product Product { get; set; } // Navigation property

        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
