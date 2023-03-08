using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Saibaman : Monster
    {
        public bool screamDamage { get; set; }
        public Saibaman(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool screamDamage) :
            base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            Random rand = new Random();
            int scream = rand.Next(3);
            screamDamage = scream == 2;
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
            return base.ToString() +  (screamDamage ? "It's growing stronger!!" : "It seems to be posturing for an attack");
        }
        public override int CalcBlock()
        {
            int monsterHealth = Life;
            if (screamDamage)
            {
                monsterHealth += 2;
            }
            return monsterHealth;
            
        }
    }
}
