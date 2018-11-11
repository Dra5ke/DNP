using System;
using System.Collections.Generic;

namespace Exercise_4
{

    class Animal : IComparable
    {
        private String type;
        private double weight;
        private int runSpeed;

        public Animal(String type, double weight, int runSpeed)
        {
            this.type = type;
            this.weight = weight;
            this.runSpeed = runSpeed;
        }

        public int CompareTo(object obj)
        {
            if(obj is Animal)
            {
                Animal animal = (Animal) obj;
                if(this.weight > animal.weight)
                    return 1;
                return -1;
            }
            return 0;
        }

        public override String ToString() => "A " + type + " weighs " + weight + "kg" + " and runs at a top speed of " + runSpeed + "km/h";
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();
            list.Add(new Animal("Lion", 185.6, 80));
            list.Add(new Animal("Cheetah", 60.1, 112));
            list.Add(new Animal("Leopard", 50, 88));
            list.Add(new Animal("Jaguar", 73.6, 81));
            list.Add(new Animal("Tiger", 243.9, 90));
            list.Add(new Animal("Antelope", 15, 80));
            list.Add(new Animal("Gazelle", 20, 97));
            list.Add(new Animal("Elephant", 5589.3, 25));
            list.Add(new Animal("Hyena", 45, 60));
            list.Add(new Animal("Hippo", 1500.9, 30));

            foreach(Animal animal in list)
            {
                System.Console.WriteLine(animal.ToString());
            }

            list.Sort();
            System.Console.WriteLine();
            System.Console.WriteLine("------------------");

            foreach(Animal animal in list)
            {
                System.Console.WriteLine(animal.ToString());
            }
        }
    }
}