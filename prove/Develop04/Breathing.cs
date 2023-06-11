public class Breathing{

    Activity activity = new Activity();
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
        Console.WriteLine($"You have completed another {activity.sessionDuration} seconds of the Breathing Activity.");
    }

}