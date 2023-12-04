[Serializable]
public class SimpleGoal : Goal
{
    private int completionValue;

    public SimpleGoal(string name, int completionValue) : base(name)
    {
        this.completionValue = completionValue;
    }

    public override void RecordEvent()
    {
        value += completionValue;
    }

    protected override bool IsComplete()
    {
        return true;
    }
}
