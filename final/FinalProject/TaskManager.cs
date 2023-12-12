using System;
using System.Collections.Generic;

public class TaskManager
{
    private List<Task> tasks;
    private List<Category> categories;

    public TaskManager()
    {
        tasks = new List<Task>();
        categories = new List<Category>();
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void AddCategory(Category category)
    {
        categories.Add(category);
    }

    public void DisplayAllTasks()
    {
        foreach (var task in tasks)
        {
            task.DisplayTaskDetails();
            Console.WriteLine();
        }
    }

    public void DisplayTasksByCategory(string categoryName)
    {
        var tasksInCategory = tasks.FindAll(task => task is ProjectTask && ((ProjectTask)task).ProjectName == categoryName);
        Console.WriteLine($"Tasks in Category: {categoryName}");
        foreach (var task in tasksInCategory)
        {
            task.DisplayTaskDetails();
            Console.WriteLine();
        }
    }
}
