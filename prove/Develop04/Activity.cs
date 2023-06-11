public class Activity{
    protected string _name;

    protected string _description;

    protected int _seconds;

    private string _endMessage;

    public int sessionDuration;

    public void activityDuration(){
        Console.WriteLine("How long, in seconds, would you like for your session?");
        int sessionDuration = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Your session will last for: " + sessionDuration + " seconds");
        Console.WriteLine("");
    }

    public void display(){

    }

    public void setSeconds(){

    }

    public void pause(){

    }

    public void couuntdown(){

    }

    public void spin(){
        
    }
}