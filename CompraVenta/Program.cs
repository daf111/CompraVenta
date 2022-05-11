using CompraVenta.Domain;
using System;
using System.Collections.Generic;

namespace CompraVenta
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();

            Customer customer = new Customer(
                "Juan Perez",
                "jperez@gmail.com",
                DateTime.Parse("2000-01-01")
            );
            customers.Add(customer);

            Customer customer2 = new Customer(
                "Ana Martinez",
                "amartinez@gmail.com",
                DateTime.Parse("1995-01-01")
            );
            customers.Add(customer2);

            foreach (Customer actualCustomer in customers)
            {
                Console.WriteLine(actualCustomer.Presentation());
            }
        }
    }
}
