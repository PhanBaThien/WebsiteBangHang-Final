namespace WebsiteBanHang_Final.Models
{
    public class Order
    { // đơn hàng
        public int OrderID { get; set; }

        public int CustomerID { get; set; } // Foreign key
        public Customer Customer { get; set; } // Navigation property

        public decimal TotalAmount { get; set; }
        public string OrderStatus { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; } // Navigation property
    }


}
