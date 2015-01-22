/* Problem 15. Hexadecimal to Decimal Number
 Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
*/

using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        Console.Write("Enter a hexadecimal number: ");
        string input = Console.ReadLine();

        int power = 0;
        long numberInHex = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            int sign;
            if (input[i] == 'a' || input[i] == 'A')
            {
                sign = 10;
            }
            else if (input[i] == 'b' || input[i] == 'B')
            {
                sign = 11;
            }
            else if (input[i] == 'c' || input[i] == 'C')
            {
                sign = 12;
            }
            else if (input[i] == 'd' || input[i] == 'D')
            {
                sign = 13;
            }
            else if (input[i] == 'e' || input[i] == 'E')
            {
                sign = 14;
            }
            else if (input[i] == 'f' || input[i] == 'F')
            {
                sign = 15;
            }
            else
            {
                sign = input[i] - 48;
            }

            numberInHex += sign * (long)Math.Pow(16, power++);
        }
        Console.WriteLine("Coverted to decimal: " + numberInHex);
    }
}
