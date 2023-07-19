class Scripture
{
    private List<Word> words;
    private Reference reference;

    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        ParseText(text);
    }

    private void ParseText(string text)
    {
        words = new List<Word>();
        string[] wordArray = text.Split(' ');

        foreach (string wordText in wordArray)
        {
            words.Add(new Word(wordText));
        }
    }

    public void Display()
    {
        Console.WriteLine(reference.Text);
        foreach (Word word in words)
        {
            if (word.IsHidden)
                Console.Write("____ ");
            else
                Console.Write(word.Text + " ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        List<Word> visibleWords = words.FindAll(word => !word.IsHidden);

        if (visibleWords.Count == 0)
        {
            Console.WriteLine("Congratulations! You have memorized the entire scripture!");
            Environment.Exit(0);
        }

        int randomIndex = random.Next(visibleWords.Count);
        visibleWords[randomIndex].Hide();
    }
}