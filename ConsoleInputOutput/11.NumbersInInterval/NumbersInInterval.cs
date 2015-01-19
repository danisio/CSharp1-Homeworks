/* Problem 11. Numbers in Interval Dividable by Given Number
Write a program that reads two positive integer numbers and prints how many numbers `p` exist between them such that the reminder of the division by `5` is `0`.
 */

using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.Write("Enter lower limit: ");
        uint lower = uint.Parse(Console.ReadLine());
        Console.Write("Enter upper limit: ");
        uint upper = uint.Parse(Console.ReadLine());

        int count = 0;
        Console.WriteLine();

        for (uint i = lower; i <= upper; i++)
        {
            if (i % 5 == 0)
            {
                count++;
                Console.Write("{0} ", i);
            }
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("{0} numbers exist between your limits", count);
    }
}
