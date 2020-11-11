using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using OpenLU.Models;
namespace OpenLU.DBContext
{
    public abstract class BaseContext : DbContext, IAsyncDisposable
    {
        public DbSet<GameModels.User> Users { get; set; }
        public DbSet<GameModels.Character> Characters { get; set; }
        public DbSet<GameModels.InventoryItem> InventoryItems { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameModels.User>().HasIndex(u => u.Username).IsUnique();
            modelBuilder.Entity<GameModels.User>().HasIndex(u => u.Password).IsUnique();
        }
    }
}
