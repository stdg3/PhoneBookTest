using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace sapecTestVAv2.Models
{
    public class SapecTestInitializer: DropCreateDatabaseIfModelChanges<PhBookContext>
    {
        protected override void Seed(PhBookContext context)
        {
            // like constr method
            List<User> users = new List<User>()
            {
                new User() {Name="Root", Username="System", Nickname="root", Pass="toor"},
                new User() {Name="Client", Username="System", Nickname="client", Pass="12"},
            };
            foreach (var item in users)
            {
                context.Users.Add(item);
            }
            context.SaveChanges();

            List<Contact> contacts = new List<Contact>()
            {
                new Contact() {Caller="dominos", Tel="12345678901", RegDate=DateTime.Now, UserId=1},
                new Contact() {Caller="pizza hot", Tel="12345678902", RegDate=DateTime.Now, UserId=2},
            };
            foreach (var item in contacts)
            {
                context.Contacts.Add(item);
            }
            context.SaveChanges();

            base.Seed(context);
        }
    }
}