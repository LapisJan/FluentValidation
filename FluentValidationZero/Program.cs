using System;
using FluentValidationZero.Models;

namespace FluentValidationZero
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer()
            {
                Id = 1,
                Firstname = "ploypailin",
                Lastname = "wongpichit",
                Address = "kingpower",
                //TODO : Add customer type
            };
            
            var results = new CustomerValidator().Validate(customer);
            
            if(!results.IsValid) {
                foreach(var failure in results.Errors) {
                    Console.WriteLine(failure.PropertyName + " Error : " + failure.ErrorMessage);
                }
            }
            else
            {
                Console.WriteLine("Data is valid.");
            }
        }
    }
}
