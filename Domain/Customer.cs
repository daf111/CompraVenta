﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenta.Domain
{
    public class Customer
    {
        private Name name;
        private Email email;
        private DateOfBirthOlderThan18Ages dateOfBirth;
        
        public Customer(string name, string email, DateTime dateOfBirth)
        {
            this.name = new Name(name);
            this.email = new Email(email);
            this.dateOfBirth = new DateOfBirthOlderThan18Ages(dateOfBirth);
        }

        public void changeEmail(string email)
        {
            this.email = new Email(email);
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