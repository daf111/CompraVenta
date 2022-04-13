using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenta
{
    public class Customer
    {
        private string name;
        private string email;
        private DateTime dateOfBirth;
        
        public Customer(string name, string email, DateTime dateOfBirth)
        {
            this.ShouldHaveValidName(name);

            this.ShouldHaveValidEmailSyntax(email);

            this.ShouldBeOlderThan18Ages(dateOfBirth);

            this.name = name;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
        }

        private void ShouldHaveValidName(string name)
        {
            if (name.Length < 3 || name.Length > 50)
            {
                throw new Exception("The name must have between 3 and 50 characters");
            }
        }
        private void ShouldHaveValidEmailSyntax(string email)
        {
            if (new EmailAddressAttribute().IsValid(email) == false)
            {
                throw new Exception("The email has not valid syntax");
            }
        }

        private void ShouldBeOlderThan18Ages(DateTime dateOfBirth)
        {
            if (AgeCalculator.calculateYearsOldFromDate(dateOfBirth) < 18)
            {
                throw new Exception("The customer must be older than 18 ages");
            }
        }

        public string Name()
        {
            return this.name;
        }
        public string Email()
        {
            return this.email;
        }
        public DateTime DateOfBirth()
        {
            return this.dateOfBirth;
        }

        public string Presentation()
        {
            return "Hi, my name is " + this.Name() + " and my email is " + this.Email() + " and I am " + this.Age() + " years old";
        }
        public int Age()
        {
            return AgeCalculator.calculateYearsOldFromDate(this.dateOfBirth);
        }
    }
}
