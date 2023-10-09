using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.UserTags;

public class UserTagRepository : IUserTagRepository
{
    private readonly DatabaseContext _context;
    private readonly DbSet<UserTag> _entity;

    public UserTagRepository(DatabaseContext context)
    {
        _context = context;
        _entity = _context.Set<UserTag>();
    }

    public async Task InsertMany(IEnumerable<UserTag> userTags)
    {
        await _entity.AddRangeAsync(userTags);
        await _context.SaveChangesAsync();
    }

    public async Task<IList<Tag>> GetTagsByUserId(int userId)
    {
        return await (
            from userTag in _entity
            join tag in _context.Tags on userTag.TagId equals tag.Id
            where userTag.UserId == userId
            select tag
        ).ToListAsync();
    }
}