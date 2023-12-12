using System;

public enum PriorityLevel
{
    Low,
    Medium,
    High
}

public class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public PriorityLevel Priority { get; set; }

    public Task(string title, string description, DateTime dueDate, PriorityLevel priority)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        Priority = priority;
    }

    public virtual void DisplayTaskDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Description: {Description}");
        Console.WriteLine($"Due Date: {DueDate}");
        Console.WriteLine($"Priority: {Priority}");
    }
}
