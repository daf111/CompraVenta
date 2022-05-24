using CompraVenta.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenta.Application.DTO
{
    public class CustomerDTO
    {
        private string name;
        private string email;
        private DateTime dateOfBirth;

        public CustomerDTO(string name, string email, DateTime dateOfBirth)
        {
            this.name = name;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
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
        public int Age()
        {
            return AgeCalculator.calculateYearsOldFromDate(this.DateOfBirth());
        }

        public string Presentation()
        {
            return "Hi, my name is " + this.Name() + " and my email is " + this.Email() + " and I am " + this.Age() + " years old";
        }
    }
}
