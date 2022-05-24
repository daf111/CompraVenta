using CompraVenta.Application;
using CompraVenta.Application.DTO;
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
            DependencyInjectionManager diManager = new DependencyInjectionManager();
            CustomerCreator customerCreator = diManager.Resolve<CustomerCreator>();
            CustomerEnumerator customerEnumerator = diManager.Resolve<CustomerEnumerator>();

            CustomerDTO customer = new CustomerDTO(
                "Juan Perez",
                "jperez@gmail.com",
                DateTime.Parse("2000-01-01")
            );
            customerCreator.Execute(customer);

            CustomerDTO customer2 = new CustomerDTO(
                "Ana Martinez",
                "amartinez@gmail.com",
                DateTime.Parse("1995-01-01")
            );
            customerCreator.Execute(customer2);

            foreach (CustomerDTO actualCustomer in customerEnumerator.Execute())
            {
                Console.WriteLine(actualCustomer.Presentation());
            }
        }
    }
}
