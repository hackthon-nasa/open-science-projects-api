using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Configurations;

public class UserTagConfiguration : IEntityTypeConfiguration<UserTag>
{
    public void Configure(EntityTypeBuilder<UserTag> builder)
    {
        builder.ToTable("user_tag");

        builder.HasKey(x => new { x.UserId, x.TagId });

        builder.Property(x => x.UserId).HasColumnName("user_id").IsRequired();
        builder.Property(x => x.TagId).HasColumnName("tag_id").IsRequired();

        builder
            .HasOne(x => x.User)
            .WithMany(x => x.UserTags)
            .HasForeignKey(x => x.UserId)
            .HasPrincipalKey(x => x.Id);

        builder
            .HasOne(x => x.Tag)
            .WithMany()
            .HasForeignKey(x => x.UserId)
            .HasPrincipalKey(x => x.Id);
    }
}