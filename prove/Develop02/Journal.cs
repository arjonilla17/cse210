using System.IO;
public class Journal


{

    public void SaveToFile(List<string> saveEntries){
        Console.WriteLine("Saving to file");
        string filename = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename)){
            foreach (string entry in saveEntries){
                outputFile.WriteLine(entry);
            }
        }
    }

    public List<string> ReadFromFile(){
        Console.WriteLine("Reading file");
        List<string> savedEntries = new List<string>();
        string filename = "journal.txt";

        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines){
            Console.WriteLine(line);
        }

        return savedEntries;
    }





//     public string WriteResponse()
//     {
//         Console.WriteLine("");
//         string PromptResponse = Console.ReadLine();

//         return PromptResponse;
//     }

//     public void LoadResponse(){
//         string filename = @"C:\Users\arjon\OneDrive\Desktop\cse210\cse210\prove\Develop02\journal.txt";
//         string[] lines = System.IO.File.ReadAllLines(filename);

//         foreach (string line in lines)
//             {
//              string[] parts = line.Split(": ");

//              string prompt = parts[0];
//              string response = parts[1];
//              Console.WriteLine();
//             }
//     }

//     public void SaveResponse(Dictionary<string,string> promptsUsedDictionary){
//         string filename = @"C:\Users\arjon\OneDrive\Desktop\cse210\cse210\prove\Develop02\journal.txt";

//         foreach(KeyValuePair <string,string>pair in promptsUsedDictionary){System.IO.File.AppendAllText(filename,pair.Key+": "+pair.Value+Environment.NewLine);}

//         using (StreamWriter outputFile = new StreamWriter(filename))
//         {
//         // You can add text to the file with the WriteLine method
//         outputFile.WriteLine("This will be the first line in the file.");
    
//         // You can use the $ and include variables just like with Console.WriteLine
//         string color = "Blue";
//             outputFile.WriteLine($"My favorite color is {color}");
// }
//     }
}