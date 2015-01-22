/* Problem 12.* Randomize the Numbers 1…N
Write a program that enters in integer `n` and prints the numbers `1, 2, …, n` in random order.
 */

using System;

class RandomizeTheNumbers1N
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Random rnd = new Random();
        bool[] printed = new bool[n + 1];
        int numberToPrint;
        
        for (int i = 1; i <= n; i++)
        {
            numberToPrint = rnd.Next(1, n + 1);
            if (!printed[numberToPrint])
            {
                Console.Write("{0} ", numberToPrint);
                printed[numberToPrint] = true;
                continue;
            }
            i--;
        }
        Console.WriteLine();
    }
}
