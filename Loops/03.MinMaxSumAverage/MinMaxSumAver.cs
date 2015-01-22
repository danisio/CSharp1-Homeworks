/* Problem 3.	Min, Max, Sum and Average of N Numbers
Write a program that reads from the console a sequence of `n` integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number `n` (alone in a line) followed by `n` lines, each holding an integer number.
The output is like in the examples below.
 */

using System;

class MinMaxSumAver
{
    static void Main()
    {
        int length = 3;
        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;
        double average = 0;
        Console.WriteLine("Enter {0} numbers:", length);

        for (int i = 0; i < length; i++)
        {
            int input = int.Parse(Console.ReadLine());
            if (input < min)
            {
                min = input;
            }
            if (max < input)
            {
                max = input;
            }
            sum += input;
            average = sum / length;

        }
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", average);
    }
}
