using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext with the correct connection string
builder.Services.AddDbContext<WeatherContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("WeatherDb")));

// Add controllers and views
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(name: "default", pattern: "{controller=Weather}/{action=Index}/{id?}");

app.Run();
