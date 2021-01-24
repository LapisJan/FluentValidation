using FluentValidation;

namespace FluentValidationZero.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        //TODO : Add address data type
        public string Address { get; set; }
    }

    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Firstname).NotEmpty();
            RuleFor(x => x.Lastname).NotEmpty();
            RuleFor(x => x.Address).NotEmpty();
            
            //TODO : Add chaining child for address
        }
    }

    //TODO : Add address validator
}