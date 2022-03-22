using DeusVivo.API.Auth;
using DeusVivo.Domain.Core.Interfaces.Repositories;
using DeusVivo.Domain.Core.Interfaces.Services;
using DeusVivo.Domain.Entitys;
using DeusVivo.Domain.Services;
using DeusVivo.Infrastructure.Data;
using DeusVivo.Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var key = Encoding.ASCII.GetBytes(Settings.Secret);

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(x =>
    {
        x.RequireHttpsMetadata = false;
        x.SaveToken = true;
        x.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(key),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SqlContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("MySqlConnectionString"),
    new MySqlServerVersion(new Version(8, 0, 15)))
);

builder.Services.AddScoped<IRepositoryBase<CargoEO>, RepositoryBase<CargoEO>>();
builder.Services.AddScoped<IRepositoryBase<UsuarioEO>, RepositoryBase<UsuarioEO>>();
builder.Services.AddTransient<IServiceCargo, ServiceCargo>();
builder.Services.AddTransient<IServiceUsuario, ServiceUsuario>();

builder.Services.AddTransient<IServiceToken, ServiceToken>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
