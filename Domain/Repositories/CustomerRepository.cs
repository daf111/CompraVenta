using CompraVenta.Domain.Entities;
using CompraVenta.Domain.ValueObjects;
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
        public Customer GetByEmail(Email id);
    }
}
