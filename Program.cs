using TuProject.Data;
using TuProject.Data.Repositories.Implementations;
using TuProject.Data.Repositories.Interfaces;
using TuProject.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MysqlDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("Default"),
        ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("Default"))));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<UserService>();


var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();


app.MapControllers();

//app.UseHttpsRedirection();


app.Run();