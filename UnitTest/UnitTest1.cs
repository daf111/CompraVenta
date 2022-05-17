using CompraVenta;
using CompraVenta.Domain.Entities;
using System;
using Xunit;

namespace UnitTest
{
    public class CustomerTests
    {
        [Fact]
        public void Customer_Age_ValidAge()
        {
            //Arrange
            Customer customer = new Customer(
                "Juan Perez",
                "jperez@gmail.com",
                DateTime.Parse("2000-01-01")
            );

            //Act
            int calculatedAge = customer.Age();

            //Assert
            Assert.Equal(22, calculatedAge);
        }

        [Theory]
        [InlineData("2000-01-01", 22)]
        [InlineData("1999-01-01", 23)]
        [InlineData("2001-01-01", 21)]
        public void Customer_CustomAge_ValidAge(string dateOfBirth, int expectedAge)
        {
            //Arrange
            Customer customer = new Customer(
                "Juan Perez",
                "jperez@gmail.com",
                DateTime.Parse(dateOfBirth)
            );

            //Act
            int calculatedAge = customer.Age();

            //Assert
            Assert.Equal(expectedAge, calculatedAge);
        }

        [Fact]
        public void Customer_WithInvalidAge_ThrowException()
        {
            //Arrange & Act
            Customer customer;
            Action act = () => customer = new Customer(
                "Juan Perez",
                "jperez@gmail.com",
                DateTime.Parse("2020-01-01")
            );

            //Assert
            Exception exception = Assert.Throws<Exception>(act);
        }
    }
}
