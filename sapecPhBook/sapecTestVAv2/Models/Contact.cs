using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapecTestVAv2.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Caller { get; set; }
        public string Tel { get; set; }
        public DateTime RegDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}