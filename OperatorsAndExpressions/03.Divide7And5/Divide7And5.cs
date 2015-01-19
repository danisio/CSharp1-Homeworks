/* Problem 3. Divide by 7 and 5
Write a Boolean expression that checks for given integer if it can be divided (without remainder) by `7` and `5` at the same time.
 */

using System;

class Divide7And5
{
    static void Main()
    {
        Console.Write("Enter an integer number: ");
        int number = int.Parse(Console.ReadLine());
       
        bool check = (number % 5 == 0) && (number % 7 == 0);
        
        Console.WriteLine("Your number can be devided by 5 and 7 at the same time --> {0}", check);
    }
}
