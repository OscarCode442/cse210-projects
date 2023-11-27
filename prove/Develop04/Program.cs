using System;
//A log of how many times activities were performed was added

class Program
{
    static void Main()
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();

        breathingActivity.StartActivity(3); 
        reflectionActivity.StartActivity(2); 

        Console.WriteLine($"Total Breathing Activities: {breathingActivity.GetActivityCount()}");
        Console.WriteLine($"Total Reflection Activities: {reflectionActivity.GetActivityCount()}");
    }
}
