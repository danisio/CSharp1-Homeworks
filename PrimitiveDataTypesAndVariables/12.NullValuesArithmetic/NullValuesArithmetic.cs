/*Problem 12.	Null Values Arithmetic
Create a program that assigns null values to an integer and to a double variable. 
Try to print these variables at the console. 
Try to add some number or the null literal to these variables and print the result.

 */

using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? a = null;
        double? b = null;
        Console.WriteLine("Null varA and varB: [{0}] [{1}]", a, b);

        a = 1;
        b = 2;
        Console.WriteLine("With added numbers: [{0}] [{1}]", a, b);

        a = null;
        b = null;
        Console.WriteLine("Null varA and varB: [{0}] [{1}]", a, b);
    }
}
