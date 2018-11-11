using System;
using System.Collections.Generic;
using System.IO;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(var sr = new StreamReader("file.txt"))
                {
                    string line;
                    List<string> words = new List<string>();

                    while((line = sr.ReadLine()) != null)
                    {
                        words.Add(line);
                        System.Console.WriteLine(line);
                    }
                    System.Console.WriteLine("------------");
                    int length = words[0].Length;
                    string longestWord = "";
                    foreach(string word in words)
                    {
                        longestWord = (length < word.Length) ? word : null;
                    }
                    System.Console.WriteLine($"The longest word is {longestWord}");
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine("The file could not be read:");
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
