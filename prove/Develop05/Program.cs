using System;
//accommodates additional goal types e.g negative goals.


class Program
{
    static void Main()
    {
        // Create an instance of EternalQuest
        EternalQuest myQuest = new EternalQuest();

        // Add various types of goals
        myQuest.AddGoal(new SimpleGoal("Run a Marathon", 1000));
        myQuest.AddGoal(new EternalGoal("Read Scriptures", 100));
        myQuest.AddGoal(new ChecklistGoal("Attend Temple", 50, 10, 500));
        myQuest.AddGoal(new ProgressGoal("Learn a New Language", 30, 500));
        myQuest.AddGoal(new NegativeGoal("Avoid Junk Food", 20));

        // Record events for the goals
        myQuest.RecordGoalEvent(0);  // Record progress for running a marathon
        myQuest.RecordGoalEvent(1);  // Record reading scriptures
        myQuest.RecordGoalEvent(2);  // Record attending the temple
        myQuest.RecordGoalEvent(3);  // Record progress for learning a new language
        myQuest.RecordGoalEvent(4);  // Record avoiding junk food

        // Display the current goals and total score
        myQuest.DisplayGoals();

        // Save goals to a file
        myQuest.SaveGoals("myQuestData.json");

        // Load goals from a file
        EternalQuest loadedQuest = EternalQuest.LoadGoals("myQuestData.json");
        loadedQuest.DisplayGoals();
    }
}
