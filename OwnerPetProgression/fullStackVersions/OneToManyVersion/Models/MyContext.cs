#pragma warning disable CS8618

using Microsoft.EntityFrameworkCore;
namespace OneToManyVersion.Models;

public class MyContext : DbContext 
{    
    public MyContext(DbContextOptions options) : base(options) { }    
   
    public DbSet<User> Users { get; set; } 
    public DbSet<Owner> Owners { get; set; } 

    public DbSet<Pet> Pets { get; set; } 

}