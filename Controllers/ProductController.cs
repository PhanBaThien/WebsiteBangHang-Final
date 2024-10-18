using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebsiteBanHang_Final.Data; // Sử dụng namespace WebsiteBanHang_Final.Data
using WebsiteBanHang_Final.Models; // Sử dụng namespace WebsiteBanHang_Final.Models

namespace WebsiteBangHang_Final.Controllers // Định nghĩa namespace cho controller
{
    [Route("api/[controller]")] // Định nghĩa route cho API controller
    [ApiController] // Đánh dấu class này là một API controller
    public class ProductController : ControllerBase // Định nghĩa class ProductController kế thừa từ ControllerBase
    {
        private readonly AppDbContext _context; // Khai báo biến _context kiểu AppDbContext

        public ProductController(AppDbContext context) // Constructor của ProductController nhận tham số là AppDbContext
        {
            _context = context; // Gán giá trị tham số context cho biến _context
        }

        [HttpGet] // Định nghĩa phương thức HTTP GET
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts() // Phương thức trả về danh sách sản phẩm
        {
            return await _context.Products.ToListAsync(); // Trả về danh sách sản phẩm từ database
        }

        [HttpGet("{id}")] // Định nghĩa phương thức HTTP GET với tham số id
        public async Task<ActionResult<Product>> GetProduct(int id) // Phương thức trả về sản phẩm theo id
        {
            var product = await _context.Products.FindAsync(id); // Tìm sản phẩm theo id
            if (product == null) // Nếu không tìm thấy sản phẩm
            {
                return NotFound(); // Trả về kết quả không tìm thấy
            }
            return product; // Trả về sản phẩm tìm thấy
        }
    }

}