using CompraVenta.Domain.Entities;
using CompraVenta.Domain.Repositories;
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

        public void Execute(Customer customer)
        {
            this.repository.Add(customer);
        }
    }
}
