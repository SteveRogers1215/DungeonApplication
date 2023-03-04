using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //Fields
        //NONE

        //Props
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //Constructors
        public Player( string name, int maxLife, int hitChance, int block, Race playerRace, Weapon equippedWeapon) : base(maxLife, name, hitChance, block)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            //Atributes...//
            #region Potential Expansion - Racial Bonuses
            switch (PlayerRace)
            {
                case Race.Orc:
                    HitChance += 7;
                    break;
                case Race.Human:
                    HitChance += 5;
                    break;
                case Race.Elf:
                    HitChance += 6;
                    break;
                case Race.Dwarf:
                    HitChance += 3;
                    break;
                case Race.Goblin:
                    HitChance += 4;
                    break;
                case Race.Ent:
                    HitChance += 10;
                    break;
                case Race.Demon:
                    HitChance += 12;
                    break;
                case Race.Angel:
                    HitChance += 20;
                    break;
                case Race.Saiyan:
                    HitChance += 15;
                    break;
                default:
                    break;
            }
            #endregion
        }
        public Player()
        {
            
        }

        //Methods

        public override string ToString()
        {
            //create a string, switch on Player Race and write a description about that race.
            string description = PlayerRace.ToString();
            return base.ToString() + $"\nWeapon: {EquippedWeapon}\n" +
                $"Description: {description}";
        }

        public override int CalcDamage()
        {
            //Create a random object
            Random rand = new Random();
            //Determine damage
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);
            //Return the damage
            return damage;
        }

        public override int CalcHitChance()
        {
            return HitChance + EquippedWeapon.BonusHitChance;
        }
    }
}
