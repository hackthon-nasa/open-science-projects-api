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

        builder
            .HasOne(x => x.Project)
            .WithMany(x => x.ProjectUsers)
            .HasForeignKey(x => x.ProjectId)
            .HasPrincipalKey(x => x.Id);

        builder
            .HasOne(x => x.User)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .HasPrincipalKey(x => x.Id);
    }
}