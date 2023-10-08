using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Users;

public interface IUserRepository
{
    Task<User> GetUserListById(int id);
    Task<User> GetUserListByName(string name);
    Task<User> GetUserListByEmail(string email);
    Task InsertOne(User user);
}