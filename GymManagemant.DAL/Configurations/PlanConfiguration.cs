using GymManagment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace GymManagment.Configurations
{
    public class PlanConfiguration : IEntityTypeConfiguration<Plan>
    {
        public void Configure(EntityTypeBuilder<Plan> builder)
        {
            builder.Property(p => p.Name)
                .HasColumnType("varchar")
                .HasMaxLength(50);


            builder.Property(p => p.Description)
                .HasMaxLength(200);


            builder.Property(p => p.Price)
                .HasColumnType("decimal(10,2)");


            builder.Property(p => p.CreateAt)
                .HasDefaultValueSql("GETDATE()");

            builder.ToTable(tb =>
            {
                tb.HasCheckConstraint("PlanDurationCheck", "DurationDays between 1 and 365");
            });

        }

    }
}
