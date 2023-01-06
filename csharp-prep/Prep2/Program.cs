using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);
        string letter = string.Empty;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade <= 60)
        {
            letter = "F";
        }
        Console.WriteLine($"Your Grade is: {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You Passed the Course.");
        }
        else
        {
            Console.WriteLine("You failed the Course! Better Luck next time.");
        }
        
    }   
}