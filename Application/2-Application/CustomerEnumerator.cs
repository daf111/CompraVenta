using CompraVenta.Application.DTO;
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

        public List<CustomerDTO> Execute()
        {
            List<CustomerDTO> customersDTO = new List<CustomerDTO>();
            foreach (Customer actualCustomer in this.repository.GetAll())
            {
                customersDTO.Add(
                    new CustomerDTO(
                        actualCustomer.Name(),
                        actualCustomer.Email(),
                        actualCustomer.DateOfBirth()
                    )
                );
            }
            return customersDTO;
        }
    }
}
