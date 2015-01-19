/* Problem 3. Circle Perimeter and Area
Write a program that reads the radius `r` of a circle and prints its perimeter and area formatted with `2` digits after the decimal point.
 */

using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * radius * Math.PI;
        double area = radius * radius * Math.PI;

        Console.WriteLine("Perimeter = {0:F2}", perimeter);
        Console.WriteLine("Area = {0:F2}", area);
    }
}
