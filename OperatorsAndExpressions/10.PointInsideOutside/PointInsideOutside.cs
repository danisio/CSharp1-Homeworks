/*Problem 10.	Point Inside a Circle & Outside of a Rectangle
Write an expression that checks for given point (x, y) if it is within the circle `K({1, 1}, 1.5)` and out of the rectangle `R(top=1, left=-1, width=6, height=2)`.
 */

using System;

class PointInsideOutside
{
    static void Main()
    {
        Console.Write("Enter x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        double y = double.Parse(Console.ReadLine());

        double radius = 1.5;
        bool insideCircle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) < (radius * radius));
        bool outsideRect = ((x < -1) || (x > 5) || (y < -1) || (y > 1));
        bool inAndOut = insideCircle && outsideRect;
        Console.WriteLine();
        Console.WriteLine("The point is inside the circle and outside the rectangle --> " + inAndOut);
    }
}