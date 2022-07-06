using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapecTestVAv2.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Nickname { get; set; }
        public string Pass { get; set; }

        public List<Contact> Contacts { get; set; }
    }
}