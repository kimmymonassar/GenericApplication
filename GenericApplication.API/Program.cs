using GenericApplication.Infrastructure;
using GenericApplication.Infrastructure.Persistence;
using GenericApplication.Infrastructure.Persistence.Interface;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddDbContext<ItemDbContext>(opt => 
opt.UseNpgsql("Host=local_pgdb;Port=5432;Database=kimmyadm;Username=kimmyadm;Password=strongpw123"));
//"Host=127.0.0.1:5432;Database=kimmyadm;Username=kimmyadm;Password=strongpw123"

builder.Services.AddTransient<IItemRepository, ItemRepository>();


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
