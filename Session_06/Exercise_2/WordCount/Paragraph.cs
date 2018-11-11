using System;

namespace WordCount
{
    public class Paragraph
    {
        public String Content { get; set; }

        public String LongestWord()
        {
            String[] words = Content.Split(null);

            int length = words[0].Length;
            String longestWord = "";
            foreach(String word in words)
            {
                if(length <= word.Length) longestWord = word;
                length = word.Length;
            }

            return longestWord;
        }
    }
}
