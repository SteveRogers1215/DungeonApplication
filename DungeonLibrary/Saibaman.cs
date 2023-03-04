using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Saibaman : Monster
    {
        public Saibaman(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) :
            base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public Saibaman()
        {
            Name = "Saibaman";
            MaxLife = 30;
            HitChance = 8;
            Block = 10;
            MaxDamage = 14;
            MinDamage = 2;
            Description = "Just add water...";
        }
        public override string ToString()
        {
            string description = Description.ToString();
            return base.ToString() + $"\nMonster Description: {description}\n" +
                $"Damage: {MinDamage} to {MaxDamage}";
        }
        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (true)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
            //Create a random object
            //Random rando = new Random();
            //Determine damage
            //int grunDamage = rando.Next(MinDamage, MaxDamage + 1);
            //Return the damage
            //return grunDamage;
        }
    }
}
