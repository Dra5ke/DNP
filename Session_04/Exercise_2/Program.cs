using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Exercise_2
{
    [Serializable]
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFormatter formatter = new BinaryFormatter();
            using(Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write))
            {
            Person person = new Person(){FirstName = "fucc", LastName = "boi", Ssn = 12345};
            formatter.Serialize(stream, person);
            }
            using(Stream deserializeStream = new FileStream("MyFile.bin", FileMode.Open, FileAccess.Read))
            {
                Person newPerson = (Person) formatter.Deserialize(deserializeStream);
                System.Console.WriteLine(newPerson.FirstName + newPerson.LastName);
            }
        }
    }
}
