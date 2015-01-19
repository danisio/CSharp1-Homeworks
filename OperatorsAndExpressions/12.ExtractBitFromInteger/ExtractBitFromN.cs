/* Problem 12. Extract Bit from Integer
Write an expression that extracts from given integer `n` the value of given bit at index `p`.
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

        Console.WriteLine("Your number in binary: {0}", Convert.ToString(number, 2));
        Console.WriteLine("The bit {0} is = {1}", position, bit);
    }
}