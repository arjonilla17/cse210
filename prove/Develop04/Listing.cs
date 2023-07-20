class Listing : Mindfulness
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("Let's begin:");
        Random random = new Random();
        int totalCount = 0;

        for (int i = 1; i <= Duration; i++)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(3000); 

            Console.Write("Start listing (separate items by commas): ");
            string[] items = Console.ReadLine().Split(',');
            int itemLength = items.Length;
            totalCount += itemLength;

            Console.WriteLine($"You listed {itemLength} items.");
            Thread.Sleep(2000); 
        }

        Console.WriteLine($"You listed a total of {totalCount} items during the activity.");
        Finish();
    }
}
