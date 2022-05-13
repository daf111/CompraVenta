using CompraVenta.Domain;
using System;
using System.Collections.Generic;

namespace CompraVenta.Application
{
    public class CustomerIndexer
    {
        private CustomerRepository repository;

        public CustomerIndexer(CustomerRepository repository)
        {
            this.repository = repository;
        }

        public List<CustomerDTO> execute()
        {
            List<CustomerDTO> customersDTOs = new List<CustomerDTO>();
            foreach (Customer customer in this.repository.GetAll())
            {
                customersDTOs.Add(new CustomerDTO(customer.Name(), customer.Email(), customer.DateOfBirth(), customer.Age()));
            }
            return customersDTOs;
        }
    }
}
