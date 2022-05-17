using CompraVenta.Domain.Entities;
using CompraVenta.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace CompraVenta.Application
{
    public class CustomerEnumerator
    {
        private CustomerRepository repository;

        public CustomerEnumerator(CustomerRepository repository)
        {
            this.repository = repository;
        }

        public List<Customer> Execute()
        {
            return this.repository.GetAll();
        }
    }
}
