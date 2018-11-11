using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = GetData().GetAwaiter().GetResult();
            System.Console.WriteLine(s);
        }

        static async Task<string> GetData()
        {
            HttpClient client = new HttpClient();
            
            System.Console.WriteLine("Fetching data...");

            var str = await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");

            return str;
        }
    }
}
