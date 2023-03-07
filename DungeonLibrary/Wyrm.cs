using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class Wyrm : Monster
    {
        public bool stronglyCoiled { get; set; }
        public Wyrm(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool stronglyCoiled) : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            Random rand = new Random();
            int coiled = rand.Next(4);
            stronglyCoiled = coiled == 3;
        }
        public Wyrm()
        {
            Name = "Great Wyrm";
            MaxLife = 100;
            HitChance = 30;
            Block = 20;
            MaxDamage = 40;
            MinDamage = 15;
            Description = "Its hide is impenitrable...it's claws like talons. A MIGHTY FOE.";
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
            if (stronglyCoiled)
            {
                calculatedBlock += 12;
            }
            return calculatedBlock;
            
        }
    }
}
