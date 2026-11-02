using GymManagemant.DAL.Repositories.Interfaces;
using GymManagment.DbContexts;
using GymManagment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagment.DAL.Repositories.Classes
{
    public class PlanRepository : IPlanRepository
    {
        private readonly GymDbContect _context;
        public PlanRepository(GymDbContect context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Plan>> GetAllAsync(bool tracking = false, CancellationToken ct = default)
            => tracking ? await _context.Plans.ToListAsync(ct) : await _context.Plans.AsNoTracking().ToListAsync(ct);
             
        

        public Task<Plan?> GetByIdAsync(int id, CancellationToken ct = default)
            => _context.Plans.FirstOrDefaultAsync(p => p.Id == id, ct);

        public async Task AddAsync(Plan plan, CancellationToken ct = default)
        {
           await _context.Plans.AddAsync(plan, ct);
            await _context.SaveChangesAsync(ct);
        }

        public async Task UpdateAsync(Plan plan, CancellationToken ct = default)
        {
            _context.Plans.Update(plan);
            await _context.SaveChangesAsync(ct);
        }

        public async Task DeleteAsync(Plan plan, CancellationToken ct = default)
        {
            _context.Plans.Remove(plan);
            await _context.SaveChangesAsync(ct);
        }


    }
}
