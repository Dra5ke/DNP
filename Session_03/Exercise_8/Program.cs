using System;

namespace Exercise_8
{

    class Program
    {
        public delegate void Del(String message);
        public static void SayHello(String name)
        {
            System.Console.WriteLine("Hello " + name);
        }
        public static void SayGoodbye(String name)
        {
            System.Console.WriteLine("Goodbye " + name);
        }

        static void Main(string[] args)
        {
            Del notifier = SayHello;
            notifier += SayGoodbye;
            
            notifier("fuccboi");
        }
    }
}
