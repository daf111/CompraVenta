using CompraVenta.Application.DTO;
using CompraVenta.Domain.Entities;
using CompraVenta.Domain.Repositories;
using CompraVenta.Domain.ValueObjects;
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
            this.shouldNotExistsCustomerWithEmail(customerDTO.Email());

            this.repository.Add(
                Customer.CreateNewCustomer(
                    customerDTO.Name(),
                    customerDTO.Email(),
                    customerDTO.DateOfBirth()
                )
            );
        }

        private void shouldNotExistsCustomerWithEmail(string email)
        {
            Customer customer = this.repository.GetByEmail(
                new Email(email)
            );
            if (customer != null)
            {
                throw new Exception("This email is in use by another Customer");
            }
        }
    }
}
