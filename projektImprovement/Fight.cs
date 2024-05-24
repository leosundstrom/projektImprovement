using projektImprovement;

public class fight : LogicClass
{
    stateM stateM;

    Enemy currentEnemy;

    Random generator = new Random();
    public fight(stateM stateM)
    {
        this.stateM = stateM;
    }

    bool enemyBeaten = false;
 

    public override void Update()
    {
       
        NewEnemy();


        bool playerTurn = true;

        Console.BackgroundColor = ConsoleColor.DarkRed;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Black;
        
       
        {
            Console.WriteLine($"You find a {currentEnemy.name} while wandering in the monster filled forest! Press Enter to engage.");
        }
        Console.ReadLine();
        Console.WriteLine("Write attack to attack, spell for spells and potion for potions");
        while (currentEnemy.hp >= 1)
        {
            if (playerTurn)
            {
                string pText = Console.ReadLine();
                if (pText.ToLower() == "attack")
                {
                    stateM.player.damage = generator.Next(stateM.player.minDmg, stateM.player.maxDmg);
                    currentEnemy.hp -= stateM.player.damage / stateM.enemy.armor;
                    Console.WriteLine($"The {currentEnemy.name} took {stateM.player.damage} damage! The {currentEnemy.name} now has {currentEnemy.hp} health.");
                    playerTurn = false;
                }
                if (pText.ToLower() == "spell")
                {
                    Console.WriteLine("Pick a spell \n Strength");
                }
                if (playerTurn == false)
                {
                    stateM.player.hp = currentEnemy.Attack(stateM.player.hp);

                    if(stateM.player.hp <= 0)
                    {
                        PlayerDead();
                    }
                    Console.ReadLine();
                    Console.WriteLine($"The enemy swung his weapon and you now have {stateM.player.hp}");
                    playerTurn = true;
                }
            }
        }


        if (currentEnemy.hp <= 1)
        {
            
            enemyBeaten = true;
        }
        if (enemyBeaten == true)
        {
            Console.WriteLine($"You beat {currentEnemy.name}!");

            Console.ReadLine();
            stateM.currentState = stateM.States.mainMenu;
            stateM.SetState();
            
           


        }
    }


    void PlayerDead()
    {
        Console.WriteLine("You have died loser");
        Console.ReadKey();

        Environment.Exit(0);
    }


    void NewEnemy()
    {
        if(generator.Next(0, 101) >= 50)
        {
            currentEnemy = new Ogre();
        }
        else
        {
            currentEnemy = new Vulture();
        }
    }



}

