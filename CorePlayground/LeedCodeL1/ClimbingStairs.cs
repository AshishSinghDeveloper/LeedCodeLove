using System;
namespace LeedCodeLove.LeedCodeL1
{
    public static class ClimbingStairs
    {
        public static int ClimbStairsAttempt1(int n)
        {
            int ans = Recursion(n);
            return ans;
        }

        private static int Recursion(int n)
        {
            if (n < 2)
                return 1;
            return Recursion(n - 1) + Recursion(n - 2);
        }

        public static int ClimbStraisAttempt2(int n)
        {
            int one = 1;
            int two = 1;
            for (int i = 1; i <= n - 1; i++)
            {
                int temp = one;
                one = one + two;
                two = temp;
            }
            return one;
        }
    }

    
}

