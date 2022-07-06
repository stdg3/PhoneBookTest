using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace sapecxTest.Models
{
    public class TestInitialaizer:DropCreateDatabaseIfModelChanges<PhContext>
    {
        protected override void Seed(PhContext context)
        {
            // test data sets at start or any changes in db via deff values like constructor method
            List<Contact> contacts = new List<Contact>()
            {
                new Contact() {Name="dominos", Tel="12"},
                new Contact() {Name="pizza hot", Tel="23"}
            };
            foreach (var item in contacts)
            {
                context.Contacts.Add(item);
            }
            context.SaveChanges();

            List<User> users = new List<User>()
            {
                new User() {UserNic="root", UserName="Root", UserUName="System", UserPass="toor"},
                new User() {UserNic="client", UserName="Client", UserUName="System", UserPass="12"},
            };
            foreach (var item in users)
            {
                context.Users.Add(item);
            }
            context.SaveChanges();

            List<Regs> regs = new List<Regs>()
            {
                new Regs() {RegDate=DateTime.Now, UserId=1, ContactId=1},
                new Regs() {RegDate=DateTime.Now, UserId=2, ContactId=2},
            };
            foreach (var item in regs)
            {
                context.xRegs.Add(item);
            }
            context.SaveChanges();

            base.Seed(context); 
        }
    }
}