using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        private IEnumerable<object> actual;

        [Theory]
        [InlineData(1, 3, 5, 8)]
        [InlineData(12, 15, 25, 52)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            //Arrange

            var test = new UnitTestMethods();

            //Act

            var actual = test.Add(num1, num2, num3);

            //Assert

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(10, 2, 8)]
        [InlineData(7, 2, 5)]
        public void Subtract(int minuend, int subtrhend, int expected)
        {
            //Arrange
            var test2 = new UnitTestMethods();

            //Act
            var actual = test2.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(6, 6, 36)]
        [InlineData(5, 8, 40)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(18, 3, 6)]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();

            //Act
            var actual = test.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Money()
        {
            //Arrange
            var expected = 'h';
            var tester = new UnitTestMethods();
            //Act
            var actual = tester.ReturnH(); 

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Bank()
        {
            //Arrange
            var expected = 'b';
            var tester = new UnitTestMethods();

            //Act
            var actual = tester.ReturnH();
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
