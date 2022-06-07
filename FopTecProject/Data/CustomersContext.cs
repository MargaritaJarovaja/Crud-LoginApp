using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FopTecProject.Model;

namespace FopTecProject.Models
{
    public class CustomersContext : DbContext
    {
        public CustomersContext (DbContextOptions<CustomersContext> options)
            : base(options)
        {
        }

        public DbSet<FopTecProject.Model.Customers>? Customers { get; set; }
    }
}
