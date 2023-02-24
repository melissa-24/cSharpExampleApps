// Magic Caster
// Health starts at a default of 80
// Attacks:
// Fireball, 25 damage
// Lightning Bolt, 20 damage
// Staff Strike, 10 damage
// Heal method - The fighter heals a targeted Enemy character for 40 health and displays the new health at the end

class MagicCaster : Enemy {
    public MagicCaster(string theName) : base(theName) {
        Health = 80;
        AllAttacks = new List<Attack>() {
            new Attack("Fireball", 25),
            new Attack("LightningBolt", 20),
            new Attack("StaffStrike", 10)
        };
    }
    public void Heal(Enemy Target) {
        Target.Health = 100;
        this.Health -= 40;
        Console.WriteLine($"{Name}'s health is now {Health}, and {Target.Name}'s health is now back to {Target.Health}!");
    }
}