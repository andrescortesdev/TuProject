using TuProject.Data.Entities;

namespace TuProject.Data.Repositories.Interfaces;

public interface IUserRepository
{
    Task<IEnumerable<User>> GetAllUsers();
    Task<User?> GetUserById(int id);
    Task AddUser(User user);
    Task UpdateUser(User user);
    Task DeleteUserById(int id);
}