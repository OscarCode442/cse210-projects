using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade Percentage? ");
        string percentage = Console.ReadLine();
        
        int percentageNumber = int.Parse(percentage);
        string letter = string.Empty;
       
        if (percentageNumber >= 90)
        {
            letter = "A";
        }
        else if (percentageNumber >= 80)
        {
            letter = "B";
        }
        else if (percentageNumber >= 70)
        {
            letter = "C";
        }
        else if (percentageNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = percentageNumber % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        Console.WriteLine($"Your Grade is {letter}{sign}");

        if (percentageNumber >= 70)
        {
            Console.WriteLine("Congratulations! You Passed the Course!");
        }
        else 
        {
            Console.WriteLine("Try hard Next Time ");
        }
    }
}
