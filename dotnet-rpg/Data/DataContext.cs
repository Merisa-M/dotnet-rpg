using dotnet_rpg.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {
        }

        public DbSet<Character> Characters { get; set;}
        public DbSet<User> Users { get; set;}
        public DbSet<Weapon> Weapons { get; set;}
        public DbSet<Skill> Skills { get; set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Damage = 20, Name = "Fireball" },
                new Skill { Id = 2, Damage = 40, Name = "Frenzy" },
                new Skill { Id = 3, Damage = 50, Name = "Blizzard" }
                );
        }
    }
}
