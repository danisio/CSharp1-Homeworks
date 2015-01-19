/* Problem 8. Digit as Word
Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
	Print `“not a digit”` in case of invalid input.
	Use a switch statement.

 */

using System;

class DigitAsWord
{
    static void Main()
    {
        Console.Write("Write a digit [0..9]: ");
        int digit = int.Parse(Console.ReadLine());

        switch (digit)
        {
            case 1:
                Console.WriteLine("ONE");
                break;
            case 2:
                Console.WriteLine("TWO");
                break;
            case 3:
                Console.WriteLine("THREE");
                break;
            case 4:
                Console.WriteLine("FOUR");
                break;
            case 5:
                Console.WriteLine("FIVE");
                break;
            case 6:
                Console.WriteLine("SIX");
                break;
            case 7:
                Console.WriteLine("SEVEN");
                break;
            case 8:
                Console.WriteLine("EIGHT");
                break;
            case 9:
                Console.WriteLine("NINE");
                break;
            default:
                Console.WriteLine("Not a digit!");
                break;
        }
    }
}
