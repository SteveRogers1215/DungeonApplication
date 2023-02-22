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
            Console.WriteLine("Characters\n\n");
            Character c1 = new Character()
            {
                MaxLife = 35,
                Life = 35,
                Name = "Knight",
                HitChance = 5,
                Block = 5,
            };
            Console.WriteLine($"Name: {c1.Name}\n" +
                $"Life: {c1.Life} of {c1.MaxLife}\n" +
                $"Hit Chance: {c1.HitChance}%\n" +
                $"Block: {c1.Block}");

            Console.WriteLine($"{c1.Name} has a block of {c1.CalcBlock}\n");
            Console.WriteLine($"{c1.Name} has a hit chance of: {c1.CalcHitChance}\n");
            Console.WriteLine($"{c1.Name} current damage is: {c1.CalcDamage}\n");

            #endregion

            #region Weapon Stuff
            Console.WriteLine("\n\nWeapons\n\n");
            Weapon w1 = new Weapon()
            {
                MaxDamage = 10,
                MinDamage = 5,
                Name = "Dragonslayer",
                BonusHitChance = 3,
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
