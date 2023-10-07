using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Configurations;

public class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
{
    public void Configure(EntityTypeBuilder<Organization> builder)
    {
        builder.ToTable("organization");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id").IsRequired();
        builder.Property(x => x.Name).HasColumnName("name").IsRequired();
        builder.Property(x => x.Description).HasColumnName("description").IsRequired();
        builder.Property(x => x.Email).HasColumnName("email").IsRequired();
        builder.Property(x => x.Phone).HasColumnName("phone").IsRequired();
    }
}