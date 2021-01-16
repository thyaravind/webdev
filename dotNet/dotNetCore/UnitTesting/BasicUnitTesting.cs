using System;
using System.IO;
using ClassLibrary;
using Xunit;
using Xunit.Sdk;

namespace UnitTesting
{
    public class BasicUnitTesting
    {
        [Fact]
        public void Person_tests_normal()
        {
            var aravind = new Person(){DateOfBirth = new DateTime(1995,4,10)};
            int expected = 25;
            int actual = aravind.CalculateAge();
            Assert.Equal(expected,actual);

        }


        [Fact]
        public void ValidNameShouldWork()
        {
            string name = "aravind";
            Assert.True(name.Length > 0);
        }
        
        [Fact]
        public void InValidShouldFail()
        {
            Assert.Throws<FileNotFoundException>(() => Calculator.ThrowsExceptionExample());
        }
        
        [Fact]
        public void InValidShouldFail2()
        {
            Assert.Throws<ArgumentException>("file_name",() => Calculator.ThrowsArgumentExceptionExample());
        }
        
         
        
        [Theory]
        [InlineData(2,4,0.5)]
        public void Person_tests_cases(double x, double y,double expected)
        {
            double actual = Calculator.Divide(x, y);
            Assert.Equal(expected,actual);

        }
        
        
        
        
    }
}
