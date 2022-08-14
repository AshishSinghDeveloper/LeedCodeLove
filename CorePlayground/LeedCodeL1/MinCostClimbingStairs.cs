using System;
namespace LeedCodeLove.LeedCodeL1
{
    public static class MinCostClimbingStairs
    {
        public static int MinCostClimbingStair(int[] cost)
        {
            int first = cost[0];
            int second = cost[1];

            for (int i = 2; i < cost.Length; i++)
            {
                int min = Math.Min(first, second);
                int temp = min + cost[i];
                first = second;
                second = temp;
            }

            return Math.Min(first, second);
        }
    }
}
