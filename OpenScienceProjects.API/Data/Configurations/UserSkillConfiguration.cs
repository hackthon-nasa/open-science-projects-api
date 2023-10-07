using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Configurations;

public class UserSkillConfiguration : IEntityTypeConfiguration<UserSkill>
{
    public void Configure(EntityTypeBuilder<UserSkill> builder)
    {
        builder.ToTable("user_skill");

        builder.HasKey(x => new { x.UserId, x.SkillId });

        builder.Property(x => x.UserId).HasColumnName("user_id").IsRequired();
        builder.Property(x => x.SkillId).HasColumnName("skill_id").IsRequired();

        builder
            .HasOne(x => x.User)
            .WithMany(x => x.UserSkills)
            .HasForeignKey(x => x.UserId)
            .HasPrincipalKey(x => x.Id);

        builder
            .HasOne(x => x.Skill)
            .WithMany()
            .HasForeignKey(x => x.SkillId)
            .HasPrincipalKey(x => x.Id);
    }
}