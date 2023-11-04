using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number;

        do
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            
            if (int.TryParse(input, out number))
            {
                numberList.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        } while (number != 0);

        if (numberList.Count > 0)
        {
            int sum = 0;
            int max = numberList[0];

            foreach (int num in numberList)
            {
                sum += num;
                if (num > max)
                {
                    max = num;
                }
            }

            double average = (double)sum / numberList.Count;

            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);
            Console.WriteLine("The largest number is: " + max);
        }
        else
        {
            Console.WriteLine("No numbers to calculate sum, average, and maximum.");
        }
    }
}
