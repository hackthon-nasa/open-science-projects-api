using System.Text.Json.Serialization;

namespace OpenScienceProjects.API.Controllers.Models.Organizations;

public class OrganizationCreateModel
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("official_site")]
    public string OfficialSite { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("phone")]
    public int Phone { get; set; }
}