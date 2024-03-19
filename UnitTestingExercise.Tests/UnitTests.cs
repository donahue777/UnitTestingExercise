using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            Calculator calcy = new Calculator();

            int actual = calcy.Add(num1, num2, num3);

            Assert.Equal(expected, actual);

            //Arrange
            // create a Calculator object
            

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual

            //Assert
                //Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(11, 7, 4)]//Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            Calculator calcy = new Calculator();

            int actual = calcy.Subtract(minuend, subtrhend);

            Assert.Equal(expected, actual);

            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData(7, 8, 56)]//Add test data <-------
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            Calculator calcy = new Calculator();

            int actual = calcy.Multiply(num1, num2);

            Assert.Equal(expected, actual);

            //Arrange

            //Act

            //Assert

        }

        [Theory]
        [InlineData(21, 3, 7)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            Calculator calcy = new Calculator();

            int actual = calcy.Divide(num1, num2);

            Assert.Equal(expected, actual);
            //Arrange

            //Act

            //Assert

        }

    }
}
