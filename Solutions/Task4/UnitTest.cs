using System;
using FluentAssertions;
using NUnit.Framework;

namespace Task4
{
    public class Tests
    {
        private Calculator _calculator;
        
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _calculator = new Calculator();
        }
       
        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _calculator.Dispose();
            _calculator = null;
        }
        
        

        [Test]
        public void Add_HappyPath()
        {
            const int expected = 10;
            
            int actual = _calculator.Add(5, 5);

            actual.Should().Be(expected);
        }
        
        [Test]
        public void Add_NegativePath_ThrowsOverflowException()
        {
            Func<int> func = () => _calculator.Add(Int32.MaxValue, 2);

            func.Should().Throw<OverflowException>();
        }
        
        [Test]
        public void Sub_HappyPath()
        {
            const int expected = 0;
            
            int actual = _calculator.Subtract(5, 5);

            actual.Should().Be(expected);
        }
        
        [Test]
        public void Sub_NegativePath_ThrowsOverflowException()
        {
            Func<int> func = () => _calculator.Subtract(Int32.MinValue, 2); 

            func.Should().Throw<OverflowException>();
        }
        
        [Test]
        [TestCase(5, 5, 25)]
        [TestCase(7, 3, 21)]
        [TestCase(2, 1, 2)]
        public void Mul_HappyPath(int a, int b, int expectedResult)
        {
            int actual = _calculator.Multiply(a, b);

            actual.Should().Be(expectedResult);
        }
        
        [Test]
        public void Mul_NegativePath_ThrowsOverflowException()
        {
            Func<int> func = () => _calculator.Multiply(Int32.MaxValue, 2); 

            func.Should().Throw<OverflowException>();
        }
        
        [Test]
        public void DivInt_HappyPath()
        {
            const int expected = 1;
            
            int actual = _calculator.Divide(5, 5);

            actual.Should().Be(expected);
        }
        
        [Test]
        public void DivInt_NegativePath_ThrowsArgumentException()
        {
            Func<int> func = () => _calculator.Divide(5, 0); 

            func.Should().Throw<ArgumentException>();
        }
        
        [Test]
        public void DivInt_NegativePath_ThrowsInvalidOperationException()
        {
            Func<int> func = () => _calculator.Divide(5, 2); 

            func.Should().Throw<InvalidOperationException>();
        }
        
        [Test]
        public void DivDouble_HappyPath()
        {
            const int expected = 2;
            
            double actual = _calculator.Divide(4.4, 2.2);

            actual.Should().Be(expected);
        }
        
        [Test]
        public void DivDouble_NegativePath_ThrowsArgumentException()
        {
            Func<double> func = () => _calculator.Divide(5.1236, 0); 

            func.Should().Throw<ArgumentException>();
        }
        
    }
}

