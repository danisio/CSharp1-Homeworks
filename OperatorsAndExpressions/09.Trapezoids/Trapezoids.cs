/* Problem 9. Trapezoids
Write an expression that calculates trapezoid's area by given sides `a` and `b` and height `h`.
 */

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Write("Enter side a = ");
        double sideA = int.Parse(Console.ReadLine());
        Console.Write("Enter side b = ");
        double sideB = int.Parse(Console.ReadLine());
        Console.Write("Enter height h = ");
        double height = int.Parse(Console.ReadLine());

        double area = ((sideA + sideB) / 2) * height;
        Console.WriteLine("The area is = " + area);
    }
}