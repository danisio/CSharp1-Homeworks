/* Problem 16.	Decimal to Hexadecimal Number
Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
*Do not use the built-in .NET functionality.
 */

using System;

class DecimalToHexadecimalNumber
{
    static void Main()
    {
        Console.Write("Write a decimal number: ");
        long input = long.Parse(Console.ReadLine());

        long number = 0;
        string numberHex = "";

        while (input > 0)
        {
            number = input % 16;
            input = input / 16;
            if (number >= 16 || number <= 9)
            {
                numberHex = number + numberHex;
            }
            else if (number == 10)
            {
                numberHex = "A" + numberHex;
            }
            else if (number == 11)
            {
                numberHex = "B" + numberHex;
            }
            else if (number == 12)
            {
                numberHex = "C" + numberHex;
            }
            else if (number == 13)
            {
                numberHex = "D" + numberHex;
            }
            else if (number == 14)
            {
                numberHex = "E" + numberHex;
            }
            else if (number == 15)
            {
                numberHex = "F" + numberHex;
            }
        }
        Console.WriteLine("Converted to hexadecimal: " + numberHex);
    }
}
