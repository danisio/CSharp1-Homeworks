/* Problem 5. Calculate 1 + 1!/X + 2!/X2 + … + N!/XN
Write a program that, for a given two integer numbers `n` and `x`, calculates the sum `S = 1 + 1!/x + 2!/x2 + … + n!/xn`.
Use only one loop. Print the result with `5` digits after the decimal point.
 */

using System;

class CalculateN
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
       
        int factorial = 1;
        decimal sum = 1m;

        for (int i = 1; i <= n; i++)        
        {
            factorial *= i;
            sum += (decimal)factorial / (decimal)Math.Pow(x,i);
        }

        Console.WriteLine("{0:F5}", sum);
    }
}
