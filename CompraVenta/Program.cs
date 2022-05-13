using CompraVenta.Application;
using CompraVenta.Domain;
using CompraVenta.Infraestructure;
using System;
using System.Collections.Generic;

namespace CompraVenta
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRepository repository = new CustomerInMemoryRepository();
            CustomerCreator customerCreator = new CustomerCreator(repository);

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

            foreach (Customer actualCustomer in repository.GetAll())
            {
                Console.WriteLine(actualCustomer.Presentation());
            }
        }
    }
}
