using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Text;
using Bitzen_LeninAguiar_InfraStructure.Entity;
using System.Configuration;
using System.Reflection;
using static Bitzen_LeninAguiar_InfraStructure.Util.Util;
//using System.Data.Entity;
//using Microsoft.EntityFrameworkCore;
//using MySQL.Data.EntityFrameworkCore.Extensions;

namespace Bitzen_LeninAguiar_InfraStructure.Database
{
    public class DBBitzenContext : DbContext
    {
        private string connectionString;

        public DBBitzenContext()
        {
            //connectionString = ConfigurationManager.AppSettings["DataBaseConnection"].ToString();
            connectionString = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location).AppSettings.Settings[Connections.DataBaseConnection.ToString()].Value;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connectionString);
        }

        public DbSet<Login> Login { get; set; }
        public DbSet<Vehicle> Vehicle { get; set; }

        public DbSet<Supply> Supply { get; set; }

    }
}
