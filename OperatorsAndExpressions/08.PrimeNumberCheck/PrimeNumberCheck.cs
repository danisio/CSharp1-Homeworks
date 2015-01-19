/* Problem 8. Prime Number Check
Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
 */

using System;

class PrimeNumberCheck
{
    static void Main()
    {
        Console.Write("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        uint sqrtNumber = (uint)Math.Sqrt(number);

        bool prime = true;
        for (int i = 2; i <= sqrtNumber; i++)
        {
            if (number % i == 0)
            {
                prime = false;
                break;          //if prime = false --> stop the loop go to next line 25
            }
        }

        Console.WriteLine();
        Console.WriteLine("The number is prime! --> " + prime);
    }
}