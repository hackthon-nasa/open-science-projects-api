#nullable enable
using System.Text.Json.Serialization;

namespace OpenScienceProjects.API.Controllers.Models;

public class UserTagsListModel
{
    [JsonPropertyName("tagIds")]
    public List<int>? TagIds { get; set; }
}