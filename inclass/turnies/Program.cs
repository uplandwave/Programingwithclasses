// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Player ronaldo = new Player("Christianaldo Ronaldo", 7);
ronaldo.Display();

Player messi = new Player("Lional Messi", 7);
messi.Display();

Team fire = new Team("Fire");
fire.AddPlayer(ronaldo);
fire.AddPlayer(messi);
fire.DisplayRoster();