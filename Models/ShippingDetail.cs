namespace WebsiteBanHang_Final.Models
{
    public class ShippingDetail
    { //chi tiết vận chuyển hàng
        public int Id { get; set; } // Primary Key
        public int OrderID { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public DateTime ShippedDate { get; set; }
    }
}
