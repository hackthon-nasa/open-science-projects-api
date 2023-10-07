using System.Text.Json.Serialization;

namespace OpenScienceProjects.API.Controllers.Models;

public class ProjectCreateModel
{
    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("organization_id")]
    public int OrganizationId { get; set; }

    [JsonPropertyName("tag_ids")]
    public List<int> TagIds { get; set; } = new List<int>();
}