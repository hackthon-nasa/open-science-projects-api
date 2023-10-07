using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data;

public class DatabaseContext : DbContext
{
    public DbSet<Interest> Interests { get; set; }
    public DbSet<Organization> Organizations { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectTag> ProjectTags { get; set; }
    public DbSet<ProjectUser> ProjectUsers { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Tag> Tags { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserInterest> UserInterests { get; set; }
    public DbSet<UserSkill> UserSkills { get; set; }
    
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
    }
}