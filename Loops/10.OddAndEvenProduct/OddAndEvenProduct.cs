/* Problem 10.	Odd and Even Product
You are given `n` integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from `1` to `n`, so the first element is odd, the second is even, etc.
 */
 
using System;

    class OddAndEvenProduct
    {
        static void Main()
        {
            Console.Write("Enter numbers separated by a space: ");
            string input = Console.ReadLine();
            string[] myArray = input.Split(' ');

            int oddProduct = 1;
            int evenProduct = 1;
            
            for (int i = 0; i < myArray.Length; i++)
			{
                int currentNumber = int.Parse(myArray[i]);
                if (i % 2 == 0)
                {
                    oddProduct *= currentNumber;
                }
                else if (i % 2 != 0)
                {
                    evenProduct *= currentNumber;
                }			 
			}

            bool equal = oddProduct == evenProduct;
            if (equal)
            {
                Console.WriteLine("Yes\nProduct = {0}", oddProduct);
            }
            else
            {
                Console.WriteLine("No\nOdd Product = {0}\nEven Product = {1}", oddProduct, evenProduct);
            }
        }
    }
