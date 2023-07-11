using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrasctructure.Configuration;

public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {
        builder.HasMany(i=>i.Department)
            .WithOne(p=>p.Employee);
        builder.HasMany(p => p.Job)
            .WithOne(p=>p.Employee);
    }
}