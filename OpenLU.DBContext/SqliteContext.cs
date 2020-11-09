using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OpenLU.Configuration;

namespace OpenLU.DBContext
{
    public class SqliteContext : BaseContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlite(ConfigurationProvider.GetConfig()["connectionString"]);

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Could not find configuration file");
            }

        }

    }
}
