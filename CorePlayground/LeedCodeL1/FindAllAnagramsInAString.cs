using System;
using System.Collections;
using System.Collections.Generic;

namespace LeedCodeLove.LeedCodeL1
{
    public static class FindAllAnagramsInAString
    {
        public static IList<int> FindAnagramsTimeLimitIssue(string s, string p)
        {
            if (p.Length > s.Length) return new List<int>();
            var pChar = p.ToCharArray();
            var sChar = s.ToCharArray();
            var result = new List<int>();
            var pCount = new Hashtable();
            var sCount = new Hashtable();
            int start = 0;
            int end = pChar.Length - 1;

            for(int i = 0; i < pChar.Length; i++)
            {
                if (pCount.ContainsKey(pChar[i]))
                {
                    pCount[pChar[i]] = (int)pCount[pChar[i]] + 1;
                }
                else
                {
                    pCount.Add(pChar[i], 1);
                }
                
            }

            while(start < sChar.Length && end < sChar.Length)
            {                
                for(int i = start; i <= end; i++)
                {
                    if (sCount.ContainsKey(sChar[i]))
                    {
                        sCount[sChar[i]] = (int)sCount[sChar[i]] + 1;
                    }
                    else
                    {
                        sCount.Add(sChar[i], 1);
                    }
                }
                if (CompareHashtable(sCount, pCount))
                {
                    result.Add(start);
                }
                
                start++;
                end++;
                sCount = new Hashtable();                
            }

            return result;
        }

        private static bool CompareHashtable(Hashtable tableA, Hashtable tableB)
        {
            foreach(DictionaryEntry a in tableA)
            {
                if (tableB.ContainsKey(a.Key))
                {
                    int bValue = (int)tableB[a.Key];
                    if (bValue != (int)a.Value)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public static IList<int> FindAnagramsWorking(string s, string p)
        {
            if (p.Length > s.Length) return new List<int>();
            var pChar = p.ToCharArray();
            var sChar = s.ToCharArray();
            var result = new List<int>();
            var pCount = new Hashtable();
            var sCount = new Hashtable();
            

            for (int i = 0; i < pChar.Length; i++)
            {
                if (pCount.ContainsKey(pChar[i]))
                {
                    pCount[pChar[i]] = (int)pCount[pChar[i]] + 1;
                }
                else
                {
                    pCount.Add(pChar[i], 1);
                }

                if(sCount.ContainsKey(sChar[i]))
                {
                    sCount[sChar[i]] = (int)sCount[sChar[i]] + 1;
                }
                else
                {
                    sCount.Add(sChar[i], 1);
                }

            }

            if (CompareHashtable(sCount, pCount))
            {
                result.Add(0);
            }

            int start = 0;
            //int end = pChar.Length - 1;

            for(int end = pChar.Length; end < sChar.Length; end++)
            {
                if (sCount.ContainsKey(sChar[end]))
                {
                    sCount[sChar[end]] = (int)sCount[sChar[end]] + 1;
                }
                else
                {
                    sCount.Add(sChar[end], 1);
                }

                if (sCount.ContainsKey(sChar[start]))
                {
                    sCount[sChar[start]] = (int)sCount[sChar[start]] - 1;
                    if((int)sCount[sChar[start]] == 0)
                    {
                        sCount.Remove(sChar[start]);
                    }
                }

                start++;

                if (CompareHashtable(sCount, pCount))
                {
                    result.Add(start);
                }


            }

            return result;
        }
    }
}
