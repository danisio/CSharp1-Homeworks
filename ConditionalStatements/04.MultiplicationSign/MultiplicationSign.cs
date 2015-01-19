/* Problem 4. Multiplication Sign
*	Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
 */

using System;

class MultiplicationSign
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        double first = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double second = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double third = double.Parse(Console.ReadLine());

        if (first == 0 || second == 0 || third == 0)
        {
            Console.WriteLine("The sign is: 0");
        }
        else if (first < 0 && second > 0 && third > 0 ||
                 first > 0 && second < 0 && third > 0 ||
                 first > 0 && second > 0 && third < 0 ||
                 first < 0 && second < 0 && third < 0)
        {
            Console.WriteLine("The sign is: -");
        }
        else
        {
            Console.WriteLine("The sign is: +");
        }
    }
}
