using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public abstract class Monster : Character

        
    {
        //Fields
        private int _minDamage;
        
        
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }
        
        //Props
        public int MaxDamage { get; set; } 
        
        public string Description { get; set; }
        

        //Constructors(CTORS)
        public Monster(int maxLife, string name, int hitChance, int block, int maxDamage,int minDamage, string description) : base(maxLife, name, hitChance, block)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;

        }

        //Methods
        public override string ToString()
        {
            string description = Description.ToString();
            return base.ToString() + $"\nMonster Description: {description}\n"
                + $"Damage: {MinDamage} to {MaxDamage}";                
        }
        public override int CalcDamage()
        {
            //Create a random object
            Random rando = new Random();
            //Determine damage
            int monsterDamage = rando.Next(MinDamage, MaxDamage + 1);
            //Return the damage
            return monsterDamage;
        }
    }
}
