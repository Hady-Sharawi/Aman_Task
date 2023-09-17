using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Persistence.FluentConfigurations;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.HasKey(o => o.Id);
        builder.Property(t => t.DepName)
                .IsRequired()
                .HasMaxLength(100);

        builder.HasMany(t => t.Employees)
                .WithOne(t => t.Department)
                .HasForeignKey(x => x.DepartmentId);
    }
}
