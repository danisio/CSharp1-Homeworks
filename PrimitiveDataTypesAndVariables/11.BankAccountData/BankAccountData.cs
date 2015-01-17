/* Problem 11. Bank Account Data
A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
 */

using System;

class BankAccountData
{
    static void Main()
    {
        Console.WriteLine("Please enter");
        Console.Write("First name: ");
        string firstName = Console.ReadLine();
        Console.Write("Middle name: ");
        string middleName = Console.ReadLine();
        Console.Write("Last name: ");
        string lastName = Console.ReadLine();
        Console.Write("Balance: ");
        decimal balance = decimal.Parse(Console.ReadLine());
        Console.Write("Bank name: ");
        string bankName = (Console.ReadLine());
        Console.Write("IBAN: ");
        string iban = (Console.ReadLine());
        Console.Write("Credit card 1: ");
        ulong card1 = ulong.Parse(Console.ReadLine());
        Console.Write("Credit card 2: ");
        ulong card2 = ulong.Parse(Console.ReadLine());
        Console.Write("Credit card 3: ");
        ulong card3 = ulong.Parse(Console.ReadLine());

Console.WriteLine(@"
Client's data:
Name:          {0} {1} {2}
Balance:       {3}
Bank name:     {4}
IBAN:          {5}
Credit card 1: {6}
Credit card 2: {7}
Credit card 3: {8}
", firstName, middleName, lastName, balance, bankName, iban, card1, card2, card3);
    }
}