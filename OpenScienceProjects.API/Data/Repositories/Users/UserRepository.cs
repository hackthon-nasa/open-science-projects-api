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

    public Task<User> GetUserListById(int id)
    {
        return _entity
            .Where(x => x.Id == id)
            .Select(x => new User
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                BirthDate = x.BirthDate,
                Password = x.Password,
                Description = x.Description,
            }).FirstOrDefaultAsync();
    }

    public Task<User> GetUserListByName(string name)
    {
        return _entity
            .Where(x => x.Name == name)
            .Select(x => new User
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                BirthDate = x.BirthDate,
                Password = x.Password,
                Description = x.Description,
            }).FirstOrDefaultAsync();
    }

    public Task<User> GetUserListByEmail(string email)
    {
        return _entity
            .Where(x => x.Email == email)
            .Select(x => new User
            {
                Id = x.Id,
                Name = x.Name,
                Email = x.Email,
                BirthDate = x.BirthDate,
                Password = x.Password,
                Description = x.Description,
            }).FirstOrDefaultAsync();
    }
}