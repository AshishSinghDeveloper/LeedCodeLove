using System;
namespace CorePlayground.LeedCodeL1
{
    public static class Subsequence
    {
        // Time: O(n) where n is length of target array
        // Space
        public static bool IsSubsequence(string s, string t)
        {
            if (s.Length == 0) return true;

            char[] source = s.ToCharArray();
            char[] target = t.ToCharArray();

            int sourceCount = 0;
            for (int i = 0; i < target.Length; i++)
            {
                if (source[sourceCount].Equals(target[i]))
                {
                    sourceCount++;
                    if (sourceCount == source.Length)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        
    }
}
