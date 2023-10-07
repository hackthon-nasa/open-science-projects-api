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
        builder.Property(x => x.Name).HasColumnName("name").HasColumnType("varchar(100)").IsRequired();
        builder.Property(x => x.Email).HasColumnName("email").HasColumnType("varchar(100)").IsRequired();
        builder.Property(x => x.Password).HasColumnName("password").HasColumnType("varchar(50)").IsRequired();
        builder.Property(x => x.BirthDate).HasColumnName("birth_date").HasColumnType("date").IsRequired();
        builder.Property(x => x.Description).HasColumnName("description").HasColumnType("varchar(250)").IsRequired();
    }
}