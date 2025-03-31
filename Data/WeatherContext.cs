using Microsoft.EntityFrameworkCore;

public class WeatherContext : DbContext
{
    public WeatherContext(DbContextOptions<WeatherContext> options) : base(options) { }

    public DbSet<Weather> Weathers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Weather>().HasData(
            new Weather { Id = 1, City = "London", Temperature = "15", Condition = "Cloudy", Date = DateTime.Now.AddDays(-1) },
            new Weather { Id = 2, City = "New York", Temperature = "22", Condition = "Sunny", Date = DateTime.Now.AddDays(-2) },
            new Weather { Id = 3, City = "Tokyo", Temperature = "18", Condition = "Rainy", Date = DateTime.Now.AddDays(-3) }
        );
    }
}
