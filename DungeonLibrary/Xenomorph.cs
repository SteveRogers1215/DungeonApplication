using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Xenomorph : Monster
    {
        public bool acidSpit { get; set; }
        public Xenomorph(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description, bool acidSpit) :
            base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            Random rand = new Random();
            int spit = rand.Next(2);
            acidSpit = spit == 7;
        }
        public Xenomorph()
        {
            Name = "Juvenile Xenomorph";
            MaxLife = 10;
            HitChance = 21;
            Block = 5;
            MaxDamage = 7;
            MinDamage = 3;
            Description = "You aren't in space, so we can definetly hear you scream";
            acidSpit = false;
        }
        public override string ToString()
        {
            string description = Description.ToString();
            return base.ToString() + (acidSpit ? "Dont let the acid spray on you!!!" : "It might use its acid...BE CAREFUL!");
        }
        public override int CalcDamage()
        {
            int acidSpray = MaxDamage;
            if (acidSpit)
            {
                acidSpray +=  7;
            }
            return acidSpray;
            
        }
        
    }
}
