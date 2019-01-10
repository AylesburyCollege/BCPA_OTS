using BCPA_OTS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BCPA_OTS.DAL
{
    public class OTS_Context : DbContext
    {
        public OTS_Context() : base("DefaultConnection")
        {
        }

        public DbSet<Person> People { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        public DbSet<PaymentCard> PaymentCards { get; set; }

        public DbSet<Purchase> Purchases { get; set; }
    }
}