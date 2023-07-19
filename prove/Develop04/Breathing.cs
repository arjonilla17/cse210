public class Breathing :Activity{

    Activity activity = new Activity();
    int result;
    public void breathingBase(){
        Console.WriteLine("Welcome to the Breathing Activity!");
        Console.WriteLine("");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("");
    }

    public void overideDisplay(){
        
    }

     public void breathingEndMessage(){
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        result = _seconds / 1000;
        Console.WriteLine($"You have completed another {result} seconds of the Breathing Activity.");
    }

}