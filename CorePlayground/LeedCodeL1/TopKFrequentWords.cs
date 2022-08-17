using System;
using System.Collections.Generic;
using System.Linq;

namespace LeedCodeLove.LeedCodeL1
{
    public static class TopKFrequentWords
    {
        public static IList<string> TopKFrequent(string[] words, int k)
        {
            return words.GroupBy(x => x)
                        .OrderByDescending(x => x.Count())
                        .ThenBy(x => x.Key)
                        .Select(x => x.Key)
                        .Take(k)
                        .ToList();
        }
    }
}
