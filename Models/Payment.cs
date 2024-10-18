namespace WebsiteBanHang_Final.Models
{
    public class Payment
    { // thông tin thanh toán
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentStatus { get; set; }
        public string TransactionID { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
    }

}
