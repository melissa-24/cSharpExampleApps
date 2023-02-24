class Enemy : IMethods {
    public string Name;
    public int Health;
    public List<Attack> AttackList;

    public Enemy(string enemyName) {
        Name = enemyName;
        Health = 100;
        AttackList = new List<Attack>();
    }

    // Methods start here

    public void RandAttack() {
        Random rand = new Random();
        int randNum = rand.Next(AttackList.Count);
        Console.WriteLine($"{this.Name} will attack with {AttackList[randNum].Name}");
    }
    public void PrintGamer() {
        Console.WriteLine($"NPC: {this.Name}, Health: {this.Health}");
    }
    public virtual void PerformAttack(Enemy beingAttacked, Attack attackWith) {
        int healthStart = beingAttacked.Health;
        if (healthStart == 0) {
            Console.WriteLine($"Sorry {this.Name} but {beingAttacked.Name} is in the healing tent and can not be attacked at this time");
        }
        else if(healthStart <= attackWith.DamageDelt) {
            beingAttacked.Health = 0;
            Console.WriteLine($"{this.Name} you have delt {beingAttacked.Name} enough damage that he can no longer be attacked and must go to the healing tent");
        }
        else {
            beingAttacked.Health -= attackWith.DamageDelt;
            Console.WriteLine($"{this.Name} attacks {beingAttacked.Name}, dealing {attackWith.DamageDelt} damage reducing {beingAttacked.Name}'s health from {healthStart} to {beingAttacked.Health}");
        }
    }
}