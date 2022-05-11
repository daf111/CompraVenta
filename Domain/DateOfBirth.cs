using CompraVenta.Transversal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenta.Domain
{
    public class DateOfBirthOlderThan18Ages
    {
        private DateTime value;
        public DateOfBirthOlderThan18Ages(DateTime dateOfBirth)
        {
            this.ShouldBeOlderThan18Ages(dateOfBirth);
            this.value = dateOfBirth;
        }

        private void ShouldBeOlderThan18Ages(DateTime dateOfBirth)
        {
            if (AgeCalculator.calculateYearsOldFromDate(dateOfBirth) < 18)
            {
                throw new Exception("The customer must be older than 18 ages");
            }
        }
        public DateTime Value()
        {
            return this.value;
        }
        public int Age()
        {
            return AgeCalculator.calculateYearsOldFromDate(this.value);
        }
    }
}
