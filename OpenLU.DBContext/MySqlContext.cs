using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using OpenLU.Configuration;
namespace OpenLU.DBContext
{
    public class MySqlContext : BaseContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConfigurationProvider.GetConfig()["connectionString"]);
        }
    }
}
