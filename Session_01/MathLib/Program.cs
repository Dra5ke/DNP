using System;

namespace MathLib
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            System.Console.WriteLine(calculator.Add(5, 5));

            System.Console.WriteLine(calculator.Divide(-5, 2));

            int[] numbers = new int[5] {3, 5, 6, 7, 9};

            System.Console.WriteLine(calculator.Add(numbers));

            System.Console.WriteLine(calculator.Multiply(13, 27));

            System.Console.WriteLine(calculator.Subtract(10, 5));

        }
    }
}
