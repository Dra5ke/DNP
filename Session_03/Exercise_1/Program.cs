using System;
using System.Collections.Generic;

namespace Exercise_1
{
    class Program
    {
        static void Method<T>(ref Stack<T> stack, ref List<T> values)
        {
            foreach(T value in values)
            {
                stack.Push(value);
            }
        }
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);
            numbers.Add(6);

            Method(ref stack, ref numbers);
            System.Console.WriteLine(stack.Pop());
        }
    }
}
