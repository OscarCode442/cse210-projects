class Program
{
    static void Main()
    {
        TaskManager taskManager = new TaskManager();

        Task task1 = new Task("Complete project", "Finish coding the project", DateTime.Now.AddDays(7), PriorityLevel.Medium);
        ProjectTask task2 = new ProjectTask("Meeting preparation", "Prepare for the client meeting", DateTime.Now.AddDays(5), PriorityLevel.High, "Client Project");

        taskManager.AddTask(task1);
        taskManager.AddTask(task2);

        Category workCategory = new Category("Work");
        taskManager.AddCategory(workCategory);

        taskManager.DisplayAllTasks();
        taskManager.DisplayTasksByCategory("Client Project");
        taskManager.DisplayTasksByCategory("Work");
    }
}
