using Microsoft.EntityFrameworkCore;
using GymManagment.Models;
using System.Reflection;
namespace GymManagment.DbContexts
{
    public class GymDbContect: DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=db71180.public.databaseasp.net; Database=db71180; User Id=db71180; Password=z=3QLj-97Zm_; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;"
            );
        }

        public DbSet<Plan> Plans { get; set; }

    }
}
