using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using OpenLU.Configuration;
using System.IO;

namespace OpenLU.DBContext
{
    public class MySqlContext : BaseContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                optionsBuilder.UseMySql(ConfigurationProvider.GetConfig()["connectionString"]);
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Could not find configuration file");
            }
            
        }
    }
}
