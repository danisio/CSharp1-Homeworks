/* Problem 8.	Catalan Numbers
In combinatorics, the Catalan numbers are calculated by the following formula:
![catalan-formula](https://cloud.githubusercontent.com/assets/3619393/5626137/d7ec8bc2-958f-11e4-9787-f6c386847c81.png)
Write a program to calculate the `nth` Catalan number by given `n` (1 < n < 100). 
 */

using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        Console.WriteLine("Calculate Catalan numbers  1 < n < 100");
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial2N = 1;
        BigInteger factorialN = 1;
        BigInteger factorialNPlus1 = 1;

        if (n > 1 && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                factorialN *= i;
            }
            for (int i = 1; i <= 2 * n; i++)
            {
                factorial2N *= i;
            }
            for (int i = 1; i <= n + 1; i++)
            {
                factorialNPlus1 *= i;
            }
            BigInteger result = factorial2N / (factorialNPlus1 * factorialN);
            Console.WriteLine("The result is: " + result);
        }
        else if (n == 0)
        {
            Console.WriteLine("The result is: 1");
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}
