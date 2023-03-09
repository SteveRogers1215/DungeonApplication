using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{

    public class Grunbeld : Monster
    {
        public bool knightlyValor { get; set; }
        public Grunbeld(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool knightlyValor) :
            base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            Random rand = new Random();
            int roar = rand.Next(5);
            knightlyValor = roar == 1;
        }
        public Grunbeld()
        {
            Name = "Grunbeld";
            MaxLife = 55;
            HitChance = 30;
            Block = 10;
            MaxDamage = 25;
            MinDamage = 7;
            Description = "The Legendary Flame Dragon Knight Apostle!";
            knightlyValor = false;
        }
        public override string ToString()
        {

            return base.ToString() + (knightlyValor ? "He's preparing to charge!!!" : "Looks like a defensive stance");
        }
        public override int CalcBlock()
        {
            int increasedChance = HitChance;
            if (knightlyValor)
            {
                increasedChance += 6;
            }
            return increasedChance;
            
        }
        

    }
}
