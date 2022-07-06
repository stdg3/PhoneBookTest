using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapecxTest.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserNic { get; set; }
        public string UserName { get; set; }
        public string UserUName { get; set; }
        public string UserPass { get; set; }

        public List<Contact> IContact { get; set; }
        public List<Regs> IReg { get; set; }

    }
}