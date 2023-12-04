[Serializable]
public class ChecklistGoal : Goal
{
    private int requiredTimes;
    private int bonusValue;

    private int timesCompleted;

    public ChecklistGoal(string name, int requiredTimes, int eventValue, int bonusValue) : base(name)
    {
        this.requiredTimes = requiredTimes;
        this.value = 0;
        this.timesCompleted = 0;
        this.bonusValue = bonusValue;
    }

    public override void RecordEvent()
    {
        value += eventValue;
        timesCompleted++;

        if (timesCompleted == requiredTimes)
        {
            value += bonusValue;
        }
    }

    protected override bool IsComplete()
    {
        return timesCompleted == requiredTimes;
    }

    public override string GetStatus()
    {
        return $"{base.GetStatus()} Completed {timesCompleted}/{requiredTimes} times";
    }
}
