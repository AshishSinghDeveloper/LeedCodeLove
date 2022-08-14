namespace LeedCodeLove.LeedCodeL1
{
    public static class FibonacciNumber
    {
        public static int Fib(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;

            int f1 = 0;
            int f2 = 1;
            int total = 0;

            for (int i = 2; i <= n; i++)
            {
                total = f1 + f2;
                f1 = f2;
                f2 = total;
            }
            return total;
        }
    }
}
