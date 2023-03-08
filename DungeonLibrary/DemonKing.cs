using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class DemonKing : Monster
    {
        public bool isEnraged { get; set; }

        public DemonKing(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool isEnraged) : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            //Notes for pointers on monsters
            Random rand = new Random();
            int bit = rand.Next(2);
            isEnraged = bit == 1;

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
            isEnraged = false;
        }
        public override string ToString()
        {

            return base.ToString() + (isEnraged ? "RAGE BUILDING!?!?" : "Rage Disipated");
        }
        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (isEnraged)
            {
                calculatedBlock -= 6;
            }
            return calculatedBlock;

        }
    }
}
