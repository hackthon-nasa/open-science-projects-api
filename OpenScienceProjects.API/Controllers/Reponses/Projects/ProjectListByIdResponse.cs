using System.Text.Json.Serialization;

namespace OpenScienceProjects.API.Controllers.Reponses.Projects;

public class ProjectListByIdResponse
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("link")]
    public string Link { get; set; }

    [JsonPropertyName("organization_id")]
    public int OrganizationId { get; set; }

    [JsonPropertyName("tag_ids")]
    public List<int> TagIds { get; set; } = new List<int>();
}