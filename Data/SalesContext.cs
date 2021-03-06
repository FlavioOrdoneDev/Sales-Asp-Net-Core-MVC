﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sales_ASPNET_Core.Models;

namespace Sales_ASPNET_Core.Data
{
    public class SalesContext : DbContext
    {
        public SalesContext (DbContextOptions<SalesContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }
    }
}
