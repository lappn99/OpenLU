using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OpenLU.Models;
using OpenLU.Configuration;
using System.IO;

namespace OpenLU.DBContext
{
    public class BaseContext : DbContext, IAsyncDisposable
    {
        public DbSet<GameModels.User> Users { get; set; }
        public DbSet<GameModels.Character> Characters { get; set; }
        public DbSet<GameModels.InventoryItem> InventoryItems { get; set; }

        public DbSet<GameModels.UserSession> UserSessions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameModels.User>().HasIndex(u => u.Username).IsUnique();
            modelBuilder.Entity<GameModels.User>().HasIndex(u => u.Password).IsUnique();
            

            modelBuilder.Entity<GameModels.UserSession>().Property(s => s.Id).ValueGeneratedNever();

            modelBuilder.Entity<GameModels.User>().HasData(new GameModels.User() { Password = "lego!", Username = "MrSnrub",Id = 1 }) ;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                


                string provider = ConfigurationProvider.GetConfig()["provider"];
                string connectionString = ConfigurationProvider.GetConfig()["connectionString"];
                switch (provider)
                {
                    case "sqlite":
                        optionsBuilder.UseSqlite(connectionString);
                        break;
                    case "mysql":
                        optionsBuilder.UseMySql(connectionString);
                        break;
                    default:
                        optionsBuilder.UseSqlite(connectionString);
                        break;
                }
            }


            catch (FileNotFoundException)
            {
                Console.WriteLine("Could not find configuration file");
            }

        }
    }
}
