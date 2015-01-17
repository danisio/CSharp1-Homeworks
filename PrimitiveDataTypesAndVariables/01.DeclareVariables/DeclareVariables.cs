﻿/* Problem 1. Declare Variables
Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
 */

using System;

class DeclareVariables
{
    static void Main()
    {
        ushort a = 52130;
        sbyte b = -115;
        int c = 4825932;
        byte d = 97;
        short e = -10000;

        Console.WriteLine("{0, 10} is type {1}", a, a.GetType().Name);
        Console.WriteLine("{0, 10} is type {1}", b, b.GetType().Name);
        Console.WriteLine("{0, 10} is type {1}", c, c.GetType().Name);
        Console.WriteLine("{0, 10} is type {1}", d, d.GetType().Name);
        Console.WriteLine("{0, 10} is type {1}", e, e.GetType().Name);

    }
}