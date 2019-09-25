using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileBridgeAss.MenuItems.Data
{
    public class AgileBridgeContext : DbContext
    {
        public AgileBridgeContext()
        {
        }

        public AgileBridgeContext(DbContextOptions<AgileBridgeContext> options) : base(options)
        {

        }

        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<Role> Role { get; set; }
    }
}
