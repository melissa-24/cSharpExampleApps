class Melee : Enemy {

    public Melee(string theName) : base(theName) {
        Health = 120;
        AttackList = new List<Attack>() {
            new Attack("Punch", 20),
            new Attack("Kick", 15),
            new Attack("Tackle", 25)
        };
    }
    public Attack Rage() {
        Random rand = new Random();
        int attack = rand.Next(AttackList.Count);
        AttackList[attack].DamageDelt += 10;
        Console.WriteLine($"{AttackList[attack].Name} new damage delt {AttackList[attack].DamageDelt}");
        return AttackList[attack];
    }

}