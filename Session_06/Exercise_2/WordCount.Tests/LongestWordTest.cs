using System;
using Xunit;
using WordCount;

namespace WordCount.Tests
{
    public class LongestWordTest
    {
        [Fact]
        public void LongestWord_FirstWord_ShouldReturnFirstWord()
        {
            var para = CreateDefaultParagraph();
            para.Content = "VeryLongWordHere shorterword shortest";

            var actual = para.LongestWord();

            Assert.Equal("VeryLongWordHere", actual);
        }
        
        [Fact]
        public void LongestWord_ThirdWord_ShouldReturnTheThirdWord()
        {
            var para = CreateDefaultParagraph();
            para.Content = "This is longest word";

            var actual = para.LongestWord();

            Assert.Equal("longest", actual);
        }

        [Fact]
        public void LongestWord_MoreWordsAreTheLongest_ShouldReturnLastLongestWord()
        {
            var para = CreateDefaultParagraph();
            para.Content = "More than one word";

            var actual = para.LongestWord();

            Assert.Equal("word", actual);
        }

        public Paragraph CreateDefaultParagraph()
        {
            return new Paragraph() { Content = "" };
        }
    }
}
