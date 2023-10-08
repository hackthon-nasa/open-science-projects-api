using OpenScienceProjects.API.Entities;

namespace OpenScienceProjects.API.Data.Repositories.Users;

public interface IUserRepository
{
    Task InsertOne(User user);
}