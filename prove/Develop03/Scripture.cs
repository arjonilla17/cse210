public class Scripture{

List<string> _scriptures = new List<string>();
// Reference reference = new Reference();

public Scripture()
{
    _scriptures.Add("For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life. ");
    _scriptures.Add("Trust in the Lord woth all thine heart; and lean not unto thine own understanding.  In all thy ways acknowledge him, and he shall direct thy paths. ");
    _scriptures.Add("Wherefore, ye must press forward with a steadfastness in Christ, having a perfect brightness of hope, and a love of God and of all men. Wherefore, if ye shall press fprward, feasting upon the word of Christ, and endure to the end, behold, thus saith the Father: Ye shall have eternal life.");
}

public string getScripture()
    {
        var random = new Random();
        var randomNumber = random.Next(0,_scriptures.Count);
        Console.WriteLine(randomNumber);
        Console.WriteLine(_scriptures[randomNumber]);
        return _scriptures[randomNumber];
    }

public void promptUser(){
    string response = " ";
    while(response != "quit")
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            response = Console.ReadLine() ?? String.Empty;
            response = response.ToLower();
            
            switch (response){
                case "":
                   Console.WriteLine("test");
                   
                //    reference.randomScripture();
                    getScripture();
                break;
                case "quit":
                    Environment.Exit(0);
                break;


            }

        }
    }
}