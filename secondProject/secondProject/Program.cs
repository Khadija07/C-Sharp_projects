

Console.WriteLine("Welcome to the adventure game");
Console.WriteLine("Enter Character's name:");
string characterName = Console.ReadLine();
Console.WriteLine("Choose your character: Warrior, Archer");
string charactertype = Console.ReadLine();

if (charactertype.ToLower() == "warrior")
{
    Console.WriteLine("Choose your weapon: sword, hammer");
    string weapon = Console.ReadLine();
    Console.WriteLine($"Good choice!");
    bool gameStatus = true;
    while (gameStatus)
    {
        Console.WriteLine("Do you want to enter the forest? (yes/no)");
        string choice = Console.ReadLine();
        if (choice.ToLower() == "yes")
        {

            Console.WriteLine("Let's begin the fight! Do you want to go right/left?");
            string direction = Console.ReadLine();
            if (direction.ToLower() == "right")
            {
                Console.WriteLine("You found a treasure!Congratulations!Game Over!");
            }
            else
            {
                Console.WriteLine("You have confronted a beast! Do you want to use the weapon? (yes/no)");
                string fight = Console.ReadLine();
                if (fight.ToLower() == "yes")
                {
                    Random random = new Random();
                    int chance = random.Next(1, 10);
                    if (chance < 5)
                    {
                        Console.WriteLine("Sorry, you did not win!The beast killed you!Game Over!");
                        gameStatus = false;
                    }
                    else
                    {
                        Console.WriteLine("Congratulations!You defeated the Beast! Won a treasure!");
                    }
                }
                else
                {
                    Console.WriteLine("Oh No!Too Late! Game Over!");
                    gameStatus = false;
                }
            }


        }
        else if (choice.ToLower() == "no")
        {
            Console.WriteLine("ok!wait outside!");
        }

        else
        {
            Console.WriteLine("wrong input!Enter Again!");

        }
    }

}

else if (charactertype.ToLower() == "archer")
{
    Console.WriteLine("Choose your weapon: spear, bow");
    string weapon = Console.ReadLine();
    Console.WriteLine($"Good choice!");
    bool gameStatus = true;
    while (gameStatus)
    {
        Console.WriteLine("Do you want to enter the forest? (yes/no)");
        string choice = Console.ReadLine();
        if (choice.ToLower() == "yes")
        {
            Console.WriteLine("Beast detected on your right!");
            Console.WriteLine("Let's begin the fight! Do you want to fight/wait?");
            string direction = Console.ReadLine();
            if (direction.ToLower() == "fight")
            {
                Random random = new Random();
                int chance = random.Next(1, 10);
                if (chance < 5)
                {
                    Console.WriteLine("Oh No! You missed the beast! Start Again");
                }
                else
                {
                    Console.WriteLine("You killed the Beast!You found a treasure!Congratulations!Game Over!");
                    gameStatus = false;
                }


            }
            else
            {
                Console.WriteLine("Its too late! The beast killed you!Game over!");

                gameStatus = false;
            }


        }
        else if (choice.ToLower() == "no")
        {
            Console.WriteLine("ok!wait outside!");
        }

        else
        {
            Console.WriteLine("wrong input!Enter Again!");

        }
    }

}

Console.WriteLine("Thank you for playing the game!");

Console.ReadKey();