using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class Wendigo : Monster
    {
        public Wendigo(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public Wendigo()
        {
            Name = "Wendigo";
            MaxLife = 50;
            HitChance = 23;
            Block = 17;
            MaxDamage = 22;
            MinDamage = 15;
            Description = "A consistent devourer of people.";
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
            
        }
    }
}
