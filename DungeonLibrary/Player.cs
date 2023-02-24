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
        //None

        //Props
        public Race PlayerRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //Constructors(CTORS)
        public Player(int maxLife, string name, int hitChance, int block, Race playerRace, Weapon equippedWeapon) : base(maxLife, name, hitChance, block)
        {
            PlayerRace = playerRace;
            EquippedWeapon = equippedWeapon;

            //Atributes...
            #region Potential Expansion - Racial Bonuses
            switch (PlayerRace)
            {
                case Race.Orc:
                    break;
                case Race.Human:
                    break;
                case Race.Elf:                    
                    break;
                case Race.Dwarf:
                    break;
                case Race.Goblin:
                    break;
                case Race.Ent:
                    break;
                case Race.Demon:
                    break;
                case Race.Angel:
                    break;
                case Race.Saiyan:
                    HitChance += 7;
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
