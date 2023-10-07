using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Controllers.Reponses;

public class ProjectListResponse
{
    public IList<Project> Projects { get; set; }
}