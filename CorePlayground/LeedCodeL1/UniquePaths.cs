using System;
using System.Collections.Generic;

namespace LeedCodeLove.LeedCodeL1
{
    public static class UniquePaths
    {
        public static int UniquePath(int m, int n)
        {
            var memo = new Dictionary<string, int>();
            return Recursion(m, n, memo);
        }

        private static int Recursion(int m, int n, Dictionary<string, int> memoization)
        {
            if (memoization.ContainsKey($"{m},{n}")) return memoization[$"{m},{n}"];
            if (m == 1 && n == 1) return 1;
            if (m == 0 || n == 0) return 0;

            memoization.Add($"{m},{n}", Recursion(m - 1, n, memoization) + Recursion(m, n - 1, memoization));
            return memoization[$"{m},{n}"];
        }
    }
}
