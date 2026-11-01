using GymManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagemant.DAL.Repositories.Interfaces
{
    internal interface IPlanRepository
    {
        IEnumerable<Plan> GetAllAsync(bool tracking = false);
    }
}
