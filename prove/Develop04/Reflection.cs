public class Reflection{

    Activity activity = new Activity();
    

     private List<string> _prompts = new List<string>();

    private List<string> _usedPrompts = new List<string>();
    public void reflectionBase(){

        Console.WriteLine("Welcome to the Reflection Activity");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.WriteLine("");

    }

    public void getPrompt(){

    }

    public void display(){

    }

    public void reflectionEndMessage(){
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {activity.sessionDuration} seconds of the Reflection Activity.");
    }
}