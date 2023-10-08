using System.Text.Json.Serialization;

namespace OpenScienceProjects.API.Controllers.Reponses.Organizations;

public class OrganizationListTagsByIdResponse
{
    [JsonPropertyName("tags")]
    public IList<OrganizationListTagsResponse> Tags { get; set; }

    public class OrganizationListTagsResponse
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}