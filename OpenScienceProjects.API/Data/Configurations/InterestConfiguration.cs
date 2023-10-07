using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Configurations;

public class InterestConfiguration : IEntityTypeConfiguration<Interest>
{
    public void Configure(EntityTypeBuilder<Interest> builder)
    {
        builder.ToTable("interest");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id").IsRequired();
        builder.Property(x => x.Description).HasColumnName("description").IsRequired();
    }
}