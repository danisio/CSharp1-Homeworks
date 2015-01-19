/* Problem 7. Sort 3 Numbers with Nested Ifs
Write a program that enters 3 real numbers and prints them sorted in descending order.
	Use nested `if` statements.
 */ 

using System;

    class SortingNestedIfs
    {
        static void Main()
        {
            Console.Write("Enter number 1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter number 3: ");
            double num3 = double.Parse(Console.ReadLine());

            if ((num1 >= num2) && (num1 >= 3))
            {
                if (num2 >= num3)
                {
                    Console.WriteLine("Sorted: {0}, {1}, {2}", num1, num2, num3);
                }
                else
                {
                    Console.WriteLine("Sorted: {0}, {1}, {2}", num1, num3, num2);
                }
            }
            else if ((num2 >= num1) && (num2 >= num3))
            {
                if (num1 >= num3)
                {
                    Console.WriteLine("Sorted: {0}, {1}, {2}", num2, num1, num3);
                }
                else
                {
                    Console.WriteLine("Sorted: {0}, {1}, {2}", num2, num3, num1);
                }
            }
            else if ((num3 >= num1) && (num3 >= num2))
            {
                if (num1 >= num2)
                {
                    Console.WriteLine("Sorted: {0}, {1}, {2}", num3, num1, num2);
                }
                else
                {
                    Console.WriteLine("Sortes: {0}, {1}, {2}", num3, num2, num1);
                }

            }
        }
    }

