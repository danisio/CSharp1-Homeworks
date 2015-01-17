/*Problem 8.	Isosceles Triangle
Write a program that prints an isosceles triangle of 9 copyright symbols `©`.
 */

using System;
using System.Text;

class IsoscelesTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyRight = '\u00A9';

        Console.WriteLine("   {0}\n  {0} {0}\n {0}   {0}\n{0} {0} {0} {0}", copyRight);
    }
}