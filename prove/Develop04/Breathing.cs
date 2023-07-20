class Breathing : Mindfulness
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Let's begin:");
        for (int i = 1; i <= Duration; i++)
        {
            if (i % 2 == 1)
                Console.WriteLine("Breathe in...");
            else
                Console.WriteLine("Breathe out...");

            Thread.Sleep(1000);
        }
        Finish();
    }
}