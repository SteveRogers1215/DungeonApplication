using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class DemonKing : Monster
    {
        public DemonKing(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public DemonKing()
        {
            Name = "Demon King";
            MaxLife = 75;
            HitChance = 25;
            Block = 17;
            MaxDamage = 50;
            MinDamage = 25;
            Description = "Sometimes its better to just run...";
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
