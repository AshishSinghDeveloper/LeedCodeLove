using System;
using System.Collections;

namespace LeedCodeLove.LeedCodeL1
{
    public static class LongestRepeatingCharacterReplacement
    {
        public static int CharacterReplacement(string s, int k)
        {
            var count = new Hashtable();
            int maxf = 0;
            int left = 0;
            var sChar = s.ToCharArray();
            int result = 0;

            for (int right = 0; right < sChar.Length; right++)
            {
                if (count.ContainsKey(sChar[right]))
                {
                    count[sChar[right]] = (int)count[sChar[right]] + 1;
                }
                else
                {
                    count.Add(sChar[right], 1);
                }

                maxf = Math.Max(maxf, (int)count[sChar[right]]);

                while ((right - left + 1) - maxf > k) // right -left + 1 is size of the window
                {
                    count[sChar[left]] = (int)count[sChar[left]] - 1;
                    left++;
                }

                result = Math.Max(result, right - left + 1);
            }
            return result;
        }
    }
}
