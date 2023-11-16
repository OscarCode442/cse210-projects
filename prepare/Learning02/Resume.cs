namespace JobApplication
{
    public class Resume{
        public string _myName;
        public List<Job> _jobs  = new List<Job>();

        public void DisplayResume()
    {
        Console.WriteLine($"Name: {_myName}");
        Console.WriteLine("Jobs: ");

        
        foreach (Job job in _jobs)
        {
            
            job.DisplayResume();
        }
    }
    }
}