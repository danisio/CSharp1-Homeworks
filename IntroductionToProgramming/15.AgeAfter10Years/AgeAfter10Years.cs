/*Problem 15.* Age after 10 Years
Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.
 */
 
using System;

class AgeAfter10Years
    {
        static void Main()
        {
            Console.WriteLine("Enter your birthdate in format dd.mm.yyyy");
            DateTime dateBirth = DateTime.Parse(Console.ReadLine());
            DateTime dateToday = DateTime.Now;
            int age = dateToday.Year - dateBirth.Year;

            if (dateToday.Month < dateBirth.Month || (dateToday.Month == dateBirth.Month && dateToday.Day < dateBirth.Day))
            {
                age--;
            }
            Console.WriteLine("You are {0} years old. In 10 years you'll be {1}.", age, age + 10);
        }
    }