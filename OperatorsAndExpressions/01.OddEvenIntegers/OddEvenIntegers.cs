/* Problem 1. Odd or Even Integers
Write an expression that checks if given integer is odd or even.
 */

using System;

class OddEvenIntegers
{
    static void Main()
    {
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());
       
        if (number % 2 == 0)
        {
            Console.WriteLine("Your number is EVEN");  
        }
        else
            Console.WriteLine("Your number is ODD");
    }
}
