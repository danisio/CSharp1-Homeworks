/* Problem 13. Check a Bit at Given Position
Write a Boolean expression that returns if the bit at position `p` (counting from `0`, starting from the right) in given integer number `n`, has value of 1.
 */

using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter position: ");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int maskAndNumber = mask & number;
        int bit = maskAndNumber >> position;
        bool isBit = (bit == 1);

        Console.WriteLine("Your number in binary: {0}", Convert.ToString(number, 2));
        Console.WriteLine("The value of bit {0} is 1 --> {1}", position, isBit);
    }
}