using System.Text.Json.Serialization;

namespace OpenScienceProjects.API.Controllers.Reponses.Organizations;

public class OrganizationListByIdResponse
{
    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("location")]
    public string Location { get; set; }

    [JsonPropertyName("official_site")]
    public string OfficialSite { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("phone")]
    public int Phone { get; set; }
}