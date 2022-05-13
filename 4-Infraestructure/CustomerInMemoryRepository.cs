using CompraVenta.Domain;
using System;
using System.Collections.Generic;

namespace CompraVenta.Infraestructure
{
    public class CustomerInMemoryRepository: CustomerRepository
    {
        private List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {

        }

        public void Add(Customer customer)
        {
            this.customers.Add(customer);
        }

        public void Delete(Guid id)
        {
            this.customers.RemoveAt(this.customers.IndexOf(this.GetById(id)));
        }

        public List<Customer> GetAll()
        {
            return this.customers;
        }

        public Customer GetById(Guid id)
        {
            return this.customers.Find(customer => customer.Id() == id);
        }

        public void Update(Customer customer)
        {
            this.customers[this.customers.IndexOf(this.GetById(customer.Id()))] = customer;
        }
    }
}
