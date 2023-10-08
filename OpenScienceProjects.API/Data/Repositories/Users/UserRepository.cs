using Microsoft.EntityFrameworkCore;
using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Users;

public class UserRepository : IUserRepository
{
    private readonly DatabaseContext _context;
    private readonly DbSet<User> _entity;

    public UserRepository(DatabaseContext context)
    {
        _context = context;
        _entity = _context.Set<User>();
    }

    public async Task InsertOne(User user)
    {
        await _entity.AddAsync(user);
        await _context.SaveChangesAsync();
    }
}