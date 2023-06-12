public class Menu{
    Activity activity = new Activity();
    Breathing breathing = new Breathing();
    Reflection reflection = new Reflection();
    Listing listing = new Listing();
    public void displayMenu(){
        string response = "";
        string[] options = {"1","2","3","4"};
        while(response!="4")
        {
        
            while(options.Contains(response)==false)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflection Activity");
                Console.WriteLine("3. Start Listing Activity");
                Console.WriteLine("4. Quit");
                Console.WriteLine("What do you want to do? (Type an option number) ");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }
            switch (response)
            {
                case "1":
                    breathing.breathingBase();
                    activity.activityDuration();
                    // activity.pause();
                    breathing.breathingEndMessage();
                    
                    break;
                case "2":
                    reflection.reflectionBase();
                    activity.activityDuration();
                    reflection.reflectionEndMessage();
                    break;
                case "3":
                    listing.listingBase();
                    activity.activityDuration();
                    listing.listingEndMessage();
                    break;
                case "4":
                    // exit out of the program
                    Environment.Exit(0);
                    break;

            }
            response = "";
        }
    }
}