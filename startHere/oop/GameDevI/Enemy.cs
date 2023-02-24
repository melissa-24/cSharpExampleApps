class Enemy {
    public string Name;
    public int Health;
    public List<Attack> AllAttacks;

    public Enemy(string theName) {
        Name = theName; // Has no default value must be declare on creation
        Health = 100; // every enemy starts with a default health of 100 no need to declare this as they are all the same
        AllAttacks = new List<Attack>(); // everyone starts with no skill (attacks) but can earn / add them at any time. so we create a default empty list
    }

    public void RandomAttack() {
        Random rand = new Random();
        int attack = rand.Next(AllAttacks.Count);
        Console.WriteLine($"{Name} attacks with {AllAttacks[attack].Name}");
    }
}