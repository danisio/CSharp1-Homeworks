/* Problem 14.*	Print the ASCII Table
Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
 */

using System;
using System.Text;

class PrintASCIITable
{
    static void Main()
    {
        for (int i = 0; i <= 255; i++)
        {
            Console.OutputEncoding = Encoding.UTF8;
            char c = Convert.ToChar(i);
            Console.WriteLine("{0,4} --> {1}", i,c);
        }
    }
}
