using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraVenta.Domain.ValueObjects
{
    public class Email: StringValueObject
    {
        public Email(string email)
        {
            this.ShouldHaveValidEmailSyntax(email);
            this.value = email;
        }
        private void ShouldHaveValidEmailSyntax(string email)
        {
            if (new EmailAddressAttribute().IsValid(email) == false)
            {
                throw new Exception("The email has not valid syntax");
            }
        }
    }
}
