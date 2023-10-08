using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Configurations;

public class CommentConfiguration : IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder.ToTable("comment");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id).HasColumnName("id").IsRequired();
        builder.Property(x => x.Description).HasColumnName("description").HasColumnType("varchar(250").IsRequired();
        builder.Property(x => x.DiscussionId).HasColumnName("discussion_id").IsRequired();

        builder
            .HasOne(x => x.Discussion)
            .WithMany(x => x.DiscussionComments)
            .HasForeignKey(x => x.DiscussionId)
            .HasPrincipalKey(x => x.Id);
    }
}