using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapecxTest.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Tel { get; set; }

        public List<User> IUser { get; set; }
        public List<Regs> IReg { get; set; }
    }
}