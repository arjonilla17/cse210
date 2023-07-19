using System;

class Program
{
    static void Main()
    {
        // Create an Address instance
        Address eventAddress = new Address("Colonial House 151 W S", "Rexburg", "Idaho");

        // Create instances of each event type
        Lecture lecture = new Lecture("Sociolog Lecture", "Learn about sociology", new DateTime(2023, 7, 25), new TimeSpan(15, 0, 0), eventAddress, "Rick Building", 50);
        Reception reception = new Reception("Fancia", "A fancy place to eat ", new DateTime(2023, 8, 10), new TimeSpan(19, 30, 0), eventAddress, "rsvp@fancia.com");
        Outdoor outdoor = new Outdoor("Nature Walk", "Enjoy the outdoors at the park", new DateTime(2023, 9, 5), new TimeSpan(10, 0, 0), eventAddress, "Nature Park");

        // Generate and print the marketing messages
        Console.WriteLine("----- Standard Details -----");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(outdoor.GetStandardDetails());

        Console.WriteLine("----- Full Details -----");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(outdoor.GetFullDetails());

        Console.WriteLine("----- Short Description -----");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine(outdoor.GetShortDescription());
    }
}
