namespace OpenScienceProjects.API.Entities;

public class Project
{
    public int Id { get; set; }
    public string Description { get; set; }
    public int OrganizationId { get; set; }
    public virtual Organization Organization { get; set; }
    public virtual IList<ProjectTag> ProjectTags { get; set; }
}