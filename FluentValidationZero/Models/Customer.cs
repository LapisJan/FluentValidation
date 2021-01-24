using FluentValidation;

namespace FluentValidationZero.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
    }

    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            //TODO : Override 
            // 1. Message : text, placeholder
            // 2. Name
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Firstname).NotEmpty();
            RuleFor(x => x.Lastname).NotEmpty();
            RuleFor(x => x.Address).NotEmpty();
        }
    }
}