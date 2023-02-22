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
                HitChance = 85,
                Block = 75,
            };
            Console.WriteLine($"Name: {c1.Name}\n" +
                $"Life: {c1.Life} of {c1.MaxLife}\n" +
                $"Hit Chance: {c1.HitChance}%\n" +
                $"Block: {c1.Block}");
            

            #endregion

            #region Weapon Stuff
            Console.WriteLine("\n\n******** Weapon STUFF **********\n\n");
            Weapon w1 = new Weapon()
            {
                MaxDamage = 200,
                MinDamage = 50,
                Name = "Dragonslayer",
                BonusHitChance = 75,
                IsTwoHanded = true       

            };
            Console.WriteLine($"Max Damage: {w1.MaxDamage}\n" +
                   $"Min Damage: {w1.MinDamage}\n" +
                   $"Name: {w1.Name}\n" +
                   $"Bonus Hit Chance: {w1.BonusHitChance}\n" +
                   $"Weapon: {w1.IsTwoHanded}\n");
            #endregion
        }
    }
}
