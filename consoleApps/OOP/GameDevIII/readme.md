# Game Developer III

## Step 1 (Game Developer I)

### Scenario: 
- You are working alongside a team of game developers on your next big project! It will be an exciting platform game with tons of levels to explore and enemies to face. You have been tasked with building the enemies and combat system for the game. Your colleagues are already hard at work on the other elements, and what they really need from you right now is a basic Enemy class and an Attack class to get things going.

### Follow the guidelines below to build out your Enemy and Attack classes:

#### The Attack Class:
- Attack fields:
    - Name (i.e. fireball, punch, throw)
    - DamageAmount (i.e. a fireball will do 20 damage, keep the damage range between 5 and 25)
    - Constructor: When an Attack is created, we must specify the Name and DamageAmount upon creation

#### The Enemy Class:
- Enemy fields:
    - Name (i.e. Bandit, Boss, Guard)
    - Health
    - AttackList -- This will be a List of type Attack that will hold the various Attacks an enemy can perform
    - Constructor: 

- When an Enemy is created, we must provide their Name upon creation
- Health will start at a default value of 100
- AttackList will initialize as an empty List

#### Methods:
- RandomAttack: the enemy object performs a randomized attack from their AttackList (hint: remember Random()?)
### Testing:
- Create an instance of an Enemy in Program.cs (you can create any enemy you would like)
- Create 3 instances of Attacks in Program.cs (again, you can create any attacks you would like. Have fun with it!)
- Add the three Attacks to your Enemy instance's AttackList (hint: how do you add items to a List?)
- Call your Enemy instance's RandomAttack method to test that a random Attack can be called on (a good developer will run this multiple times to ensure there are no bugs)
- Once you have confirmed your code is functional your part is done! Your colleagues will use your code for testing and ask for it to be developed further a little later...


## Step 2 (Game Developer II)

### Review the list of added features your colleagues would like and get coding:
- To get started, you need to add a new method to your existing Enemy class: a PerformAttack() method. This method should take in a Target (for now you will use other Enemies as Targets) and a specified Attack to perform from the enemy's available AttackList. The method should reduce the Health of the Target based on the DamageAmount provided by the Attack. Here is some code to get you started:

```
// Inside of the Enemy class
public void PerformAttack(Enemy Target, Attack ChosenAttack)
{
    // Write some logic here to reduce the Targets health by your Attack's DamageAmount
    Console.WriteLine($"{Name} attacks {Target.Name}, dealing {Attack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
}
```
- Once you have your PerformAttack() method ready, the next step is to create three unique classes that inherit from your Enemy class: a melee fighter class, a ranged fighter class, and a magic caster class. Each enemy type comes with its own set of Attacks and methods, as outlined below.

#### Melee Fighter
- Health starts at a default of 120
- Attacks:
    - Punch, 20 damage
    - Kick, 15 damage
    - Tackle, 25 damage
- Rage method - The fighter performs a random attack from its AttackList, but the attack deals 10 extra damage
- Hint: How will you handle updating the DamageAmount of your attack when you perform the attack?

#### Ranged Fighter
- Ranged enemies have a Distance field that tracks how far from the player the ranged enemy is (the "player" in this scenario is theoretical and does not need to be factored into the code at this time)
- The Distance field defaults to 5 upon initialization
- Attacks:
    - Shoot an Arrow, 20 damage
    - Throw a Knife, 15 damage
- A ranged enemy cannot perform an attack if Distance is less than 10
- Dash method - The fighter performs a dash, setting Distance to 20
- Note: Do not worry about Distance when considering if a close-range attack like a punch can hit a Ranged fighter, just assume it will for now

#### Magic Caster
- Health starts at a default of 80
- Attacks:
    - Fireball, 25 damage
    - Lightning Bolt, 20 damage
    - Staff Strike, 10 damage
- Heal method - The fighter heals a targeted Enemy character for 40 health and displays the new health at the end

### Once all your classes are created, complete the following series of actions to test all your new code:
- Create instances of the Melee, Ranged, and Magic Caster classes
- Perform the Kick Attack from your Melee class character on your Ranged character
- Perform the Rage method from your Melee class character on your Magic Caster character
- Perform the Shoot an Arrow Attack from your Ranged character on your Melee character (if you wrote everything as listed above, you should not have been able to attack due to the Distance constraint)
- Have your Ranged character perform the Dash method
- Perform another Shoot an Arrow Attack from your Ranged character (this one should have worked now if everything is set up properly)
- Perform a Fireball Attack from your Magic Caster on your Melee character
- Have the Magic Caster perform the Heal method on the Ranged character
- Have the Magic Caster perform the Heal method on themselves

### Bonuses
- Write special Console messages for each fighter's PerformAttack method
- You can add even more detail by considering what types of messages would appear for specific attacks
- You may have noticed that when you Heal a character they can end up with more health than they started with. Can you think of a clever way to ensure that your character does not go above their maximum health?
- Conversely, do you think a character should be able to attack another character who has 0 health? Or that a character with 0 health should be capable of attacking? How can you ensure that a character can only be attacked/perform attacks so long as their health is a positive value?
- Have your code reviewed by someone else to see how you might make your code more efficient (comparing your code to someone else's code is a great way to learn!) Some potential areas to check for efficiency might include:
- Assessing where and how you chose to assign each Attack to your enemies
- Considering best practices when affecting another character's stats (like in the PerformAttack or Heal method)
- How you tackled the bonus challenges


## Step 3 (Game Developer III)
- It's time to have your own bit of fun with the game you've been developing! Using your knowledge of OOP and problem-solving, build out a small input-based encounter between a player and the enemies your created earlier.

- This means you'll need to create a Player class to add to your project. To keep it simple, your Player should just have a Name, a default health of 100, and a set of at least four attacks (your choice on what the attacks are).

- Once you're ready to go, follow these steps. Feel free to improvise or add your own features as well!

- Start your game by welcoming the player and prompting them to enter a name for their character. This will become your playable character's name and create the instance of the player.
- Then, randomly select an enemy for your player to fight. You can optionally default to the same character when running tests since some enemies have special conditions when fighting. The Melee character would be the easiest to start with.
- Now it's time to program your game-play loop. The objective is to keep fighting until one character falls to 0 health. On each turn, select a move you would like to use. This should reduce the enemy's health (use some of that code on attacking you wrote earlier to help you out here). In turn, the enemy will randomly select one of their own moves to use on you (do not worry about special moves like Rage, Dash, or Heal until you feel prepared to add it to the rotation). If neither of you is reduced to 0 health by the end of the round, the cycle begins again.
Once a character is reduced to 0 health, declare the winner and ask the player if they would like to go again. If yes, start a new round. If no, end the runtime.

### Bonuses
- Since the ranged fighter takes Distance into consideration, work this into your program by tracking how far away the two characters are from each other and not allowing certain actions like punching or kicking to take place unless the distance is less than 3. (Hint: you may need to limit when your ranged enemy can use the Dash method, and you may want to provide them with a melee attack option, otherwise they'll be helpless!)
- When the game begins, have the characters start 2 units apart by default.
- You will also need a way to close the distance gap if you want your character to stand a chance! Perhaps one of the attack options is to get close to the enemy.
- After you complete your project, go back through and see if there are any ways you could clean up your code. Maybe there are excessive bits of code in places, or maybe there's a more efficient way to make the game-play loop run. It is encouraged to reach out to another student who completed the assignment and see what they did. Comparing notes is an excellent way to learn!