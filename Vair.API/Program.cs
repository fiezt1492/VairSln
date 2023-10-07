using Microsoft.EntityFrameworkCore;
using Vair.API.Configurations;
using Vair.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddApiServices();
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddInfrastructureServices(builder.Configuration);

var app = builder.Build();

app.UseApiServices();

app.Run();
