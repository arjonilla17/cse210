public class Entries{
    public string prompt;
    public string date;

    public string entry;

    public string rating;

    public List<string> saveEntries = new List<string>();

    Program program = new Program();

    public string Display(){
        return $"{date} - {prompt}\nRating: {rating}\nEntry: {entry}";
    }

    public void entriesList(){
        foreach (string displayEntry in saveEntries){
            Console.WriteLine(displayEntry);
        }
    }
}