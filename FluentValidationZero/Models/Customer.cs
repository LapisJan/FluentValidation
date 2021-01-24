using FluentValidation;

namespace FluentValidationZero.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        
        //TODO : Add age for validate
    }

    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Firstname).NotEmpty();
            RuleFor(x => x.Lastname).NotEmpty();
            RuleFor(x => x.Address).NotEmpty();
            
            //TODO : Include some validation
        }
    }
    //TODO : Add CustomerAgeValidation 
}