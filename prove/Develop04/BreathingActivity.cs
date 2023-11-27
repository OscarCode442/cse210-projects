using System;
using System.Threading;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing Activity", "Relax by breathing in and out slowly.")
    {
    }

    protected override void PerformActivity(int duration)
    {
        Console.WriteLine("Let's begin with deep breathing...");

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
        }
    }
}
