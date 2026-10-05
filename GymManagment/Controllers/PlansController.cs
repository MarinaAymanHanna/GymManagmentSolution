using GymManagment.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagment.Controllers
{
    public class PlansController : Controller
    {
        private readonly GymDbContect _context = new GymDbContect();
        //Index Action
        public async Task<IActionResult> Index()
        {
            var plans =await _context.Plans.ToListAsync();
            return View(plans);
        }
        //Details Action
        //Get: /Plans/Details/{id}
        public async Task<IActionResult> Details(int id)
        {
            var plan = await _context.Plans.FirstOrDefaultAsync(p => p.Id == id);
            if (plan == null)
            {
                return RedirectToAction(nameof(Index));
            } 
            return View(plan);
        }

    }
}
