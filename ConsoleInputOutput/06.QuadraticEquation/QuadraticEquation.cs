/* Problem 6. Quadratic Equation
Write a program that reads the coefficients `a`, `b` and `c` of a quadratic equation ax<sup>2</sup> + bx + c = 0 and solves it (prints its real roots).
 */

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("Enter A: ");
        double A = double.Parse(Console.ReadLine());
        Console.Write("Enter B: ");
        double B= double.Parse(Console.ReadLine());
        Console.Write("Enter C: ");
        double C = double.Parse(Console.ReadLine());

        double D = B * B - 4 * A * C;

        if (D > 0)
        {
            double X1 = (-B + Math.Sqrt(D)) / (2 * A);
            double X2 = (-B - Math.Sqrt(D)) / (2 * A);
            Console.WriteLine("Real root X1 = {0:F1}", X1);
            Console.WriteLine("Real root X2 = {0:F1}", X2);
        }
        else if (D == 0)
        {
            double X = -B / (2 * A);
            Console.WriteLine("One root X = {0:F1}", X);
        }
        else
        {
            Console.WriteLine("There are no real roots.");
        }
    }
}