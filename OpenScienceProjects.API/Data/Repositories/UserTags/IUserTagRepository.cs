using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.UserTags;

public interface IUserTagRepository
{
    Task InsertMany(IEnumerable<UserTag> userTags);
    Task<IList<Tag>> GetTagsByUserId(int userId);
}