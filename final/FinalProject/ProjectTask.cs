public class ProjectTask : Task
{
    public string ProjectName { get; set; }

    public ProjectTask(string title, string description, DateTime dueDate, PriorityLevel priority, string projectName)
        : base(title, description, dueDate, priority)
    {
        ProjectName = projectName;
    }

    public override void DisplayTaskDetails()
    {
        base.DisplayTaskDetails();
        Console.WriteLine($"Project: {ProjectName}");
    }
}
