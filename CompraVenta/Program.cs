
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

            Customer customer = new Customer(
                "Juan Perez",
                "jperez@gmail.com",
                DateTime.Parse("2000-01-01")
            );
            customerCreator.execute(customer);

            Customer customer2 = new Customer(
                "Ana Martinez",
                "amartinez@gmail.com",
                DateTime.Parse("1995-01-01")
            );
            customerCreator.execute(customer2);

            foreach (Customer actualCustomer in customerIndexer.execute())
            {
                Console.WriteLine(actualCustomer.Presentation());
            }
        }
    }
}
