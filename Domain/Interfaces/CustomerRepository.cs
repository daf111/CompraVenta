using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenta.Domain
{
    public interface CustomerRepository
    {
        public List<Customer> GetAll();
        public Customer GetById(Guid id);
        public void Add(Customer customer);
        public void Update(Customer customer);
        public void Delete(Guid id);
    }
}
