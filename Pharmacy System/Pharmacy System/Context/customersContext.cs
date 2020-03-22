using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Pharmacy_System.Models;


namespace Pharmacy_System.Context
{
    public class customersContext : DbContext
    {
        public DbSet<Customer> customer { get; set; }
    }
}