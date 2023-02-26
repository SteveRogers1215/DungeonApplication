using DungeonLibrary;
 namespace Dungeon;

public class Dungeon

{
    

    static void Main(string[] args)
    {
        #region Title/Introduction
        Console.Title = "DUNGEON OF DOOM";
        Console.WriteLine("Your journey begins...\n");
        //Good place for music to start
        #endregion


        #region Player Creation
        // Variable to keep score
        int score = 0;
        //Possible expanision - a list of premade weapons and allow user to choose(or random)
        Weapon sword = new Weapon(1, 8, "Dragonslayer", 10, true,  WeaponType.Sword);


        //Potential expansion -- let them make their own name
        //Show them possible races and let them pick one.
        Player player = new(50, "Sam Squire", 50, 40, Race.Saiyan, sword);
        #endregion


        #region Main Game Loop
        bool exit = false;
        //int innerCount = 0;
        //int outerCount = 0;
        do
        {
            // Generate random room
            Console.WriteLine(GetRoom());
            // Select a random monster to inhabit room
            Monster monster = Monster.GetMonster();
            Console.WriteLine($"In this room {monster.Name}!");
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
                        Console.WriteLine("No one likes a quitter...");
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
        Console.WriteLine("You defeated " + score + " monster " + (score == 1 ? "." : "s."));
        
        #endregion

    }//end Main()

    private static string GetRoom()
    {
        string[] rooms =
        {
            "Mount Doom",
            "Valinor",
            "Dark Hallway",
            "Coffee Shop",
            "The Interstice",
        };

        Random rand = new Random();

        int index = rand.Next(rooms.Length);

        string room = rooms[index];

        return room;
        //Possible refactor
        return rooms[new Random().Next(rooms.Length)];
    }//Get Room()

}//end class
//end namespace
