[Serializable]
public class ProgressGoal : Goal
{
    private int progressValue;
    private int targetValue;

    public ProgressGoal(string name, int progressValue, int targetValue) : base(name)
    {
        this.progressValue = progressValue;
        this.targetValue = targetValue;
    }

    public override void RecordEvent()
    {
        value += progressValue;

        if (value > targetValue)
        {
            value = targetValue;
        }
    }

    protected override bool IsComplete()
    {
        return value == targetValue;
    }
}
