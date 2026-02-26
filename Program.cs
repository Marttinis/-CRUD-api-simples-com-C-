using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ProjetoAPI.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ProjetoAPIContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ProjetoAPIContext") ?? throw new InvalidOperationException("Connection string 'ProjetoAPIContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

//String de conexão com o Banco de Dados
var connectionString = builder.Configuration.GetConnectionString("ProjetoAPIContext");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
