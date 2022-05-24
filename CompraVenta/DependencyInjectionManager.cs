using Castle.Windsor;
using CompraVenta.Application;
using CompraVenta.DataInfraestructure.Repositories;
using CompraVenta.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenta
{
    public class DependencyInjectionManager
    {
        private WindsorContainer container;
        public DependencyInjectionManager()
        {
            this.container = new WindsorContainer();

            //Register your types for instances:
            this.container.Register(Castle.MicroKernel.Registration.Component.For<CustomerCreator>());
            this.container.Register(Castle.MicroKernel.Registration.Component.For<CustomerEnumerator>());

            this.container.Register(Castle.MicroKernel.Registration.Component.For<CustomerRepository>().ImplementedBy<CustomerInMemoryRepository>());
        }
        public T Resolve<T>()
        {
            return this.container.Resolve<T>();
        }
    }
}
