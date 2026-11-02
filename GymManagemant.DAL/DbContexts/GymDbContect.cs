using Microsoft.EntityFrameworkCore;
using GymManagment.Models;
using System.Reflection;
namespace GymManagment.DbContexts
{
    public class GymDbContect: DbContext
    {
        public GymDbContect(DbContextOptions<GymDbContect> options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Plan> Plans { get; set; }

    }
}
