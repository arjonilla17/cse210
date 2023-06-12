public class Activity{

    protected string _name;

    protected string _description;

    protected int _seconds;

    private string _endMessage;

    public int sessionDuration;

    public void activityDuration(){
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int sessionDuration = int.Parse(Console.ReadLine());
        Console.WriteLine("Your session will last for: " + sessionDuration + " seconds");
        Console.WriteLine("");
        //
        pause();
        
    }

    public void display(){

    }

    public void setSeconds(){

    }

    public void pause(){
        Console.WriteLine("Get ready...");
        _seconds = sessionDuration * 1000;
        Console.WriteLine(_seconds);
        Console.Write("+");
        Thread.Sleep(_seconds);
        Console.Write("\b \b");
        Console.Write("-"); 


    }

    public void couuntdown(){

    }

    public void spin(){
        
    }
}