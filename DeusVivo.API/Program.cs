using DeusVivo.Domain.Core.Interfaces.Repositorys;
using DeusVivo.Infrastructure.Data;
using DeusVivo.Infrastructure.Data.Repositorys;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRepositoryCargo, RepositoryCargo>();
builder.Services.AddScoped<IRepositoryCompanhia, RepositoryCompanhia>();
builder.Services.AddScoped<IRepositoryUsuario, RepositoryUsuario>();

builder.Services.AddDbContext<SqlContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnectionString"),
    new MySqlServerVersion(new Version(8, 0, 15)))
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
