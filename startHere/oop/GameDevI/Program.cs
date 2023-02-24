Enemy Voldemort = new Enemy("Lord Voldemort");

Attack Spell01 = new Attack("1st Spell", 20);
Attack Spell02 = new Attack("2nd Spell", 10);
Attack Spell03 = new Attack("3rd Spell", 30);

Voldemort.AllAttacks.Add(Spell01);
Voldemort.AllAttacks.Add(Spell02);
Voldemort.AllAttacks.Add(Spell03);

Voldemort.RandomAttack();