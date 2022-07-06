using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace sapecxTest.Models
{
    public class PhContext: DbContext
    {
        public PhContext():base("sapecVAtest")
        {
            Database.SetInitializer(new TestInitialaizer());
        }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Regs> xRegs { get; set; }

    }
}