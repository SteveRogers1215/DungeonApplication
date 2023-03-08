using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Wyvern : Monster
    {
        public bool ironScales { get; set; }
        public Wyvern(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool ironScales) :
            base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            Random rand = new Random();
            int scaly = rand.Next(4);
            ironScales = scaly == 5; 
        }
        public Wyvern()
        {
            Name = "Wyvern";
            MaxLife = 20;
            HitChance = 8;
            Block = 7;
            MaxDamage = 12;
            MinDamage = 5;
            Description = "Is it a worm...or a dragon?";
        }
        public override string ToString()
        {
            string description = Description.ToString();
            return base.ToString() + (ironScales ? "It's deploying it scaly hide as projectiles!" : "The creatures scales seem to be rattleling");
        }
        public override int CalcBlock()
        {
            int ironScale = HitChance;
            if (ironScales)
            {
                ironScale +=  4;
            }
            return ironScale;
            
        }
    }
}
