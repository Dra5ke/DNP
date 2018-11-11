using System;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            if(a < b)
            System.Console.Write(b);
            else
            System.Console.Write(a);
        }
    }
}
