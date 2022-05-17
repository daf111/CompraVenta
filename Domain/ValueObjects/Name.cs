using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenta.Domain.ValueObjects
{
    public class Name: StringValueObject
    {
        public Name(string name)
        {
            this.ShouldHaveValidName(name);
            this.value = name;
        }
        private void ShouldHaveValidName(string name)
        {
            if (name.Length < 3 || name.Length > 50)
            {
                throw new Exception("The name must have between 3 and 50 characters");
            }
        }
    }
}
