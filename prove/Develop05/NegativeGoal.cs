[Serializable]
public class NegativeGoal : Goal
{
    private int penaltyValue;

    public NegativeGoal(string name, int penaltyValue) : base(name)
    {
        this.penaltyValue = penaltyValue;
    }

    public override void RecordEvent()
    {
        value -= penaltyValue;

        if (value < 0)
        {
            value = 0;
        }
    }

    protected override bool IsComplete()
    {
        return false;
    }
}
