using CompraVenta.Domain;
using System;

namespace CompraVenta.Application
{
    public class CustomerCreator
    {
        private CustomerRepository repository;

        public CustomerCreator(CustomerRepository repository)
        {
            this.repository = repository;
        }

        public void execute(CustomerDTO customerDTO)
        {
            this.repository.Add(new Customer(customerDTO.name, customerDTO.email, customerDTO.dateOfBirth));
        }
    }
}
