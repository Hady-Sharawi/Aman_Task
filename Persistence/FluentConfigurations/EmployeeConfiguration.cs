using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.FluentConfigurations;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasKey(o => o.Id);
        builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

        builder.Property(t => t.Age)
                .IsRequired()
                .HasMaxLength(3); // 999

        builder.HasOne(t => t.Department)
                .WithMany(t => t.Employees)
                .HasForeignKey(x=>x.DepartmentId);
    }
}
