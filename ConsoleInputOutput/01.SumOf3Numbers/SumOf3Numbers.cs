/* Problem 1. Sum of 3 Numbers
Write a program that reads 3 real numbers from the console and prints their sum.
 */

using System;

class SumOf3Numbers
{
    static void Main()
    {
        Console.Write("First number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        Console.WriteLine("The sum is: {0}", firstNumber+secondNumber+thirdNumber);

    }
}
