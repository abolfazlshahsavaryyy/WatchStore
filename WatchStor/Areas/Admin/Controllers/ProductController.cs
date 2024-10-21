using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using WatchStor.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Threading.Tasks;

namespace WatchStor.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
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
        public async Task<IActionResult> Create(Product p, IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                // Get the file extension
                var fileExtension = Path.GetExtension(file.FileName);

                // Create a unique file name
                var uniqueFileName = Path.GetRandomFileName() + fileExtension;

                // Set the file path to wwwroot/images
                var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                // Ensure the folder exists
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                // Save the file
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                // Set the ImageURL property of the model to the file path
                p.ImageURL = "/images/" + uniqueFileName;
            }

            if (p == null)
            {
                return NotFound();
            }

            // Add the product to the database
            _context.Products.Add(p);

            // Save changes asynchronously
            await _context.SaveChangesAsync();

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
            if (find_product.ImageURL != null || find_product.ImageURL != "")
            {
                var ImagePath = Path.Combine(_webHostEnvironment.WebRootPath, find_product.ImageURL.TrimStart('/'));
                if (System.IO.File.Exists(ImagePath))
                {
                    System.IO.File.Delete(ImagePath);
                }
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
        [HttpGet]
        public async Task<IActionResult> EditImage(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var find_Product= await _context.Products.FindAsync(id);
            if (find_Product == null)
            {
                return NotFound();
            }

            return View(find_Product as Product);
        }
        public async Task<IActionResult> EditImage(Product p, IFormFile file)
        {
            if (p == null)
            {
                return NotFound();
            }
            if (file != null && file.Length > 0)
            {
                // Get the file extension
                var fileExtension = Path.GetExtension(file.FileName);

                // Create a unique file name
                var uniqueFileName = Path.GetRandomFileName() + fileExtension;

                // Set the file path to wwwroot/images
                var uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                var filePath = Path.Combine(uploadsFolder, uniqueFileName);

                // Ensure the folder exists
                if (!Directory.Exists(uploadsFolder))
                {
                    Directory.CreateDirectory(uploadsFolder);
                }

                // Save the file
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }

                // Set the ImageURL property of the model to the file path
                p.ImageURL = "/images/" + uniqueFileName;
                if (p == null)
                {
                    return NotFound();
                }
                if (p.Id != 0 || p.Id != null) {
                    var find_Product = await _context.Products.FindAsync(p.Id);
                    if(find_Product == null) { return NotFound(); }
                    find_Product.ImageURL= "/images/" + uniqueFileName;
                    
                }
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
