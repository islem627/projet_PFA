using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using app_back_.Models;
using app_back_.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();

// Register services for dependency injection
builder.Services.AddTransient<IClientService, ClientService>();
builder.Services.AddTransient<ILivreurService, LivreurService>();
builder.Services.AddTransient<IRestaurantService, RestaurantService>();
builder.Services.AddTransient<ILoginService, LoginService>();
builder.Services.AddTransient<ILogoutService, LogoutService>();
builder.Services.AddTransient<IEtatCommandeService, EtatCommandeService>();
builder.Services.AddTransient<IUserManagementService, UserManagementService>();

// Swagger/OpenAPI configuration
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

// Apply CORS policy
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
