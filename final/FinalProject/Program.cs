class Program
{
    static void Main()
    {
        // Example usage
        TaskManager taskManager = new TaskManager();
        Task task1 = new Task("Complete project", "Finish coding the project", DateTime.Now.AddDays(7), Priority.High);
        taskManager.AddTask(task1);

        Task task2 = new Task("Study for exam", "Prepare for upcoming exam", DateTime.Now.AddDays(5), Priority.Medium);
        taskManager.AddTask(task2);

        taskManager.ShowAllTasks();
    }
}
