using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Configurations;

public class ProjectUserConfiguration : IEntityTypeConfiguration<ProjectUser>
{
    public void Configure(EntityTypeBuilder<ProjectUser> builder)
    {
        builder.ToTable("project_user");

        builder.HasKey(x => new { x.ProjectId, x.UserId });

        builder.Property(x => x.ProjectId).HasColumnName("project_id").IsRequired();
        builder.Property(x => x.UserId).HasColumnName("user_id").IsRequired();
    }
}