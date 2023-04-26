using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int user_number = -1;

        List<int> numbers;
        numbers = new List<int>();

        while (user_number != 0)
        {

            Console.Write("Enter number: ");
            string response = Console.ReadLine();

            user_number = int.Parse(response);

            if (user_number != 0)
            {
                numbers.Add(user_number);
            }
            
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int maximum = numbers[0];

        foreach (int number in numbers)
        {
            if (number > maximum)
                {
                    maximum = number;
                }

        }
        Console.WriteLine($"The maximum is: {maximum}");
    }
}