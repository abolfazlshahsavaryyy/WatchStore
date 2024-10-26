using Microsoft.AspNetCore.Mvc;
using WatchStor.Models;

namespace WatchStor.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class PayController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PayController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            List<Pay> pays=_context.pays.ToList();
            return View(pays);
        }
        public IActionResult LoadCreate(IEnumerable<int> selectedOrderIds)
        {
            
            int sum = 0;
            string title = "";
            foreach(int orderId in selectedOrderIds)
            {
                title += "[";
                Order o=_context.Orders.Find(orderId);
                Product p =_context.Products.Find(o.WatchId);
                decimal price = o.Number * p.Price;
                sum += (int)price;
                title+=("Watch name :"+ p.Name);
                title += ("  Number Watch: "+o.Number);
                title += " ";
                title += "]";
            }
            
            Pay pay = new Pay
            {
                price=sum,Title=title,Time=DateTime.Now,
            };

            return View("Create",pay);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Pay p)
        {
            if(ModelState.IsValid)
            {
                _context.pays.Add(p);
                _context.SaveChangesAsync();
            }
            return View("StatusPage");

        }
        public async Task<IActionResult> Read(int? id)
        {
            if(id == null)
            {
                return NotFound();

            }
            Pay pay=_context.pays.Find(id);
            if(pay == null)
            {
                return NotFound();
            }
            return View(pay);
        }
    }
}
