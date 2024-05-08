using API_Burger_J.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using API_Burger_J.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<API_Burger_JContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("API_Burger_JContext") ?? throw new InvalidOperationException("Connection string 'API_Burger_JContext' not found.")));

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

app.MapBurgerEndpoints();


app.Run();
