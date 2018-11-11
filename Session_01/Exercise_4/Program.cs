using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            for(i = 0; i <= 100; i+=2)
            {
                System.Console.Write(i + " ");
            }
            System.Console.WriteLine();
            i = 1;
            while(i < 100)
            {
                System.Console.Write(i + " ");
                i+=2;
            }
        }
    }
}
