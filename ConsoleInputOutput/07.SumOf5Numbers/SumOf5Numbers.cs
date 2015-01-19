/* Problem 7. Sum of 5 Numbers
Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
 */

using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter 5 numbers separated by a space: ");
        string inputString = Console.ReadLine();
        int number = int.Parse(inputString.Replace(" ", String.Empty));

        int num1 = number / 10000;
        int num2 = (number % 10000) / 1000;
        int num3 = (number % 1000) / 100;
        int num4 = (number % 100) / 10;
        int num5 = number % 10;

        Console.WriteLine("The sum is = " + (num1 + num2 + num3 + num4 + num5));
    }
}
