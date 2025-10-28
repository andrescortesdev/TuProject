using Microsoft.EntityFrameworkCore;
using TuProject.Data.Entities;

namespace TuProject.Data;

public class MysqlDbContext : DbContext
{
    public MysqlDbContext(DbContextOptions<MysqlDbContext> options) : base(options)
    {
    }

    public DbSet<User> users { get; set; }
}