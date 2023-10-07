using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Configurations;

public class UserInterestConfiguration : IEntityTypeConfiguration<UserInterest>
{
    public void Configure(EntityTypeBuilder<UserInterest> builder)
    {
        builder.ToTable("user_interest");

        builder.HasKey(x => new { x.UserId, x.InterestId });

        builder.Property(x => x.UserId).HasColumnName("user_id").IsRequired();
        builder.Property(x => x.InterestId).HasColumnName("interest_id").IsRequired();
    }
}