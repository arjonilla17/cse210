using System;

class Program
{
    static void Main(string[] args)
    {
        // asks the user for a number
        Console.Write("What is the magic number?");
        int magic_number  = int.Parse(Console.ReadLine());
        
       
        int guess = -1;

        while (guess != magic_number)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());

            if (magic_number > guess)
            {
                Console.WriteLine("Higher");
                
            }

            else if (magic_number < guess)
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