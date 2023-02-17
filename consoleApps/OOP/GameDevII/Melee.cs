// Melee Fighter
// Health starts at a default of 120
// Attacks:
// Punch, 20 damage
// Kick, 15 damage
// Tackle, 25 damage
// Rage method - The fighter performs a random attack from its AttackList, but the attack deals 10 extra damage
// Hint: How will you handle updating the DamageAmount of your attack when you perform the attack?

class Melee : Enemy {

    public Melee(string theName) : base(theName) {
        Health = 120;
        AllAttacks = new List<Attack>() {
            new Attack("Punch", 20),
            new Attack("Kick", 15),
            new Attack("Tackle", 25)
        };
    }
    public Attack Rage() {
        Random rand = new Random();
        int attack = rand.Next(AllAttacks.Count);
        AllAttacks[attack].DamageAmount += 10;
        Console.WriteLine($"{AllAttacks[attack].Name} new damage delt {AllAttacks[attack].DamageAmount}");
        return AllAttacks[attack];
    }

}