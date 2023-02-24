Caster harry = new Caster("Harry Potter");
Caster ron = new Caster("Ron Weasly");

Melee kirk = new Melee("James T. Kirk");
Melee spock = new Melee("Ambassador Spock");

Ranged darth = new Ranged("Darth Vader");
Ranged kahn = new Ranged("Khan Noonien Singh");

List<Enemy> npc = new List<Enemy>() {
    harry,
    ron,
    kirk,
    spock,
    darth,
    kahn
};

Player computer = new Player("Queen Bee");
Random rand = new Random();

bool playing = true;
while(playing) {
    Console.WriteLine($"Welcome quest seeker, I am your narrator {computer.Name}, what shall I call you?");
    Player user = new Player(Console.ReadLine());
    user.WelcomeGamer();
    string answer = Console.ReadLine();
    if(answer == "yes") {
        Console.WriteLine($"Wonderful news {user.Name}! Let me introduce you to the NPC's");
        foreach(var nonPlayer in npc) {
            Console.WriteLine($"{nonPlayer.Name}");
        }
    }
    else {
        Console.WriteLine($"Sorry to see you go {user.Name}, but thank you for checking out our gmae");
        playing = false;
    }
    Console.WriteLine("Time to get the battle started.  Would you like to chose your opponent or let me chose one for you?");
    Console.WriteLine("Please chose 1 to chose your opponent or 2 to allow me to chose");
    answer = Console.ReadLine();
    if(answer == "1" ) {
        Console.WriteLine($"Interesting, please chose from the following");
        Console.WriteLine($"1. {harry.Name}");
        Console.WriteLine($"2. {ron.Name}");
        Console.WriteLine($"3. {kirk.Name}");
        Console.WriteLine($"4. {spock.Name}");
        Console.WriteLine($"5. {darth.Name}");
        Console.WriteLine($"6. {kahn.Name}");
        int newAnswer = Convert.ToInt32(Console.ReadLine());
        newAnswer = newAnswer-1;
        if(newAnswer > 0 && newAnswer < 7) {
            string playerChoice = npc[newAnswer].Name;
            Console.WriteLine($"{user.Name}, you have made a fine choice in {playerChoice}");
        }

    }
    else if(answer == "2") {
        Console.WriteLine($"Very interesting {user.Name}, that is quite a risk letting me choose");
        Console.WriteLine("Let me think on this a min");
        Console.WriteLine("thinking ......");
        Console.WriteLine("thinking ......");
        Console.WriteLine("thinking ......");
        Console.WriteLine("thinking ......");
        Console.WriteLine("thinking ......");
        Console.WriteLine("thinking ......");
        Console.WriteLine("thinking ......");
        int randNpc = rand.Next(npc.Count);
        Console.WriteLine($"Ok {user.Name} I believe I have a good choice for you.");
        string ComputerChoice = npc[randNpc].Name;
        Console.WriteLine($"I {computer.Name} being of sound mind and body have chosen for your first battle {ComputerChoice}");
    }
    else {
        Console.WriteLine($"Sorry {user.Name}, your choice was outside the bound of the choices I provided your the game will now exit.");
    }
    playing = false;
}