class Player : IMethods {
    public string Name;
    public int Health;
    public List<Attack> PlayerAttackList;

    public Player(string playerName) {
        Name = playerName;
        Health = 100;
        PlayerAttackList = new List<Attack>() {
            new Attack("Punch", 22),
            new Attack("Kick", 15),
            new Attack("Spell", 50),
            new Attack("Shoot", 75)
        };
    }
    public void PrintGamer() {
        Console.WriteLine($"Player: {this.Name}, Health: {this.Health}");
    }
    public void WelcomeGamer() {
        Console.WriteLine($"Welcoome Player {this.Name}, your health is currently: {this.Health} are you ready to get started?");
    }
    public void PerformAttack(Enemy attacking, Attack attackingWith) {
        int healthStart = attacking.Health;
        if (healthStart == 0) {
            Console.WriteLine($"Sorry {this.Name} but {attacking.Name} is in the healing tent and can not be attacked at this time");
        }
        else if(healthStart <= attackingWith.DamageDelt) {
            attacking.Health = 0;
            Console.WriteLine($"{this.Name} you have delt {attacking.Name} enough damage that he can no longer be attacked and must go to the healing tent");
        }
        else {
            attacking.Health -= attackingWith.DamageDelt;
            Console.WriteLine($"{this.Name} attacks {attacking.Name}, dealing {attackingWith.DamageDelt} damage reducing {attacking.Name}'s health from {healthStart} to {attacking.Health}");
        }
    }
}