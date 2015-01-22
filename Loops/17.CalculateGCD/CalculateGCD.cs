/* Problem 17.* Calculate GCD
Write a program that calculates the greatest common divisor (GCD) of given two integers `a` and `b`.
Use the Euclidean algorithm (find it in Internet).
 */

using System;

class CalculateGCD
{
    static void Main()
    {
        Console.Write("Enter A: ");
        int numberA = Math.Abs(int.Parse(Console.ReadLine()));
        Console.Write("Enter B: ");
        int numberB = Math.Abs(int.Parse(Console.ReadLine()));
        int remainder=0;

        if (numberA < numberB)
        {
            int temp = numberB;
            numberB = numberA;
            numberA = temp;
        }
        while (numberB != 0)
        {
            remainder = numberA % numberB;
            numberA = numberB;
            numberB = remainder;
        }
        Console.WriteLine("GCD = " + numberA);
    }
}
