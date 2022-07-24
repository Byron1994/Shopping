using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping.Data;

namespace Shopping.Controllers
{
    public class PruebaController : Controller
    {

        private readonly DataContext _context;

        public PruebaController(DataContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Countries.Where(a=>a.Name== "ECUADORS").Include("ECU").ToListAsync());
        }
    }
}
