// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Book mistborn = new Book("Mistborn","Brandon Sanderson");

mistborn.Display();

Book Mazerunner = new Book("MazeRunner", "James Dashner");

Mazerunner.Display();

Console.WriteLine(mistborn.IsAvailable());
Console.WriteLine(Mazerunner.IsAvailable());
