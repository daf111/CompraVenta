
using CompraVenta.Application;
using CompraVenta.Domain;
using System;

namespace CompraVenta
{
    class Program
    {
        static void Main(string[] args)
        {
            var diManager = new DependencyInyectionManager();
            var customerCreator = diManager.Resolve<CustomerCreator>();
            var customerIndexer = diManager.Resolve<CustomerIndexer>();

            CustomerDTO customer = new CustomerDTO(
                "Juan Perez",
                "jperez@gmail.com",
                DateTime.Parse("2000-01-01")
            );
            customerCreator.execute(customer);

            CustomerDTO customer2 = new CustomerDTO(
                "Ana Martinez",
                "amartinez@gmail.com",
                DateTime.Parse("1995-01-01")
            );
            customerCreator.execute(customer2);

            foreach (CustomerDTO actualCustomer in customerIndexer.execute())
            {
                Console.WriteLine(actualCustomer.Presentation());
            }
        }
    }
}
