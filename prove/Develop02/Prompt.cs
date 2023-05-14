public class Prompt
{

    
    List<string> _prompts = new List<string>();
    //methods

    public Prompt()
    {
        _prompts.Add("How was your day?");
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
    }

     public void NicePrint(string item)
    {
        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"{item}");
        Console.WriteLine("-----------------------------------");
    }

     public string Getprompts()
    {
        return $"{_prompts}";
    }
    public string GetRandomPrompt()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_prompts.Count);
        NicePrint(_prompts[randomNumber]);

        return _prompts[randomNumber];

        // return "This is a prompt";
        // Console.WriteLine(randomNumber);
    }

    // public void displayPrompts(Dictionary<string,string> promptsUsedDictionary)
    // {
    //     foreach(KeyValuePair <string,string>pair in promptsUsedDictionary){Console.WriteLine(pair.Key+": "+pair.Value);}
    // }
}