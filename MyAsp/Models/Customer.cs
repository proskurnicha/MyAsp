using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace MyAsp.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter customer Name")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool  IsSubscribedToNewsletters { get; set; }
        public virtual MembershipType MembershipType { get; set; }
        [Display(Name = " Membership Type")]
        public byte MembershipTypeId { get; set; }
        [Display(Name = "Date of Birth")]
        [Min18YearIfAMember]
        public DateTime? BirthDate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;

    }
}