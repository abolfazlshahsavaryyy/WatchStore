using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using WatchStor.Models;

namespace WatchStor.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext _context;
        public OrderController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Order> orders=_context.Orders.ToList();
            return View(orders);
        }
        [HttpGet]
        public IActionResult Create(int id)
        {
            if (id == 0)  // Check for valid ID
            {
                return NotFound();
            }

            Product find_product = _context.Products.Find(id);
            if (find_product == null)
            {
                return NotFound();
            }

            // Create a new order object with the Product details
            Order order = new Order
            {
                WatchId = find_product.Id,
                Watch = find_product
            };

            // Return the Create view and pass the order model (without redirecting)
            return View(order);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Order o)
        {
            if (o == null)
            {
                return NotFound();
            }
            o.Id = 0;
            if (ModelState.IsValid)
            {
                _context.Orders.Add(o);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Order find_order_by_id=await _context.Orders.FindAsync(id);
            find_order_by_id.Watch = await _context.Products.FindAsync(find_order_by_id.WatchId);
            if(find_order_by_id == null)
            {
                return NotFound();
            }
            ViewData["title"] = "Test";
            return View(find_order_by_id);
        }
        
        [HttpPost]
        public async Task<IActionResult> Edit(Order o)
        {
            // Check if the order object is null
            if (o == null)
            {
                return NotFound(); // Return a 404 if the order is null
            }

            // Find the existing order in the database
            Order order = await _context.Orders.FindAsync(o.Id);
            if (order == null)
            {
                return NotFound(); // Return a 404 if the order is not found
            }

            // Update the order properties
            order.Number = o.Number;
            order.TimeOfPurchase = o.TimeOfPurchase;
            order.TimeOfSend = o.TimeOfSend;

            // Save the changes to the database
            await _context.SaveChangesAsync(); // Use SaveChangesAsync for asynchronous operation

            // Redirect to the Index action
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Order order_delet = await _context.Orders.FindAsync(id) ;
            order_delet.Watch = await _context.Products.FindAsync(order_delet.WatchId);
            if (order_delet == null)
            {
                return NotFound();
            }
            return View(order_delet);
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Order order)
        {
            if(order == null)
            {
                return NotFound();
            }
            if(!_context.Orders.Any(x=>x.Id == order.Id))
            {
                return NotFound();
            }
            _context.Orders.Remove(order);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Read(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Order find_order = await _context.Orders.FindAsync(id);
            find_order.Watch = await _context.Products.FindAsync(find_order.WatchId);
            if(find_order == null)
            {
                return NotFound();
            }
            return View(find_order);
        }
        public async Task<IActionResult> SendSelected(IEnumerable<int> selectedOrderIds)
        {
            return View(selectedOrderIds);
            
        }

    }
}
