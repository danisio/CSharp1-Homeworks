/* Problem 5. The Biggest of 3 Numbers
Write a program that finds the biggest of three numbers.
 */

using System;

class TheBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter number 1: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        double num2 = double.Parse(Console.ReadLine());
        Console.Write("Enter number 3: ");
        double num3 = double.Parse(Console.ReadLine());


        if ((num1 > num2) && (num1 > num3))
        {
            Console.WriteLine("The biggest number is: " + num1);
        }
        else if ((num2 > num1) && (num2 > num3))
        {
            Console.WriteLine("The biggest number is: " + num2);
        }
        else
        {
            Console.WriteLine("The biggest number is: " + num3);
        }
    }
}
