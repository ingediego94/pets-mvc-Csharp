using Microsoft.EntityFrameworkCore;
using practica_Mvc.Models;

namespace practica_Mvc.Data;

public class AppDbContext : DbContext
{
    // To create tables on DB:
    public DbSet<Client> clients { get; set; }
    public DbSet<Dog> dogs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // To storage the connection string of our db
        string db = "server=localhost;database=pets_db;user=root;password=Stauffemberg2%";
        
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseMySql(
                connectionString: db,
                MySqlServerVersion.AutoDetect(db)
            );
        }
    }
}