/*Problem 10. Employee Data
A marketing company wants to keep record of its employees. Each record would have the following characteristics:
First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use
descriptive names. Print the data at the console.
 */

using System;

class EmployeeData
{
    static void Main()
    {
        Console.WriteLine("Please enter");
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Gender M/F: ");
        char gender = char.Parse(Console.ReadLine());
        Console.Write("Employee's number: ");
        int uniqueEmployeeNumber = int.Parse(Console.ReadLine());
        Console.Write("Personal ID: ");
        long personalID = long.Parse(Console.ReadLine());

        Console.WriteLine(@"
        Employee's data:
        Name:        {0} {1}
        Age:         {2}
        Gender:      {3}
        Number:      {4}
        Personal ID: {5}
", firstName, lastName, age, gender, uniqueEmployeeNumber, personalID);
    }
}
