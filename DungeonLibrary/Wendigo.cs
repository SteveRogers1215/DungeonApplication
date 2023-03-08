using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    internal class Wendigo : Monster
    {
        public bool totalFrenzy { get; set; }
        public Wendigo(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool totalFrenzy) : base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            Random rand = new Random();
            int frenzy = rand.Next(2);
            totalFrenzy = frenzy == 5;
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
            return base.ToString() +  (totalFrenzy ? "It's frenzied! Don't let it hit you!!" : "It seems to be slightly agitated");
        }
        public override int CalcDamage()
        {
            int frenziedDamage = MaxDamage;
            if (totalFrenzy)
            {
                frenziedDamage += 10;
            }
            return frenziedDamage;
            
        }
    }
}
