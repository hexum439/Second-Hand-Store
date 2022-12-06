using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SecondHand.Data;

namespace SecondHand.Controllers
{
    public class OblacilasController : Controller
    {
        private readonly AppDbContext _context;

        public OblacilasController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Oblacilas.ToList();
            return View(data);
        }
    }
}
