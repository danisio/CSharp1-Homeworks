/*  Problem 6. Calculate N! / K!
Write a program that calculates `n! / k!` for given `n` and `k` (1 < k < n < 100).
Use only one loop.
 */

using System;
using System.Numerics;

class CalculateNK
{
    static void Main()
    {
        Console.WriteLine("Calculate  (N! / K!)   1 < K < N < 100");
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;

        if (k > 1 && n > k && n < 100)
        {
            for (int i = 1, j = 1; i <= n; i++, j++)
            {
                factorialN *= i;
                if (j <= k)
                {
                    factorialK *= j;
                }
            }
            BigInteger output = factorialN / factorialK;
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
