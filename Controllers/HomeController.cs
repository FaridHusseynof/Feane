using System.Diagnostics;
using Feane.Data;
using Feane.Models;
using Microsoft.AspNetCore.Mvc;

namespace Feane.Controllers
{
    public class HomeController : Controller
    { 
        private FeaneDbContext _context { get; }
        public HomeController(FeaneDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.products.Where(c => !c.IsDeleted));
        }

    }
}
