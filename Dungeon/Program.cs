namespace Dungeon
{
    public class Signatures
    {
        

        static void Main(string[] args)
        {
            #region Title/Introduction
            Console.Title = "DUNGEON OF DOOM";
            Console.WriteLine("Your journey begins...\n");
            //Good place for music to start
            #endregion


            #region Player Creation
            //TODO Variable to keep score
            int score = 0;
            //TODO Weapon creation

            //TODO Player Object creation

            #endregion


            #region Main Game Loop
            bool exit = false;
            int innerCount = 0;
            int outerCount = 0;
            do
            {
                //Console.WriteLine("Outer " + ++outerCount);
                //TODO Generate random room
                Console.WriteLine(GetRoom());
                //TODO Select a random monster to inhabit room
                Console.WriteLine("Here's a monster!");
                #region Gameplay Menu Loop
                bool reload = false;
                
                do
                {
                    //Console.WriteLine("Inner " + ++innerCount);
                    //TODO Gameplay Menu
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
                            //TODO Combat
                            Console.WriteLine("ATTACK!");
                            break;

                        case ConsoleKey.R:
                            //TODO Attack of opportunity
                            Console.WriteLine("Run Away!");
                            reload = true;
                            break;

                        case ConsoleKey.P:
                            //TODO Player info
                            Console.WriteLine("Player Info: ");
                            break;

                        case ConsoleKey.M:
                            //TODO Monster Info
                            Console.WriteLine("Monster Info: ");
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
                    //TODO Check player life


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
                "1", "2", "3", "4", "5,"
            };

            Random rand = new Random();

            int index = rand.Next(rooms.Length);

            string room = rooms[index];

            return room;
            //Possible refactor
            return rooms[new Random().Next(rooms.Length)];
        }//Get Room()

    }//end class
}//end namespace
