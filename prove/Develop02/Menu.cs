public class Menu
{
   
Dictionary<string,string> _usedPrompts = new Dictionary<string,string>();
Prompt prompt = new Prompt();
Journal journal = new Journal();

Entries entries = new Entries();
    public void Display()
    {
        string response = "";
        string[] options = {"1","2","3","4","5"};
        while(response!="5")
        {
            while(options.Contains(response)==false)
            {
                Console.WriteLine("Please select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Load");
                Console.WriteLine("4. Save");
                Console.WriteLine("5. Quit");
                Console.WriteLine("What do you want to do? ");
                response = Console.ReadLine() ?? String.Empty;
                response = response.ToUpper();
            }
            switch (response)
            {
                case "1":

                    DateTime theCurrentTime = DateTime.Now;
                    entries.date = theCurrentTime.ToShortDateString();

                    Console.WriteLine("Rate the day (1-10): ");
                    entries.rating = Console.ReadLine();

                    entries.prompt = prompt.GetRandomPrompt();
                    // Console.WriteLine($"{entries.prompt}");

                    entries.entry = Console.ReadLine();

                    entries.saveEntries.Add(entries.Display());
                    
                    // string currentPrompt = prompt.GetRandomPrompt();
                    // string currentResponse = journal.WriteResponse();

                    // _usedPrompts.Add(currentPrompt,currentResponse);
                    break;
                case "2":
                    // prompt.displayPrompts(_usedPrompts);
                    entries.entriesList();
                    break;
                case "3":
                    // journal.LoadResponse();
                    List<string> savedEntries = journal.ReadFromFile();
                    foreach (string entry in savedEntries){
                        Console.WriteLine(entry);
                    }
                    break;
                case "4":
                    // journal.SaveResponse(_usedPrompts);
                    journal.SaveToFile(entries.saveEntries);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;  

            }
            response = "";
        }
    }
}