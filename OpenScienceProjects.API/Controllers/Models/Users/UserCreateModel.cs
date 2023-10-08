using System.Text.Json.Serialization;

namespace OpenScienceProjects.API.Controllers.Models.Users;

public class UserCreateModel
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
    [JsonPropertyName("user_tags")]
    public List<int> UserTags { get; set; } = new List<int>();
}
