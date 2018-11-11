using System;
using System.IO;
using System.Threading.Tasks;

namespace Exercise_3
{
    class Reader
    {
        string fileName;
        public string Data { get; set; }

        public Reader(string fn) { fileName = fn; }

        public void Read()
        {
            FileStream s = new FileStream(fileName, FileMode.Open);
            StreamReader r = new StreamReader(s);
            Data = r.ReadToEnd();
            r.Close();
            s.Close();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Reader file1 = new Reader("File1.txt");
            Reader file2 = new Reader("File2.txt");

            Task readFile1 = new Task( () => file1.Read());
            Task readFile2 = new Task( () => file2.Read());

            readFile1.Start();
            readFile2.Start();

            readFile1.Wait();
            
            String message = file1.Data.Equals(file2.Data) ? "The content is the same" : "The content is different";
            System.Console.WriteLine(message);

        }
    }
}
