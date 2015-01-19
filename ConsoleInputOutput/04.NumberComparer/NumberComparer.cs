/* Problem 4. Number Comparer
Write a program that gets two numbers from the console and prints the greater of them.
Try to implement this without if statements.
 */

using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        decimal secondNumber = decimal.Parse(Console.ReadLine());

        bool greater = firstNumber > secondNumber;

        Console.WriteLine("The greater number is: {0}", greater ? firstNumber : secondNumber);
    }
}
