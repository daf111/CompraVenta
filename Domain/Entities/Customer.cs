using CompraVenta.Domain.Repositories;
using CompraVenta.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenta.Domain.Entities
{
    public class Customer
    {
        private Identity id;
        private Name name;
        private Email email;
        private DateOfBirthOlderThan18Ages dateOfBirth;

        public Customer(
            Guid id,
            string name,
            string email,
            DateTime dateOfBirth
        )
        {
            this.id = new Identity(id);
            this.name = new Name(name);
            this.email = new Email(email);
            this.dateOfBirth = new DateOfBirthOlderThan18Ages(dateOfBirth);
        }

        public static Customer CreateNewCustomer(
            string name,
            string email,
            DateTime dateOfBirth
        )
        {
            //Grabar en log cada vez que se crea un nuevo cliente
            return new Customer(Guid.NewGuid(), name, email, dateOfBirth);
        }

        public void changeEmail(string email)
        {
            this.email = new Email(email);
        }

        public Guid Id()
        {
            return this.id.Value();
        }
        public string Name()
        {
            return this.name.Value();
        }
        public string Email()
        {
            return this.email.Value();
        }
        public DateTime DateOfBirth()
        {
            return this.dateOfBirth.Value();
        }
        public string Presentation()
        {
            return "Hi, my name is " + this.Name() + " and my email is " + this.Email() + " and I am " + this.Age() + " years old";
        }
        public int Age()
        {
            return this.dateOfBirth.Age();
        }
    }
}
