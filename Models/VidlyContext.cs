using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Vid_Learn.Models
{
    public class VidlyContext : DbContext
    {
        public VidlyContext()
        {

        }
        //Entities
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}