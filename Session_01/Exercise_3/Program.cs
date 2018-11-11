using System;

namespace Exercise_3
{
    class Person
    {
       public string Name;

       public void Introduce()
       {
           System.Console.WriteLine($"Hi, my name is {Name}!");
       }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Name = "fuccboi"
            };

            person.Introduce();
        }
    }
}
