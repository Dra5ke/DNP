using System;
using System.Collections.Generic;

namespace Exercise_3
{
    public static class MyExtensions
    {
        private static Random rnd = new Random();
        public static T RandomFromList<T>(this List<T> lst)
        {
            
            return lst[rnd.Next(lst.Count)];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
