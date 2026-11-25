using Interview.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Interview.Infrastructure.Persistence.Configurations
{
    public class EmployeeProfileConfiguration
        : IEntityTypeConfiguration<EmployeeProfile>
    {
        public void Configure(EntityTypeBuilder<EmployeeProfile> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Phone)
                .IsRequired()
                .HasMaxLength(20);

            builder.HasOne(p => p.employee)
                .WithOne(e => e.Profile)
                .HasForeignKey<EmployeeProfile>(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}