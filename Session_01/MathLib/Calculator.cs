using System;

namespace MathLib
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int[] numbers)
        {
            int sum = 0;

            foreach(int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Multiply(int[] numbers)
        {
            int result = 1;
            foreach(int number in numbers)
            {
                result *= number;
            }
            return result;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public double Divide(int a, int b)
        {
            try{
                return a / b;
            }
            catch (DivideByZeroException e)
            {
                System.Console.WriteLine(e.StackTrace);
            }
            return -1;
        }
    }
}
