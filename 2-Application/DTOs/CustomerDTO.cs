using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenta.Application
{
    public class CustomerDTO
    {
        public string name;
        public string email;
        public DateTime dateOfBirth;
        public int age;

        public CustomerDTO(string name, string email, DateTime dateOfBirth)
        {
            this.name = name;
            this.email = email;
            this.dateOfBirth = dateOfBirth;
        }

        public CustomerDTO(string name, string email, DateTime dateOfBirth, int age): this(name, email, dateOfBirth)
        {
            this.age = age;
        }

        public string Presentation()
        {
            return "Hi, my name is " + this.name + " and my email is " + this.email + " and I am " + this.age + " years old";
        }
    }
}
