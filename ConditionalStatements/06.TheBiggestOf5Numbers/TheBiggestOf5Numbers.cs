/* Problem 6. The Biggest of Five Numbers
Write a program that finds the biggest of five numbers by using only five if statements.
 */

using System;

class TheBiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter number 1: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 3: ");
        double num3 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 4: ");
        double num4 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 5: ");
        double num5 = double.Parse(Console.ReadLine());


        if ((num1 > num2) && (num1 > num3) && (num1 > num4) && (num1 > num5))
        {
            Console.WriteLine("The biggest number is: " + num1);
        }
        else if ((num2 > num1) && (num2 > num3) && (num2 > num4) && (num2 > num5))
        {
            Console.WriteLine("The biggest number is: " + num2);
        }
        else if ((num3 > num1) && (num3 > num2) && (num3 > num4) && (num3 > num5))
        {
            Console.WriteLine("The biggest number is: " + num3);
        }
        else if ((num4 > num1) && (num4 > num2) && (num4 > num3) && (num4 > num5))
        {
            Console.WriteLine("The biggest number is: " + num4);
        }
        else
        {
            Console.WriteLine("The biggest number is: " + num5);
        }
    }
}