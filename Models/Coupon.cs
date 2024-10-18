namespace WebsiteBanHang_Final.Models
{
    public class Coupon
    { // Mã giảm giá
        public int CouponID { get; set; }
        public string Code { get; set; }
        public decimal DiscountAmount { get; set; }
        public DateTime ExpirationDate { get; set; }
    }

}
