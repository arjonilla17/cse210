class Mindfulness
{
    protected string ActivityName;
    protected string Description;
    protected int Duration;

    public Mindfulness(string activityName, string description)
    {
        ActivityName = activityName;
        Description = description;
        Duration = 0;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Welcome to {ActivityName} Activity!");
        Console.WriteLine(Description);
        Console.Write("Enter the duration of the activity in seconds: ");
        Duration = int.Parse(Console.ReadLine());

        Console.WriteLine("Get ready to begin in:");
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

    public void Finish()
    {
        Console.WriteLine($"Great job! You have completed the {ActivityName} Activity for {Duration} seconds.");
        Console.WriteLine();
        Thread.Sleep(2000);
    }
}