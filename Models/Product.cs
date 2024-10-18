namespace WebsiteBanHang_Final.Models
{
    public class Product
    { // sản phẩm
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }

        public int CategoryID { get; set; } // Foreign key
        public Category Category { get; set; } // Navigation property

        public string ImageURL { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }



}
