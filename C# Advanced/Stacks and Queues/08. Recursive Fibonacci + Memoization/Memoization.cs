using System;

class FibonacciChecks
{
    public static long[] my_memo;

    static void Main()
    {
        long k = long.Parse(Console.ReadLine());
        my_memo = new long[k + 1];

        Console.WriteLine(FibWithMemo(k));
    }

    static long FibWithMemo(long n)
    {
        if (my_memo[n] != 0) return my_memo[n];
        if (n == 0) return 0;
        if (n == 1) return 1;
        my_memo[n] = FibWithMemo(n - 1) + FibWithMemo(n - 2);
        return my_memo[n];
    }
}