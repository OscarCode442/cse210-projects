using System;
using System.Collections.Generic;

public class TaskManager
{
    private List<Task> tasks = new List<Task>();

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void EditTask(Task task)
    {
        // Logic for editing a task
    }

    public void DeleteTask(Task task)
    {
        tasks.Remove(task);
    }

    public void ShowTaskDetails(Task task)
    {
        Console.WriteLine($"Task Details:\nTitle: {task.GetTitle()}\nDescription: {task.GetDescription()}\nDue Date: {task.GetDueDate()}\nPriority: {task.GetPriority()}");
    }

    public void ShowAllTasks()
    {
        Console.WriteLine("All Tasks:");
        foreach (var task in tasks)
        {
            ShowTaskDetails(task);
            Console.WriteLine("--------------");
        }
    }
}
