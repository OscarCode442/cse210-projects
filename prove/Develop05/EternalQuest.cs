using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

[Serializable]
public class EternalQuest
{
    private List<Goal> goals;
    private int totalScore;

    public EternalQuest()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordGoalEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent();
            totalScore += goals[goalIndex].GetValue();
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetStatus());
        }

        Console.WriteLine($"Total Score: {totalScore}");
    }

    public void SaveGoals(string filePath)
    {
        string json = JsonSerializer.Serialize(this);
        File.WriteAllText(filePath, json);
    }

    public static EternalQuest LoadGoals(string filePath)
    {
        string json = File.ReadAllText(filePath);
        return JsonSerializer.Deserialize<EternalQuest>(json);
    }
}
