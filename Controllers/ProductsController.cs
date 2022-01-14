using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ExamDotnet.Models;
using ExamDotnet.Data;

namespace ExamDotnet.Controllers {
    [Route("api/products")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AppDbContext _context;

        public ProductsController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Index()
        {
            IEnumerable<Product> products = _context.Products;
            return Ok(products);
        }

    }
}


