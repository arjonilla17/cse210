using System;

class Program
{
    static void Main(string[] args)
    {
        // asks user to enter thier first name
        Console.WriteLine("What is your first name?");
        string first_name = Console.ReadLine();

        // asks user to enter thier last name
        Console.WriteLine("What is your last name?");
        string last_name = Console.ReadLine();

        // spacer
        Console.WriteLine("");

        // prints the users first and last name in a james bond format
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}