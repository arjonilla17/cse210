public class ChecklistGoal : Goal
{
    public int TargetCount { get; set; }
    private int completedCount;

    public ChecklistGoal(string name, int value, int targetCount) : base(name, value)
    {
        TargetCount = targetCount;
        completedCount = 0;
    }

    public override void Complete()
    {
        completedCount++;
        if (completedCount == TargetCount)
            IsComplete = true;
    }

    public override string ToString()
    {
        return $"Completed {completedCount}/{TargetCount} times";
    }
}