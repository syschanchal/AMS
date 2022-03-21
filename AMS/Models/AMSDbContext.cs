using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AMS.Models
{
    public class AMSDbContext : DbContext
    {
        public AMSDbContext() : base("DBConnectionStr")
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}