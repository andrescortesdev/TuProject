using TuProject.Data.Entities;
using TuProject.Data.Repositories.Interfaces;

namespace TuProject.Services;

public class UserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task<IEnumerable<User>> GetAllUsers()
    {
        return _userRepository.GetAllUsers();
    }

    public Task<User?> GetUserById(int id)
    {
        return _userRepository.GetUserById(id);
    }
}