Enemy Voldemort = new Enemy("Lord Voldemort");
Enemy Kahn = new Enemy("Kangus Kahn");

Attack Spell01 = new Attack("1st Spell", 20);
Attack Spell02 = new Attack("2nd Spell", 10);
Attack Spell03 = new Attack("3rd Spell", 30);

Attack Kick = new Attack("Kick", 15);
Attack Punch = new Attack("Punch", 30);


Voldemort.AllAttacks.Add(Spell01);
Voldemort.AllAttacks.Add(Spell02);
Voldemort.AllAttacks.Add(Spell03);

Kahn.AllAttacks.Add(Kick);
Kahn.AllAttacks.Add(Punch);

Voldemort.RandomAttack();
Kahn.RandomAttack();

Melee Harry = new Melee("Harry Potter");
Melee Ron = new Melee("Ronald Wesley");

Ranged Kirk = new Ranged("James T Kirk");
Ranged Spock = new Ranged("Spock");

MagicCaster Caspian = new MagicCaster("Prince Caspian");
MagicCaster Pheobe = new MagicCaster("Pheobe Halliwell");


// Voldemort.PerformAttack(Kahn, Spell01);

// Perform the Kick Attack from your Melee class character on your Ranged character
Harry.PerformAttack(Kirk, Harry.AllAttacks[1]);

// Perform the Rage method from your Melee class character on your Magic Caster character
Ron.PerformAttack(Caspian, Ron.Rage());
// Perform the Shoot an Arrow Attack from your Ranged character on your Melee character (if you wrote everything as listed above, you should not have been able to attack due to the Distance constraint)
Kirk.PerformAttack(Harry, Kirk.AllAttacks[0]);

// Have your Ranged character perform the Dash method
Kirk.Dash();
// Perform another Shoot an Arrow Attack from your Ranged character (this one should have worked now if everything is set up properly)
Kirk.PerformAttack(Harry, Kirk.AllAttacks[0]);
// Perform a Fireball Attack from your Magic Caster on your Melee character
Pheobe.PerformAttack(Kahn, Pheobe.AllAttacks[0]);

// Have the Magic Caster perform the Heal method on the Ranged character
Pheobe.Heal(Kirk);

// Have the Magic Caster perform the Heal method on themselves

Caspian.Heal(Caspian);
