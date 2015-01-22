/* Problem 14.	Decimal to Binary Number
Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
 */

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Write a decimal number: ");
        long input = long.Parse(Console.ReadLine());
        long number = 0;
        string numberBin = "";

        while (input > 0)
        {
            number = input % 2;
            input = input / 2;
            numberBin = number + numberBin;
        }
        Console.WriteLine("Converted to binary: " + numberBin);
    }
}
