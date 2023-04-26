using System;

class Program
{
    static void Main(string[] args)
    {
        // asks the user for a number
        Console.Write("What is the magic number?");
        string magic_number = Console.ReadLine();
        int magic_number_int  = int.Parse(magic_number);
        
        Console.WriteLine("What is your guess?");
        string guess = Console.ReadLine();
        int user_guess = int.Parse(guess);

        while (user_guess != magic_number_int)
        {
            if (magic_number_int > user_guess)
            {
                Console.WriteLine("Higher");
                
            }

            else if (magic_number_int < user_guess)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed the magic number!");
            }
            
        }

       

    }
}