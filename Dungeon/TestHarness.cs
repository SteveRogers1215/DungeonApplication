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
            #region Weapon Stuff
            Console.WriteLine("\n\n-----Weapons-----\n\n");
            Weapon w1 = new Weapon()
            {
                MaxDamage = 20,
                MinDamage = 8,
                Name = "Dragonslayer",
                BonusHitChance = 6,
                IsTwoHanded = true

            };
            Console.WriteLine(w1);
            #endregion

            //build and test a character - include CalcBlock(), CalchitChance(), CalcDamage()
            #region Character Stuff
            Console.WriteLine("\n\n-----Characters-----\n\n");
            Player p1 = new Player()
            {
                MaxLife = 55,
                Life = 55,
                Name = "Knight",
                HitChance = 15,
                Block = 15,
                PlayerRace = Race.Saiyan,
                EquippedWeapon = w1
            };
            Console.WriteLine();

            Console.WriteLine("\n\n----WEAPON----\n\n");
            Console.WriteLine(w1);//Constructor methods


            Console.WriteLine("\n\n----PLAYER----\n\n");
            Console.WriteLine(p1);//Constructor methods
            Console.WriteLine($"{p1.Name} has a block of {p1.CalcBlock()}\n");
            Console.WriteLine($"{p1.Name} has a hit chance of: {p1.CalcHitChance()}\n");
            Console.WriteLine($"{p1.Name} current damage is: {p1.CalcDamage()}\n");

            Console.WriteLine( "\n\n----MONSTER----\n\n" );

            Console.WriteLine(Monster.GetMonster());
            Monster monster = Monster.GetMonster();
            Console.ReadLine();

            Console.WriteLine("\n\n----COMBAT----\n\n");
            Combat.DoBattle(p1, monster);
            #endregion



        }
    }
}
