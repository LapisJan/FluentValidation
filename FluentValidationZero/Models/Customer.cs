using System.Collections.Generic;
using FluentValidation;

namespace FluentValidationZero.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        //TODO : Add list of address data type
        public string Addresses { get; set; }
    }

    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Firstname).NotEmpty();
            RuleFor(x => x.Lastname).NotEmpty();
            
            //TODO : Add chaining child for address
        }
    }
}