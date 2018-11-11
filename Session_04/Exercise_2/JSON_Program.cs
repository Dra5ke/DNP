using System;
using Newtonsoft.Json;
namespace Exercise_2
{
    [Serializable]
    class JsonPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Ssn { get; set; }
    }

   class JsonProgram
    {
        static void Main(string[] args)
        {
            JsonPerson person = new JsonPerson(){FirstName = "fucc", LastName = "boi", Ssn = 12345};
            String serialize = JsonConvert.SerializeObject(person);

            System.Console.WriteLine(serialize);

            JsonPerson deserializedPerson = JsonConvert.DeserializeObject<JsonPerson>(serialize);
            System.Console.WriteLine(deserializedPerson.FirstName + deserializedPerson.LastName);
        }
    }
}