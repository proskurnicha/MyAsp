using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Core.Objects;

namespace MyAsp.Models
{
    public class Min18YearIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            if (customer.MembershipTypeId == Customer.PayAsYouGo || customer.MembershipTypeId == Customer.Unknown)
                return ValidationResult.Success;

            if (customer.BirthDate == null)
                return new ValidationResult("Please enter a BirthDate");

            var age = DateTime.Now.Year - customer.BirthDate.Value.Year;

            if (age >= 18)
                return ValidationResult.Success;
            return new ValidationResult("Customer shoud be at least 18 yeard ols to go on a membership");
        }
    }
}