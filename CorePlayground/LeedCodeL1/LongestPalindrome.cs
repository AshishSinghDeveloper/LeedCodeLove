using System.Collections.Generic;

namespace LeedCodeLove.LeedCodeL1
{
    public static class LongestPalindrome
    {
        //TC: O(n) | SC: O(n)
        public static int Palindrome(string s)
        {
            var input = s.ToCharArray();
            Dictionary<char, int> counter = new Dictionary<char, int>();
            int totalCount = 0;
            bool isOdd = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (!counter.ContainsKey(input[i]))
                {
                    counter.Add(input[i], 1);
                }
                else
                {
                    counter[input[i]] = counter[input[i]] + 1;
                }
            }            

            foreach (var item in counter.Values)
            {
                if ((item) % 2 == 0)
                {
                    totalCount += item;
                }
                else 
                {
                    totalCount += item - 1;
                    isOdd = true;
                }
            }

            return isOdd ? totalCount + 1 : totalCount;

        }
    }
}
