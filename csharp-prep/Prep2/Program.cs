using System;

class Program
{
    static void Main(string[] args)
    {
        // asks the user to enter thier grade percentage
        Console.WriteLine("What is your grade percentage?");
        string grade_percentage = Console.ReadLine();
        int percent = int.Parse(grade_percentage);

        string letter = "";
        
        // determines users grade based from input
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // displays the users grade
        Console.WriteLine($"Your grade is: {letter}");

        // determines if the user passed or failed and then displays result
        if (percent >= 70)
        {
            Console.WriteLine("You Passed!");
        }
        else
        {
            Console.WriteLine("You failed, better luck next time.");
        }
    }
}