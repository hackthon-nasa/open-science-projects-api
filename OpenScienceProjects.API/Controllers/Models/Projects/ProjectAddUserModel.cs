using System.Text.Json.Serialization;

namespace OpenScienceProjects.API.Controllers.Models.Projects;

public class ProjectAddUserModel
{
    [JsonPropertyName("project_id")]
    public int ProjectId { get; set; }

    [JsonPropertyName("user_id")]
    public int UserId { get; set; }
}