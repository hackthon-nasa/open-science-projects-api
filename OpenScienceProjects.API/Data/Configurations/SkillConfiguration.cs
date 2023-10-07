using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Configurations;

public class SkillConfiguration : IEntityTypeConfiguration<Skill>
{
    public void Configure(EntityTypeBuilder<Skill> builder)
    {
        builder.ToTable("skill");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id").IsRequired();
        builder.Property(x => x.Description).HasColumnName("description").IsRequired();
    }
}