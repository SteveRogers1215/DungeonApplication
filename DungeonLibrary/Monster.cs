using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Monster : Character

        
    {
        //Fields
        private int _minDamage;
        
        
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 0; }
        }
        
        //Props
        public int MaxDamage { get; set; } 
        
        public string Description { get; set; }
        

        //Constructors(CTORS)
        public Monster(string name,int maxLife, int hitChance, int block, int maxDamage,int minDamage, string description) : base(maxLife, name, hitChance, block)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;

        }

        //Methods
        public override string ToString()
        {
            string description = Description.ToString();
            return base.ToString() + $"\nMonster Description: {description}\n" + $"Damage: {MinDamage} to {MaxDamage}";                
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
        public static Monster GetMonster() 

        {
            //Change names and update consturctors after making new monsters this weekend.//NEW CLASSES FOR MONSTERS(HOMEWORK)
            //Create variety of monsters
            Monster m1 = new(name:"Papa Smurf", maxLife: 50,  hitChance: 30, block: 15, maxDamage: 35, minDamage: 15, description: "He's so...BLUE!");
            Monster m2 = new(name:"Morgoth", maxLife: 100, hitChance: 47, block: 10, maxDamage: 40, minDamage: 6, description: "The OG Dark Lord");
            Monster m3 = new(name:"Grunbeld", maxLife: 75, hitChance: 65, block: 45, maxDamage: 77, minDamage: 32, description: "The Flame Dragon Apostle!!");
            Monster m4 = new(name:"Casper", maxLife: 55, hitChance: 44, block: 33, maxDamage: 39, minDamage: 30, description: "Nothing so see here...just a harmless ghost...");
            //add monster to a collection
            List<Monster> monsters = new()
            {
                m1,
                m2,m2,
                m3,m3,
                m4,m4,m4
            };

            //pick one at random to place in dungeon room
            return monsters[new Random().Next(monsters.Count)];
        }
    }
}
