using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SecondHand.Data;

namespace SecondHand.Controllers
{
    public class ObutevsController : Controller
    {
        private readonly AppDbContext _context;

        public ObutevsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allCevlji = _context.Obutevs.ToList();
            return View();
        }
    }
}
