using CompraVenta.Application;
using CompraVenta.DataInfraestructure.Repositories;
using CompraVenta.Domain.Entities;
using CompraVenta.Domain.Repositories;
using System;

/*
 * TODO
 * 1- No utilizar entidades desde Presentación
 * 2- No permitir emails duplicados para distintos Customers
 * 3- Definir si las interfaces de repositorios pertenece a Domain o Application
 * 4- Realizar pruebas unitarias (Domain, Aplications, Repositories)
 * 5- Motor de inyección de dependencia
 */

namespace CompraVenta
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerRepository repository = new CustomerInMemoryRepository();
            CustomerCreator customerCreator = new CustomerCreator(repository);
            CustomerEnumerator customerEnumerator = new CustomerEnumerator(repository);

            Customer customer = Customer.CreateNewCustomer(
                "Juan Perez",
                "jperez@gmail.com",
                DateTime.Parse("2000-01-01")
            );
            customerCreator.Execute(customer);

            Customer customer2 = Customer.CreateNewCustomer(
                "Ana Martinez",
                "amartinez@gmail.com",
                DateTime.Parse("1995-01-01")
            );
            customerCreator.Execute(customer);

            foreach (Customer actualCustomer in customerEnumerator.Execute())
            {
                Console.WriteLine(actualCustomer.Presentation());
            }
        }
    }
}
