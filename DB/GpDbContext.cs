﻿using IntelligenceFarmer.tableDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntelligenceFarmer
{
    public class GpDbContext : DbContext 
    {
        public GpDbContext(DbContextOptions<GpDbContext> options) : base(options)
        {

        }
       
        public DbSet<Request> Requests { get; set; }
        public DbSet<hassan> table { get; set; }
        public DbSet<Users> user { get; set; }
        //public DbSet<Farms> farm { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
           .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
           .AddJsonFile("appsettings.json")
           .Build();

            // schoolSIMSConnection is the name of the key that
            // contains the has the connection string as the value
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyConnection"));
        }
    }
}
