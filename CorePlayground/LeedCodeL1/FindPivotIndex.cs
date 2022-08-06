using System;
using System.Linq;

namespace CorePlayground.LeedCodeL1
{
    public static class FindPivotIndex
    {
        public static int GetPivotIndex(int[] nums)
        {
            int startIndex = 0;
            int endIndex = nums.Length - 1;
            int[] pivotArray = new int[nums.Length];

            pivotArray[startIndex] = nums[startIndex];
            pivotArray[endIndex] = nums[endIndex];

            while(startIndex < endIndex)
            {
                if(pivotArray[startIndex] < pivotArray[endIndex])
                {
                    pivotArray[startIndex + 1] = pivotArray[startIndex] + nums[startIndex + 1];
                    startIndex++;
                }
                else if(pivotArray[startIndex] > pivotArray[endIndex])
                {
                    pivotArray[endIndex - 1] = pivotArray[endIndex] + nums[endIndex - 1];
                    endIndex--;
                }
                else if(pivotArray[startIndex] == pivotArray[endIndex])
                {
                    if(startIndex + 2 == endIndex)
                    {
                        return startIndex + 1;
                    }
                    else if(startIndex + 1== endIndex)
                    {
                        return -1;
                    }
                    //else if(startIndex == endIndex)
                    //{
                    //    return startIndex;
                    //}
                    else
                    {
                        startIndex--;
                        endIndex--;
                    }

                }
                
            }
            return -1;
        }

        public static int GrabPivotIndex(int[] nums)
        {
            int leftSum = 0;
            int rightSum = 0;
            int total = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                rightSum = total - nums[i] - leftSum;
                if(leftSum == rightSum)
                {
                    return i;
                }
                leftSum += nums[i];                
              
            }
            return -1;
        }
    }
}
