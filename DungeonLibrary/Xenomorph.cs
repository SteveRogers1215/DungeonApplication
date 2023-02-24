using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Xenomorph : Monster
    {
        public Xenomorph(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public Xenomorph()
        {
            Name = "Drooly the Chestburster";
            MaxLife = 10;
            HitChance = 6;
            Block = 6;
            MaxDamage = 7;
            MinDamage = 3;
            Description = "You aren't in space, so we can definetly hear you scream";
        }//Still need Nicely Formatted ToString
        //Still need CalcBlock override()

    }
}
