using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyAsp.Models;

namespace MyAsp.Dtos
{
    public class CustomerDto
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter customer Name")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletters { get; set; }
        public byte MembershipTypeId { get; set; }

        public MembershopTypeDtos  MembershipType { get; set; }
//        [Min18YearIfAMember]
        public DateTime? BirthDate { get; set; }

    }
}