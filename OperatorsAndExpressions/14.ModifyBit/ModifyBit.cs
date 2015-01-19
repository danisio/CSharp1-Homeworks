/* Problem 14.  Modify a Bit at Given Position
We are given an integer number `n`, a bit value `v` (v=0 or 1) and a position `p`.
Write a sequence of operators (a few lines of C# code) that modifies `n` to hold the value `v` at the position `p` from the binary representation of `n` while preserving all other bits in `n`.
 */

using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Your number in binary: " + Convert.ToString(number, 2).PadLeft(32, '0'));

        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.Write("Enter value 0/1: ");
        int value = int.Parse(Console.ReadLine());

        int newNumber=0;

        if (value == 0)
        { 
            int mask = ~(1 << position);
            newNumber = number & mask;
        }
        else if (value == 1)
        {
            int mask = 1 << position;
            newNumber = number | mask;
        }
        else
            Console.WriteLine("The value isn't valid!");

        Console.WriteLine();
        Console.WriteLine("Your new number is: " + newNumber + "\nConverted in binary: " +
                             Convert.ToString(newNumber, 2).PadLeft(32, '0'));
    }
}
