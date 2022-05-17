using CompraVenta.Domain.Entities;
using CompraVenta.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenta.DataInfraestructure.Repositories
{
    public class CustomerInMemoryRepository : CustomerRepository
    {
        private List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            this.customers.Add(customer);
        }
        public List<Customer> GetAll()
        {
            return this.customers;
        }
        public Customer GetById(Guid id)
        {
            return this.customers.Find(customer => customer.Id() == id);
        }
    }
}
