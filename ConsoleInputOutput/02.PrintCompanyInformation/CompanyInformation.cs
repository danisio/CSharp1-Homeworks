/* Problem 2. Print Company Information
A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
 */

using System;

class CompanyInformation
{
    static void Main()
    {
        Console.WriteLine("Enter information about the company:");
        Console.Write("Name: ");
        string companyName = Console.ReadLine();
        Console.Write("Address: ");
        string companyAddress = Console.ReadLine();
        Console.Write("Phone Number: ");
        string companyPhone = Console.ReadLine();
        Console.Write("Fax Number: ");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Website: ");
        string companyWebsite = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Enter information about the manager: ");
        Console.Write("First Name: ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Last name: ");
        string managerLastName = Console.ReadLine();
        Console.Write("Age: ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Phone Number: ");
        string managerPhone = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(@"Company
Name:         {0}
Address:      {1}
Phone Number: {2}
Fax Number:   {3}
Website:      {4}
Manager:      {5} {6} (age: {7}, tel. {8})
", companyName, companyAddress, companyPhone, companyFaxNumber, companyWebsite,
 managerFirstName, managerLastName, managerAge, managerPhone);
    }
}

