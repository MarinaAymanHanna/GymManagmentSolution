using GymManagemant.DAL.Repositories.Interfaces;
using GymManagment.DAL.Repositories.Classes;
using GymManagment.DbContexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GymManagment.Controllers
{
    public class PlansController : Controller
    {
        //private readonly GymDbContect _context = new GymDbContect();
        private readonly IPlanRepository _PlanRepository;

        public PlansController(IPlanRepository planRepository)// Ask CLR to inject the PlanRepository instance into the controller constructor
        {
            _PlanRepository = planRepository;
        }


        //Index Action
        public async Task<IActionResult> Index(CancellationToken ct = default)
        {
           //var plans =await _context.Plans.ToListAsync();
            var plans = await _PlanRepository.GetAllAsync(ct: ct);
            return View(plans);
        }
        //Details Action
        //Get: /Plans/Details/{id}
        public async Task<IActionResult> Details(int id, CancellationToken ct = default)
        {
           //var plan = await _context.Plans.FirstOrDefaultAsync(p => p.Id == id);
            var plan = await _PlanRepository.GetByIdAsync(id, ct);
            if (plan == null)
            {
                return RedirectToAction(nameof(Index));
            } 
            return View(plan);
        }

    }
}
