namespace OpenScienceProjects.API.Entities;

public class Organization
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string OfficialSite { get; set; }
    public string Email { get; set; }
    public int Phone { get; set; }
    public virtual IList<Project> Projects { get; set; }
}