using Microsoft.AspNetCore.Mvc;
using WatchStor.Models;

namespace WatchStor.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> allProduct=_context.Products.ToList();
            return View(allProduct);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            if (p == null)
            {
                return NotFound();
            }
            _context.Products.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return BadRequest();
            }
            var product = _context.Products.Find(id);
            if (product == null) 
            {
                return NotFound();
            }

            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Product p)
        {
            if (p == null)
            {
                return BadRequest();
            }

            // Find the product by its ID
            Product? existingProduct = _context.Products.Find(p.Id);

            if (existingProduct == null)
            {
                return NotFound();
            }

            // Update properties directly
            existingProduct.Name = p.Name;
            existingProduct.Brand = p.Brand;
            existingProduct.Price = p.Price;
            existingProduct.Gender = p.Gender;
            existingProduct.WatchType = p.WatchType;

            // Save changes to the database
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
        [HttpPost]
        public IActionResult Delete(Product p)
        {
            if (p == null)
            {
                return BadRequest();
            }
            Product? find_product = _context.Products.Find(p.Id);
            if (find_product == null)
            {
                return NotFound();
            }
            try
            {
                _context.Products.Remove(find_product);

            }
            catch
            {
              
            }
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Read(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
