/* Problem 10. Fibonacci Numbers
Write a program that reads a number `n` and prints on the console the first `n` members of the Fibonacci sequence (at a single line, separated by comma and space - `, `) : `0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …`.
 */

using System;

class FibonacciNumbers
{
    static void Main()
        {
            Console.Write("Enter a number: ");
            ulong lenght = ulong.Parse(Console.ReadLine());
            
            int a = 0, b = 1, c = 0;
            Console.Write("{0}, {1}", a, b);
 
            for (ulong i = 2; i < lenght; i++)
            {
                c= a + b;
                Console.Write(", {0}", c);
                a= b;
                b= c;
            }
            Console.WriteLine();
        }
}
