using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    // public DbSet<Category> Categories { get; set; }
     public DbSet<Animal> Animal { get; set; }
     public DbSet<Type> Type { get; set; }
    
    public AnimalShelterContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}