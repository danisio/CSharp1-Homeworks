/* Problem 4. Rectangles
 Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */

using System;

class Rectangles
{
    static void Main()
    {
        Console.Write("Enter rectangle's width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter rectangle's height: ");
        double height = double.Parse(Console.ReadLine());

        double perimeter = width * 2 + height * 2;
        double area = width * height;

        Console.WriteLine("The perimeter is: " + perimeter);
        Console.WriteLine("The area is: " + area);
    }
}
