using System;

public enum Priority
{
    Low,
    Medium,
    High
}

public class Task
{
    private string title;
    private string description;
    private DateTime dueDate;
    private Priority priority;

    public Task(string title, string description, DateTime dueDate, Priority priority)
    {
        this.title = title;
        this.description = description;
        this.dueDate = dueDate;
        this.priority = priority;
    }

    public void SetTaskDetails(string title, string description, DateTime dueDate, Priority priority)
    {
        this.title = title;
        this.description = description;
        this.dueDate = dueDate;
        this.priority = priority;
    }

    public string GetTitle() => title;
    public string GetDescription() => description;
    public DateTime GetDueDate() => dueDate;
    public Priority GetPriority() => priority;
}
