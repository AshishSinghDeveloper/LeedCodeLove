namespace LeedCodeLove.LeedCodeL1
{
    public static class BinarySearch
    {
		public static int Search(int[] nums, int target)
		{
			int start = 0;
			int end = nums.Length - 1;
			while (start <= end)
			{
				int middle = (start + end) / 2;
				if (nums[middle] == target)
				{
					return middle;
				}
				else if (nums[middle] > target)
				{
					end = middle - 1;
				}
				else
				{
					start = middle + 1;
				}
			}
			return -1;
		}
	}
}
