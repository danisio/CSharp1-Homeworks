/* Problem 7. Calculate N! / (K! * (N-K)!)
In combinatorics, the number of ways to choose `k` different members out of a group of `n` different elements (also known as the number of combinations) is calculated by the following formula:
![formula](https://cloud.githubusercontent.com/assets/3619393/5626060/89cc780e-958e-11e4-88d2-0e1ff7229768.png)
For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates `n! / (k! * (n-k)!)` for given `n` and `k` (1 < k < n < 100). Try to use only two loops.
*/

using System;
using System.Numerics;

class CalculateNKAdvanced
{
    static void Main()
    {
        Console.WriteLine("Calculate n! / (k! * (n-k)!)   1 < k < n < 100");
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;

        if (k > 1 && n > k && n < 100)
        {
            int nk = n - k;
            for (int i = 1; i <= nk; i++)
            {
                factorialNK *= i;
            }
            for (int i = 1, j = 1; i <= n; i++, j++)
            {
                factorialN *= i;
                if (j <= k)
                {
                    factorialK *= j;
                }
            }
            BigInteger output = factorialN / (factorialK * factorialNK);
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
