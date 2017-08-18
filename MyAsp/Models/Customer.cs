using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAsp.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool  IsSubscribedToNewsletters { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

    }
}