/* Problem 1. Exchange If Greater
Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
 */

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter number A: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter number B: ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            double temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }

        Console.WriteLine("Te result --> A = {0} B = {1}", firstNumber, secondNumber);
    }
}
