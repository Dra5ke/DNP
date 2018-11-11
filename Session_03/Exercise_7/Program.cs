using System;

namespace Exercise_7
{
    class Calculator
    {
        public int Add(params int[] numbers)
        {
            int sum = 0;
            foreach(int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            int[] stuffToAdd = new int[]{5, 6, 7, 9, 23};
            System.Console.WriteLine(calc.Add(stuffToAdd));
            System.Console.WriteLine(calc.Add(1, 6, 10));
        }
    }
}
