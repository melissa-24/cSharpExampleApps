class Enemy {
    public string Name;
    public int Health;
    public List<Attack> AllAttacks;

    public Enemy(string theName) {
        Name = theName;
        Health = 100;
        AllAttacks = new List<Attack>();
    }

    public void RandomAttack() {
        Random rand = new Random();
        int attack = rand.Next(AllAttacks.Count);
        Console.WriteLine($"{Name} attacks with {AllAttacks[attack].Name}");
    }
}