using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapecPhBook.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Number { get; set; }
    }
}