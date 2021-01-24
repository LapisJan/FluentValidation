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
                Firstname = "",
                Lastname = "wongpichit",
                Address = "kingpower"
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
            //Console.WriteLine("Hello World!");
        }
    }
}
