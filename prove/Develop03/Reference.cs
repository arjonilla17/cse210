public class Reference{

string reference;

List<string> _references = new List<string>();

public Reference()
{
    _references.Add("John 3:16");
    _references.Add("Proverbs 3:5-6");
    _references.Add("2 Nephi 31:20");
}


// public Reference(string reference){
//     this.reference = reference;
// }


// public string GetRandomPrompt()
//     {
//         var random = new Random();
//         var randomNumber = random.Next(0,_prompts.Count);
//         NicePrint(_prompts[randomNumber]);

//         return _references[randomNumber];
    
// }

}