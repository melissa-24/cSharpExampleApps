// Ranged Fighter
// Ranged enemies have a Distance field that tracks how far from the player the ranged enemy is (the "player" in this scenario is theoretical and does not need to be factored into the code at this time)
// The Distance field defaults to 5 upon initialization
// Attacks:
// Shoot an Arrow, 20 damage
// Throw a Knife, 15 damage
// A ranged enemy cannot perform an attack if Distance is less than 10
// Dash method - The fighter performs a dash, setting Distance to 20
// Note: Do not worry about Distance when considering if a close-range attack like a punch can hit a Ranged fighter, just assume it will for now

class Ranged : Enemy {
    public int Distance;

    public Ranged(string theName) : base(theName) {
        Distance = 5;
        AllAttacks = new List<Attack>() {
            new Attack("Arrow", 20),
            new Attack("Knife", 15)
        };
    }
    public override void PerformAttack(Enemy Target, Attack ChosenAttack) {
        if (this.Distance < 10) {
            Console.WriteLine($"{this.Name} is too close to attack");
        } else {
            base.PerformAttack(Target, ChosenAttack);
        }
    }
    public int Dash() {
        this.Distance = 20;
        Console.WriteLine($"{this.Name} has moved to attack distance");
        return this.Distance;
    }
}