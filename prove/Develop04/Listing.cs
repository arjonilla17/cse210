public class Listing{
    Activity activity = new Activity();
    private List<string> _prompts = new List<string>();

    private List<string> _usedPrompts = new List<string>();

    public List<string> _entries = new List<string>();

    public void listingBase(){
        Console.WriteLine("Welcome to the Listing Activity!");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine("");
    }
    
    public void countEntries(){

    }

    private void overideDisplay(){

    }

    public void listingEndMessage(){
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {activity.sessionDuration} seconds of the Listing Activity.");
    }

}