using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Webapis.Models;

namespace Webapis.Data
{
    public class WebapisContext : DbContext
    {
        public WebapisContext (DbContextOptions<WebapisContext> options)
            : base(options)
        {
        }

        public DbSet<Webapis.Models.Employees> Employees { get; set; }
    }
}
