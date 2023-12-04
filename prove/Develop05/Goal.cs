using System;

[Serializable]
public abstract class Goal
{
    protected string name;
    protected int value;

    public Goal(string name)
    {
        this.name = name;
        this.value = 0;
    }

    public abstract void RecordEvent();

    public virtual string GetStatus()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {name}";
    }

    protected abstract bool IsComplete();

    public int GetValue()
    {
        return value;
    }
}
