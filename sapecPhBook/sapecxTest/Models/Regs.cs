using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sapecxTest.Models
{
    public class Regs
    {
        public int Id { get; set; }
        //public int UserNo { get; set; }
        //public int ContactNo { get; set; }
        public DateTime RegDate { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}