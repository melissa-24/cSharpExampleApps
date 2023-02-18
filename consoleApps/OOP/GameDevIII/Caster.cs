class Caster : Enemy {
    public Caster(string theName) : base(theName) {
        Health = 80;
        AttackList = new List<Attack>() {
            new Attack("Fireball", 25),
            new Attack("LightningBolt", 20),
            new Attack("StaffStrike", 10)
        };
    }
    public void Heal(Enemy toHeal) {
        if(toHeal.Health > 100) {
            Console.WriteLine($"{toHeal.Name} is already at max health and does not need to heal");
        } 
        if (this.Health <= 40) {
            Console.WriteLine($"Sorry {this.Name} but you do not have enough health to heal {toHeal.Name}, please go to the healing tent");
        }
        else {
            toHeal.Health = 100;
            this.Health -= 40;
            Console.WriteLine($"{Name}'s health is now {Health}, and {toHeal.Name}'s health is now back to {toHeal.Health}!");
        }
    }
}