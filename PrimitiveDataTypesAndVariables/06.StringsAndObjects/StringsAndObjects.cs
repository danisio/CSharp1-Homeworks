/*Problem 6. Strings and Objects
Declare two string variables and assign them with `Hello` and `World`.
Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
 */

using System;

class StringsAndObjects
{
    static void Main()
    {
        string first = "Hello";
        string second = "World";
        object both = first + " " + second;
        string final = Convert.ToString(both);
        Console.WriteLine(final);
    }
}
