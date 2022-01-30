using System;

namespace Task4___NUnit
{
    public class Calculator : IDisposable
    {
        
        
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
        
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("b is 0");
            }

            if (a % b != 0)
            {
                throw new InvalidOperationException("result is not an integer");
            }
            
            return a / b;
        }
        
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new ArgumentException();
            }
            
            return a / b;
        }

        public void Dispose()
        {
            Console.WriteLine("disposed!");
        }
    }
}