using System;
namespace LeedCodeLove.LeedCodeL1
{
    public static class FirstBadVersion
    {
		public static int VersionControl(int n)
		{
			if (n == 1) return 1;
			int start = 1;
			int end = n;
			int answer = -1;

			while (start < end)
			{

				int mid = start + (end - start) / 2; // (start + end) can be greateer than INT_MAX

				if (IsBadVersion(mid)) 
				{
					end = mid;
					answer = mid;
				}
				else
				{
					start = mid + 1;
				}
				if (start == end) return start;

			}
			return answer;

		}

		public static bool IsBadVersion(int n)
        {
			//This is an provided API call.
			// returning true so that build do not fail
			return true;
        }
	}
}
