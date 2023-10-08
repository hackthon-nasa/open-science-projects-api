using System.Text.Json.Serialization;

namespace OpenScienceProjects.API.Controllers.Reponses.Users;

public class UserListByNameResponse
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("email")]
    public string Email { get; set; }
    [JsonPropertyName("password")]
    public string Password { get; set; }
    [JsonPropertyName("birth_date")]
    public DateTime BirthDate { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
}