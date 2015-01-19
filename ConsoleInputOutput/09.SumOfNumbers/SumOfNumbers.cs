/* Problem 9. Sum of n Numbers
Write a program that enters a number `n` and after that enters more `n` numbers and calculates and prints their `sum`.
 */ 

using System;

    class SumOfNumbers
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            decimal sum = 0;
            Console.WriteLine();
            for (int i = 1; i <= number; i++)
            {
                Console.Write("Enter number {0}: ", i);
                decimal a = decimal.Parse(Console.ReadLine());
                sum += a;

            }

            Console.WriteLine("The sum or your {0} numbers is {1:F2}: ", number, sum);
        }
    }
