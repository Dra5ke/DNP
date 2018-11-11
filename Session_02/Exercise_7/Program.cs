using System;
using System.Collections.Generic;

namespace Exercise_7
{
    class Program
    {
        class Person
        {
            private String name;
            private int age;
            private String degree;

            public Person(String name, int age, String degree)
            {
                this.Name = name;
                this.age = age;
                this.degree = degree;
            }

            public string Name { get => name; set => name = value; }
        }

        static void Main(string[] args)
        {
            Person person1 = new Person("Dan", 19, "memeology");
            Person person2 = new Person("John", 25, "Biology");
            Person person3 = new Person("Felicia", 32, "Physics");

            Dictionary<String, Person> dict = new Dictionary<string, Person>();
            
            dict.Add("Meme Man", person1);
            dict.Add("smth", person2);
            dict.Add("bye", person3);

            Person retrieve = (Person)dict["bye"];
            System.Console.WriteLine(retrieve.Name);
        }
    }
}
