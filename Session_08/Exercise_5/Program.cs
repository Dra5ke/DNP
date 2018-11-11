using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = GetData(1).GetAwaiter().GetResult();
            System.Console.WriteLine(s);
        }

        static async Task<string> GetData(int id)
        {
            HttpClient client = new HttpClient();
            
            System.Console.WriteLine("Fetching data...");

            var str = await client.GetStringAsync($"https://localhost:5001/api/todo/{id}");

            return str;
        }
    }
}
