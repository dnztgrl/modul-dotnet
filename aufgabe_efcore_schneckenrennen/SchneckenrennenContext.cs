using Microsoft.EntityFrameworkCore;

namespace aufgabe_efcore_schneckenrennen;

public class SchneckenrennenContext : DbContext
{
    // Einziges DBSet 
    public DbSet<Wettbuero> Wettbueros { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=schneckenrennen.db");
    }
}   