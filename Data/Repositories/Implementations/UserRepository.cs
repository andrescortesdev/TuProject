using Microsoft.EntityFrameworkCore;
using TuProject.Data.Entities;
using TuProject.Data.Repositories.Interfaces;

namespace TuProject.Data.Repositories.Implementations;

public class UserRepository : IUserRepository
{
    private readonly MysqlDbContext _context;

    public UserRepository(MysqlDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<User>> GetAllUsers() => await _context.users.ToListAsync();


    public async Task<User?> GetUserById(int id)
    {
        return await _context.users.FindAsync(id);
    }

    public async Task AddUser(User user)
    {
        _context.users.Add(user);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateUser(User user)
    {
        _context.users.Update(user);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteUserById(int id)
    {
        var user = await _context.users.FindAsync(id);
        if (user != null)
        {
            _context.users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}