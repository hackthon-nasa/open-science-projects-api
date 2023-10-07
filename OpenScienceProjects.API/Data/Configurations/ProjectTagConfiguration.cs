using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Configurations;

public class ProjectTagConfiguration : IEntityTypeConfiguration<ProjectTag>
{
    public void Configure(EntityTypeBuilder<ProjectTag> builder)
    {
        builder.ToTable("project_tag");

        builder.HasKey(x => new { x.ProjectId, x.TagId });

        builder.Property(x => x.ProjectId).HasColumnName("project_id").IsRequired();
        builder.Property(x => x.TagId).HasColumnName("tag_id").IsRequired();

        builder
            .HasOne(x => x.Project)
            .WithMany(x => x.ProjectTags)
            .HasForeignKey(x => x.ProjectId)
            .HasPrincipalKey(x => x.Id);

        builder
            .HasOne(x => x.Tag)
            .WithMany()
            .HasForeignKey(x => x.TagId)
            .HasPrincipalKey(x => x.Id);
    }
}