/* Problem 13.	Binary to Decimal Number
Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
 */

using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a binary number: ");
        string input = Console.ReadLine();

        int power = 0;
        long numberInDec = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            numberInDec += ((long)input[i] - 48) * (long)Math.Pow(2, power++);
        }
        Console.WriteLine("Converted to decimal: " + numberInDec);
    }
}
