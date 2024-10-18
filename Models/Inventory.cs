namespace WebsiteBanHang_Final.Models
{
    public class Inventory
    { //  QL kho hàng
        public int InventoryID { get; set; }
        public int ProductID { get; set; }
        public int StockIn { get; set; }
        public int StockOut { get; set; }
        public int CurrentStock { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

}
