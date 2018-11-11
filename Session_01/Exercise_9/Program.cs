using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(StringUtility.SummarizeText(Console.ReadLine()));
        }
    }

    class StringUtility
    {
        public static String SummarizeText(String text)
        {
            if(text.Length > 20)
            {
                String trim = text.Substring(0, (int)(text.Length / 2));
                return trim + "...";
            }
            else return text;
        }
    }
}
