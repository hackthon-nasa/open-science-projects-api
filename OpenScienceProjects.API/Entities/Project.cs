namespace OpenScienceProjects.API.Entities;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Link { get; set; }
    public int OrganizationId { get; set; }
    public virtual Organization Organization { get; set; }
    public virtual IList<ProjectTag> ProjectTags { get; set; }
    public virtual IList<ProjectUser> ProjectUsers { get; set; }
    public virtual IList<Discussion> ProjectDiscussions { get; set; }
}