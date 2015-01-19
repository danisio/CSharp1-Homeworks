/* Problem 6. Four-Digit Number
Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example `2 + 0 + 1 + 1 = 4`).
Prints on the console the number in reversed order: `dcba` (in our example `1102`).
Puts the last digit in the first position: `dabc` (in our example `1201`).
Exchanges the second and the third digits: `acbd` (in our example `2101`).
The number has always exactly 4 digits and cannot start with 0.
 */

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a four-digit number: ");
        int number = int.Parse(Console.ReadLine());
        int num1 = number / 1000;
        int num2 = (number % 1000) / 100;
        int num3 = (number % 100) / 10;
        int num4 = number % 10;

        Console.WriteLine("The sum of the digits: " + (num1 + num2 + num3 + num4));
        Console.WriteLine("The reversed order: " + num4 + num3 + num2 + num1);
        Console.WriteLine("Last digit in the 1 position: " + num4 + num1 + num2 + num3);
        Console.WriteLine("Exchanged 2 and 3 position: " + num1 + num3 + num2 + num4);
    }
}
