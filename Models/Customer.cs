namespace WebsiteBanHang_Final.Models
{
    public class Customer
    {//thông tin khách hàng
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

}
