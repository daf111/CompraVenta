using CompraVenta.Application.DTO;
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

        public void Execute(CustomerDTO customerDTO)
        {
            this.repository.Add(
                Customer.CreateNewCustomer(
                    customerDTO.Name(),
                    customerDTO.Email(),
                    customerDTO.DateOfBirth()
                )
            );
        }
    }
}
