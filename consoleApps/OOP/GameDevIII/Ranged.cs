class Ranged : Enemy {
    public int Distance;

    public Ranged(string theName) : base(theName) {
        Distance = 5;
        AttackList = new List<Attack>() {
            new Attack("Arrow", 20),
            new Attack("Knife", 15)
        };
    }
    public override void PerformAttack(Enemy beingAttacked, Attack attackWith) {
        if (this.Distance < 10) {
            Console.WriteLine($"{this.Name} is too close to attack");
        } else {
            base.PerformAttack(beingAttacked, attackWith);
        }
    }
    public int Dash() {
        this.Distance = 20;
        Console.WriteLine($"{this.Name} has moved to attack distance");
        return this.Distance;
    }
}