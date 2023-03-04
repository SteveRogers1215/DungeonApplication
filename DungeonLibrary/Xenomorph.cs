using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Xenomorph : Monster
    {
        public Xenomorph(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) :
            base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public Xenomorph()
        {
            Name = "Chestburster";
            MaxLife = 10;
            HitChance = 10;
            Block = 5;
            MaxDamage = 7;
            MinDamage = 3;
            Description = "You aren't in space, so we can definetly hear you scream";
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
