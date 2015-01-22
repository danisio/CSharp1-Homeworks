/* Problem 11.	Random Numbers in Given Range
 Write a program that enters `3` integers `n`, `min` and `max` (`min = max`) and prints `n` random numbers in the range `[min...max]`.
 */

using System;

class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max: ");
        int max = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        Console.WriteLine("The result: ");
        for (int i = 0; i < number; i++)
        {
            Console.Write("{0} ", rnd.Next(min, max + 1));
        }
        Console.WriteLine();
    }
}
