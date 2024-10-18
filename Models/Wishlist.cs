namespace WebsiteBanHang_Final.Models
{
    public class Wishlist
    {   // danh sách yêu thích
        public int WishlistID { get; set; }

        public int CustomerID { get; set; } // Foreign key
        public Customer Customer { get; set; } // Navigation property

        public int ProductID { get; set; } // Foreign key
        public Product Product { get; set; } // Navigation property

        public DateTime CreatedAt { get; set; }
    }


}
