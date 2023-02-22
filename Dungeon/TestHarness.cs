using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace Dungeon
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            //build and test functionality of our library
            //build and test a weapon
            //build and test a character - include CalcBlock(), CalchitChance(), CalcDamage()
            #region Character Stuff
            Console.WriteLine("****Character STUFF ****\n\n");
            Character c1 = new Character()
            {
                MaxLife = 150,
                Life = 100,
                Name = "Knight",
                StrikeChance = 85,
                Block = 75,
            };
            

            #endregion

            #region Weapon Stuff
            Console.WriteLine("\n\n\n******** Weapon STUFF **********");
            
            Weapon w1 = new Weapon()
            {
                MaxDamage = 200,
                MinDamage = 50,
                Name = "Dragonslayer",
                BonusHitChance = 75,
                IsTwoHanded = true       

            };
            #endregion
        }
    }
}
