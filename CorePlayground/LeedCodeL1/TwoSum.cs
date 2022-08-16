using System;
using System.Collections;

namespace LeedCodeLove.LeedCodeL1
{
    public static class TwoSum
    {
        public static int[] TwoSumBruteForce(int[] nums, int target)
        {
            int[] result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        return result;
                    }
                }
            }
            return result;
        }

        //TC: O(n) | SC: O(n)
        public static int[] TwoSumOptimized(int[] nums, int target)
        {
            int[] result = new int[2];
            Hashtable diffTable = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!diffTable.ContainsKey(nums[i]))
                {
                    int diff = target - nums[i];
                    if (!diffTable.ContainsKey(diff))
                    {
                        diffTable.Add(diff, i);
                    }
                }
                else
                {
                    result[0] = (int)diffTable[nums[i]];
                    result[1] = i;
                    return result;
                }
            }
            return result;
        }
    }
}
