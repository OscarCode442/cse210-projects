using System;
using System.Threading;

class MindfulnessActivity
{
    protected string name;
    protected string description;
    protected int activityCount;

    public MindfulnessActivity(string name, string description)
    {
        this.name = name;
        this.description = description;
        this.activityCount = 0;
    }

    public void StartActivity(int duration)
    {
        activityCount++;
        ShowStartingMessage();
        PerformActivity(duration);
        ShowEndingMessage();
    }

    public int GetActivityCount()
    {
        return activityCount;
    }

    protected virtual void ShowStartingMessage()
    {
        Console.WriteLine($"Get ready for {name} - {description}");
        Thread.Sleep(3000); // Pause for preparation
    }

    protected virtual void ShowEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed {name}. You have done this activity {activityCount} times.");
        Thread.Sleep(3000); // Pause before finishing
    }

    protected virtual void PerformActivity(int duration)
    {
        // Common implementation for activities
    }
}
