// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Player Neymar = new Player("Neymar jr.", 10, "Forward");

// Neymar._name = "Neymar jr.";
// Neymar._position = "Forward";
// Neymar._jerseyNumber = 10;

Player kobe = new Player("Kobe Bryant", 24);

kobe.SetPosition("Shooting Guard");

Console.WriteLine(kobe.Display());

Team DiamondDogs = new Team("Diamond Dogs");

DiamondDogs.AddPlayer(kobe);
DiamondDogs.AddPlayer(Neymar);

DiamondDogs.DisplayRoster();
