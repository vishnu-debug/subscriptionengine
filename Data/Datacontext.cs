using Microsoft.EntityFrameworkCore;
using SubscriptionEngine.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubscriptionEngine.Data
{
    public class Datacontext:DbContext
    {
        public Datacontext(DbContextOptions options):base(options)
        {


        }
        public DbSet<Customerdetails> Customerdetails { get; set; }
        public DbSet<Plandetails> Plandetails { get; set; }

    }
}
