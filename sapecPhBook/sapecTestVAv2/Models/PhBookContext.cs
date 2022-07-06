using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sapecTestVAv2.Models
{
    public class PhBookContext:DbContext
    {
        public PhBookContext():base("sapecVAtestv2")
        {
            // constructor method
            Database.SetInitializer(new SapecTestInitializer());
        }
        // adding tbls to db
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}