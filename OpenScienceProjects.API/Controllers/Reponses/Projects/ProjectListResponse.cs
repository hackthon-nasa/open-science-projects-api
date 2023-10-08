using System.Text.Json.Serialization;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Controllers.Reponses.Projects;

public class ProjectListResponse
{
    [JsonPropertyName("projects")]
    public IList<Project> Projects { get; set; }
}