using System;
using System.Collections.Generic;
using System.Linq;

namespace CorePlayground
{
    public class EasyQuestion
    {
        public string ReverseStringAndWords(string inputString){
            return string.Join(" ", inputString.Split(' ').Select(x => new string(x.Reverse().ToArray())));
        }

        public string ReverseStringNotWords(string inputString)
        {
            var reverseString = string.Join(" ", inputString.Split(' ').Reverse());

            return reverseString;
        }

        public string ReverseWord(string inputWord)
        {
            return string.Join("",inputWord.Reverse()); 
        }

        public string ReverseStringNotWordLogically(string inputString)
        {
            string output = string.Empty;
            string[] splitStrings = inputString.Split(' ');
            for (int i = splitStrings.Length - 1; i > -1; i--)
            {
                output = output + splitStrings[i] + " ";
            }
            return output;
        }

        public string ReverseStringAndWordsLogically(string inputString)
        {
            var newString = string.Join("", inputString.ToCharArray().Reverse());
            return newString;
        }

        public void CountWord(string inputText)
        {
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            var words = inputText.Split(' ');
            foreach (var word in words)
            {
                if(wordCount.TryGetValue(word, out int currentCount))
                    wordCount[word] = currentCount + 1;
                else
                    wordCount.Add(word, 1);
            }
        }
    }
}