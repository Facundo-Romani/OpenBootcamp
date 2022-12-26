using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.DataAccess;
using UniversityApiBackend.Service;
using UniversityApiBackend.Services;

var builder = WebApplication.CreateBuilder(args);

// Conexión a DB.
const string ConnectionDB = "DbUniversidad";
var connectionString = builder.Configuration.GetConnectionString(ConnectionDB);

// Add Context.
builder.Services.AddDbContext<DbContextUniversity>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<IUserServices, UserServices>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
