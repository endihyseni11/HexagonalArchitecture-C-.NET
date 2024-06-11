﻿using AppointEase.Domain.AppointEase.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointEase.Infrastructure
{
    public class DataContext : DbContext
    {
        private readonly ILogger<DataContext> _logger;
        private readonly IConfiguration _configuration;
        public DataContext(DbContextOptions<DataContext> options, ILogger<DataContext> logger, IConfiguration configuration) : base(options)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public DbSet<Person> Person { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source=.;Initial Catalog=HexagonalTest;Integrated Security=True; TrustServerCertificate=true;",
                b => b.MigrationsAssembly("AppointEase.Infrastructure")
            );
        }




    }
}
