using GymManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagemant.DAL.Repositories.Interfaces
{
    public interface IPlanRepository
    {
        Task<IEnumerable<Plan>> GetAllAsync(bool tracking = false, CancellationToken ct = default);
        Task<Plan?> GetByIdAsync(int id, CancellationToken ct = default);       
        
        Task AddAsync(Plan plan, CancellationToken ct = default);
        Task UpdateAsync(Plan plan, CancellationToken ct = default);
        Task DeleteAsync(Plan plan, CancellationToken ct = default);

    }
}
