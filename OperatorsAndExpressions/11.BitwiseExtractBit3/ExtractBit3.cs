/* Problem 11. Bitwise: Extract Bit #3
Using bitwise operators, write an expression for finding the value of the bit `#3` of a given unsigned integer.
The bits are counted from right to left, starting from bit `#0`.
The result of the expression should be either `1` or `0`.
 */

using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        uint number = uint.Parse(Console.ReadLine());

        int mask = 1 << 3;
        uint maskAndNumber = (uint)mask & number;
        uint bit = maskAndNumber >> 3;

        Console.WriteLine("Your number in binary: {0}", Convert.ToString(number, 2));
        Console.WriteLine("The third bit is = " + bit);
    }
}
