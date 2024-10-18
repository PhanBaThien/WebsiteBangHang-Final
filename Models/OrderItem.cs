namespace WebsiteBanHang_Final.Models
{
    public class OrderItem
    {
        public int OrderItemID { get; set; }

        public int OrderID { get; set; } // Foreign key
        public Order Order { get; set; } // Navigation property

        public int ProductID { get; set; } // Foreign key
        public Product Product { get; set; } // Navigation property

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }


}
