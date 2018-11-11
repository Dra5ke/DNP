using System;
using System.Collections;

namespace Exercise_6
{
    class Program
    {
        class Schedule
        {
            private Hashtable ht = new Hashtable();

            public void Add(DateTime time, String courseName) => ht.Add(time, courseName);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
