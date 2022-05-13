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

        public void execute(Customer customer)
        {
            this.repository.Add(customer);
        }
    }
}
