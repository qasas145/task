using Microsoft.EntityFrameworkCore;

namespace Database.Models;
public class AppDbContext : DbContext {
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=Facebook;User Id= SA;Password=Hamada1020;TrustServerCertificate=True");
        base.OnConfiguring(optionsBuilder);
    }
    
    public DbSet<User> Users{get;set;}
    public DbSet<Post> Posts{get;set;}
    public DbSet<Role> Roles{get;set;}
    public DbSet<UserRoles> UserRoles{get;set;}
}