using CompraVenta.Application;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public List<Dictionary<string, string>> Get()
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

            List<Dictionary<string, string>> list = new List<Dictionary<string, string>>();
            Dictionary<string, string> dictionary;
            foreach (CustomerDTO actualCustomer in customerIndexer.execute())
            {
                dictionary = new Dictionary<string, string>();
                dictionary.Add("name", actualCustomer.name);
                dictionary.Add("email", actualCustomer.email);
                dictionary.Add("birthDate", actualCustomer.dateOfBirth.ToString());
                list.Add(dictionary);
            }

            return list;
        }
    }
}
