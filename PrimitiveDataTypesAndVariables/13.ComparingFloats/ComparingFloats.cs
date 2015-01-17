/*Problem 13.*	Comparing Floats
Write a program that safely compares floating-point numbers (double) with precision `eps = 0.000001`.
Note: Two floating-point numbers `a` and `b` cannot be compared directly by `a == b` because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant `eps`._
 */

using System;

class ComparingFloats
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        bool eps = Math.Abs(firstNumber - secondNumber) < 0.000001;
        if (eps)
        {
            Console.WriteLine("They are equal!");
        }
        else
            Console.WriteLine("They are NOT equal!");

    }
}
