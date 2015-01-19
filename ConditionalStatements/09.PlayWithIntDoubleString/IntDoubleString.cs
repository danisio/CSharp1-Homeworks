/* Problem 9. Play with Int, Double and String
Write a program that, depending on the user’s choice, inputs an `int`, `double` or `string` variable.
	If the variable is `int` or `double`, the program increases it by one.
	If the variable is a `string`, the program appends `*` at the end.
Print the result at the console. Use switch statement.
 */

using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine(@"Please choose a type: 
1 --> int
2 --> double
3 --> string"
);
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                Console.Write("Enter integer number: ");
                int inputInt = int.Parse(Console.ReadLine());
                Console.WriteLine("The result: {0}", ++inputInt);
                break;
            case 2:
                Console.Write("Enter floating point number: ");
                double inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine("The result: {0}", ++inputDouble);
                break;
            case 3:
                Console.Write("Enter string: ");
                string inputString = Console.ReadLine();
                Console.WriteLine("The result: {0}*", inputString);
                break;
            default:
                Console.WriteLine("Not a valid choise!");
                break;
        }
    }
}