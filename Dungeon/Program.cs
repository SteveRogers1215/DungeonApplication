using DungeonLibrary;
namespace Dungeon;

public class Dungeon

{
    

    static void Main(string[] args)
    {
        #region Title/Introduction
        Console.Title = "DIMENSIONS OF DOOM: A text and turn based RPG.";
        

        Console.WriteLine("       (**)                                         (**)\r\n       IIII                                         IIII\r\n       ####                                         ####\r\n       HHHH     In the middle of the journey of     HHHH\r\n       HHHH    our life I found myself within a     HHHH\r\n       ####   darkwoods where the straight way was  ####\r\n    ___IIII___              LOST...              ___IIII___\r\n .-`_._\"**\"_._`-.                             .-`_._\"**\"_._`-.\r\n|/``  .`\\/`.  ``\\|                           |/``  .`\\/`.  ``\\|\r\n`     }    {     '     -Dante Alighieri      `     }    {     '\r\n      ) () (                                       ) () (\r\n      ( :: )                                       ( :: )\r\n      | :: |                                       | :: |\r\n      | )( |                                       | )( |\r\n      | || |                                       | || |\r\n      | || |                                       | || |\r\n      | || |                                       | || |\r\n      | || |                                       | || |\r\n      | || |                                       | || |\r\n      ( () )                                       ( () )\r\n       \\  /                                         \\  /\r\n        \\/                                           \\/");

        Console.WriteLine("\n\n\n\n\n\n********** Your journey begins in... **********\n\n");
        #endregion


        #region Player Creation
        // Variable to keep score
        int score = 0;
        //Possible expanision - a list of premade weapons and allow user to choose(or random)
        
        Weapon sword = new Weapon(15, 8, "Dragonslayer", 10, true,  WeaponType.Sword);

        
        //Potential expansion -- let them make their own name
        //EXTRA FUNCTIONALITY!!!!!!!!!!
        Console.WriteLine("Please enter your name:");
        player.name = Console.ReadLine()
        //Show them possible races and let them pick one.
        Console.WriteLine("What race is your character? (1 = Orc, 2 = Human, 3 = Elf, 4 = Dwarf,5 = Goblin,6 = Ent,7 = Demon,8 = Angel,9 = Saiyan)");
        player.race = Convert.ToInt32(Console.ReadLine());

        Player player = new({player.name}, 55, 50, 40, {player.race}, sword);
        #endregion


        #region Main Game Loop
        bool exit = false;
        //int innerCount = 0;
        //int outerCount = 0;
        do
        {

            // Generate random room
            Console.WriteLine(GetRoom());
            Console.WriteLine();
            // Select a random monster to inhabit room
            Monster monster = Monster.GetMonster();
            Console.WriteLine();
            Console.WriteLine($"In this room you find...{monster.Name}!");
            #region Gameplay Menu Loop
            bool reload = false;
            
            do
            {
                // Gameplay Menu
                #region Menu
                Console.Write("\nPlease choose an action:\n" +
                    "A) Attack\n" +
                    "R) Run away\n" +
                    "P) Player Info\n" +
                    "M) Monster Info\n" +
                    "X) Exit\n");

                ConsoleKey userChoice = Console.ReadKey(true).Key;
                Console.Clear();
                switch (userChoice)

                {
                    case ConsoleKey.A:
                        // Combat
                        //Potential Expansion: weapon/race bonus attack
                        //if race == darkelf - > player.DoAttack(monster)
                        Combat.DoBattle(player, monster);
                        //check if monster is dead
                        if (monster.Life <= 0)
                        {
                            //Combat rewards -> money, health, etc
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\nYou killed {monster.Name}!");
                            if (player.Life < 27.5)
                            {
                                Console.WriteLine("A second wind!");
                                player.Life += 7;

                            }
                            Console.ResetColor();
                            //flip the inner loop bool to true
                            reload = true;

                            score++; 
                        }
                        break;

                    case ConsoleKey.R:
                        // Attack of opportunity
                        Console.WriteLine("Run Away!");
                        Console.WriteLine($"{monster.Name} attacks you as you flee!");
                        Combat.DoAttack(monster, player);
                        Console.WriteLine();//formatting
                        reload = true;//new room, new monster
                        break;

                    case ConsoleKey.P:
                        // Player info
                        Console.WriteLine("Player Info: ");
                        Console.WriteLine(player);
                        break;

                    case ConsoleKey.M:
                        //TODO Monster Info
                        Console.WriteLine("Monster Info: ");
                        Console.WriteLine(monster);
                        break;

                    case ConsoleKey.X:
                    case ConsoleKey.E:
                    case ConsoleKey.Escape:
                        Console.WriteLine("No one likes a quitter...don't let the door hit you on the way out.");
                        exit = true;
                        reload = true;
                        break;
                    default:
                        break;
                }//end switch

                #endregion
                // Check player life
                if (player.Life <= 0)
                {
                    Console.WriteLine("Wipe yourself off man...you're dead\a");
                    exit = true;
                }


            } while (!reload && !exit); //If either exit or reload is true the inner loop will exit.
            #endregion
        } while (!exit);//If exit is true the outer will exit as well.

        //Show the score
        Console.WriteLine("You defeated " + score + " monster " + (score == 1 ? "." :"s."));
        
        #endregion

    }//end Main()

    private static string GetRoom()
    {
        string[] rooms =
        {
            "The Slime Pits",
            "The Misty Cave",
            "The Dark Forest",
            "Festering Swamp",
            "Desolate Byway",
        };

        Random rand = new Random();

        int index = rand.Next(rooms.Length);

        string room = rooms[index];

        return room;
        
        return rooms[new Random().Next(rooms.Length)];
    }//Get Room()

}//end class
//end namespace
