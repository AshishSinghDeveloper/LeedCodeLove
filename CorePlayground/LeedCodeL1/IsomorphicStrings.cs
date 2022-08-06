using System;
using System.Collections;
using System.Collections.Generic;

namespace CorePlayground.LeedCodeL1
{
    public static class IsomorphicStrings
    {
        public static bool IsIsomorphic(string s, string t)
        {
            Hashtable correspondingValues = new Hashtable();
            HashSet<char> usedChar = new HashSet<char>();
            char[] KeyArray = s.ToCharArray();
            char[] valueArray = t.ToCharArray();
            for (int i = 0; i < KeyArray.Length; i++)
            {
                if (correspondingValues.Contains(KeyArray[i]))
                {
                    if (!correspondingValues[KeyArray[i]].Equals(valueArray[i]))
                    {
                        return false;
                    }
                }
                else
                {
                    if (usedChar.Contains(valueArray[i]))
                    {
                        return false;
                    }
                    correspondingValues.Add(KeyArray[i], valueArray[i]);
                    usedChar.Add(valueArray[i]);
                }
            }
            return true;
        }
    }
}
