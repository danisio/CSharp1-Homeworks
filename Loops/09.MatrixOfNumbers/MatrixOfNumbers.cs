/*  Problem 9.	Matrix of Numbers
Write a program that reads from the console a positive integer number `n` (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
 */

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter 1 <= n <= 20: ");
        int n = int.Parse(Console.ReadLine());

        if ((n >= 1) && (n <= 20))
        {
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    Console.Write("{0, 2} ", row + col + 1);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Out of range! ");
        }

    }
}
