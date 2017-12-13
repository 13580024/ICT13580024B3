using ICT13580024B3.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ICT13580024B3.Api.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) :base(options)
        {

        }
    }
}
