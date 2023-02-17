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
    public virtual void PerformAttack(Enemy a, Attack b) {
        a.Health -= b.DamageAmount;
        Console.WriteLine($"{Name} attacks {a.Name}, dealing {b.DamageAmount} damage and reducing {a.Name}'s health to {a.Health}!!");
    }


}
// function add (a, b) {
    // var c = a + b
// }
// add(4, 3)