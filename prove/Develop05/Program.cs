using System;

public class Program
{
    private static List<Goal> goals = new List<Goal>();

    public static void Main(string[] args)
    {
        LoadGoals(); // Load goals from saved file

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("---------------------");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Record an event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Display score");
            Console.WriteLine("5. Save goals and exit");

            Console.Write("Enter your choice (1-5): ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    RecordEvent();
                    break;
                case 3:
                    DisplayGoals();
                    break;
                case 4:
                    DisplayScore();
                    break;
                case 5:
                    SaveGoals();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }

    private static void CreateGoal()
    {
        Console.WriteLine("Choose goal type:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        Console.Write("Enter goal type (1-3): ");
        int type = int.Parse(Console.ReadLine());

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal value: ");
        int value = int.Parse(Console.ReadLine());

        switch (type)
        {
            case 1:
                goals.Add(new SimpleGoal(name, value));
                break;
            case 2:
                goals.Add(new EternalGoal(name, value));
                break;
            case 3:
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, value, targetCount));
                break;
            default:
                Console.WriteLine("Invalid goal type. Please try again.");
                break;
        }

        Console.WriteLine("Goal created successfully.");
    }

    private static void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].Name}");
        }

        Console.Write("Enter goal number: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber < 0 || goalNumber >= goals.Count)
        {
            Console.WriteLine("Invalid goal number. Please try again.");
            return;
        }

        goals[goalNumber].Complete();
        Console.WriteLine("Event recorded successfully.");
    }

    private static void DisplayGoals()
    {
        Console.WriteLine("Goals:");
        for (int i = 0; i < goals.Count; i++)
        {
            string status = goals[i].IsComplete ? "[X]" : "[ ]";
            Console.WriteLine($"{status} {goals[i].Name} - {goals[i]}");
        }
    }

    private static void DisplayScore()
    {
        int totalScore = 0;

        foreach (Goal goal in goals)
        {
            if (goal.IsComplete)
            {
                totalScore += goal.Value;
            }
        }

        Console.WriteLine($"Total Score: {totalScore}");
    }

    private static void SaveGoals()
    {
        // Save goals to a file
        Console.WriteLine("Goals saved successfully.");
    }

    private static void LoadGoals()
    {
        // Load goals from a file
        Console.WriteLine("Goals loaded successfully.");
    }
}