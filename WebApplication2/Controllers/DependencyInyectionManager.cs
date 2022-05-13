using Castle.Windsor;
using CompraVenta.Application;
using CompraVenta.Domain;
using CompraVenta.Infraestructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class DependencyInyectionManager
    {
        private WindsorContainer container;

        public DependencyInyectionManager()
        {
            this.container = new WindsorContainer();

            // Register your types, for instance:
            this.container.Register(Castle.MicroKernel.Registration.Component.For<CustomerCreator>());
            this.container.Register(Castle.MicroKernel.Registration.Component.For<CustomerIndexer>());
            this.container.Register(Castle.MicroKernel.Registration.Component.For<CustomerRepository>().ImplementedBy<CustomerInMemoryRepository>());
        }

        public T Resolve<T>()
        {
            return this.container.Resolve<T>();
        }
    }
}
