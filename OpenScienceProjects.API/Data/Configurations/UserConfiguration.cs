using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("user");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id").IsRequired();
        builder.Property(x => x.Name).HasColumnName("name").IsRequired();
        builder.Property(x => x.Email).HasColumnName("email").IsRequired();
        builder.Property(x => x.Password).HasColumnName("password").IsRequired();
        builder.Property(x => x.BirthDate).HasColumnName("birth_date").IsRequired();
        builder.Property(x => x.Description).HasColumnName("description").IsRequired();
    }
}