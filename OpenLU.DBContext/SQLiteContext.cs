using System;
using System.Collections.Generic;
using System.Text;
using OpenLU.Configuration;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.IO;

namespace OpenLU.DBContext
{
    public class SQLiteContext : BaseContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseSqlite($"Data Source={ConfigurationProvider.GetConfig()["connectionString"] + "\\cdclient.fdb"}" );
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Could not find configuration file");
            }

        }
    }
}
