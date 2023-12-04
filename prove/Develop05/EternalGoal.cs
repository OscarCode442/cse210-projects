[Serializable]
public class EternalGoal : Goal
{
    private int eventValue;

    public EternalGoal(string name, int eventValue) : base(name)
    {
        this.eventValue = eventValue;
    }

    public override void RecordEvent()
    {
        value += eventValue;
    }

    protected override bool IsComplete()
    {
        return false;
    }
}
