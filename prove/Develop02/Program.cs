using System;
    class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal program!");
        // Prompt prompt = new Prompt();
        // prompt.GetRandomPrompt();

        Menu menu = new Menu();
        Journal journal = new Journal();
        menu.Display();
    }
    
}
