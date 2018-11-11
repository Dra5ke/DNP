using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = Console.ReadLine();

            char[] reverse = new char[name.Length];
            int i = 0;
            int n = name.Length;
            for(i = 0; i < n; i++)
            {
                reverse[i] = name[n - i - 1];
            }

            System.Console.Write(reverse);
        }
    }
}
