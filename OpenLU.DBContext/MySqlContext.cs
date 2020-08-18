using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenLU.DBContext
{
    public class MySqlContext : BaseContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=openlu;user id=lappn;password=admin;persistsecurityinfo=True;port=3306");
        }
    }
}
