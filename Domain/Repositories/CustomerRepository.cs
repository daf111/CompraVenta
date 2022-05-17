using CompraVenta.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenta.Domain.Repositories
{
    public interface CustomerRepository
    {
        public void Add(Customer customer);
        public List<Customer> GetAll();
        public Customer GetById(Guid id);
    }
}
