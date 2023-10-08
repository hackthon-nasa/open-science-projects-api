using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Users;

public interface IUserRepository
{
    Task<User> GetUserListById(int id);
    Task InsertOne(User user);
}