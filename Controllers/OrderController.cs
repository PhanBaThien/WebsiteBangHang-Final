using Microsoft.AspNetCore.Mvc;
using WebsiteBanHang_Final.Data;
using WebsiteBanHang_Final.Models;

namespace WebsiteBangHang_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase // Định nghĩa class OrderController kế thừa từ ControllerBase
    {
        private readonly AppDbContext _context; // Khai báo biến _context kiểu AppDbContext

        public OrderController(AppDbContext context) // Constructor của OrderController nhận tham số là AppDbContext
        {
            _context = context; // Gán giá trị tham số context cho biến _context
        }

        [HttpPost] // Định nghĩa phương thức HTTP POST
        public async Task<ActionResult<Order>> CreateOrder([FromBody] Order order) // Phương thức tạo đơn hàng mới
        {
            _context.Orders.Add(order); // Thêm đơn hàng vào database
            await _context.SaveChangesAsync(); // Lưu thay đổi vào database
            return CreatedAtAction(nameof(GetOrder), new { id = order.OrderID }, order); // Trả về kết quả tạo thành công với thông tin đơn hàng
        }

        [HttpGet("{id}")] // Định nghĩa phương thức HTTP GET với tham số id
        public async Task<ActionResult<Order>> GetOrder(int id) // Phương thức trả về đơn hàng theo id
        {
            var order = await _context.Orders.FindAsync(id); // Tìm đơn hàng theo id
            if (order == null) // Nếu không tìm thấy đơn hàng
            {
                return NotFound(); // Trả về kết quả không tìm thấy
            }
            return order; // Trả về đơn hàng tìm thấy
        }
    }

}
