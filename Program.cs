using Microsoft.EntityFrameworkCore;
using School_Api_Project.DbContextDirectory;
using School_Api_Project.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Antiforgery
builder.Services.AddAntiforgery();

// Repository Inject
builder.Services.AddRepository();

var connectionString = builder.Configuration.GetConnectionString("Default_Data_Connection");

builder.Services.AddDbContext<MTSchool_DbContext>(opt => opt.UseSqlServer(connectionString));

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

app.MapGet("/", ()=> "Hello This is Minimal API.");

app.Run();
