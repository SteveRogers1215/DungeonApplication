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
        public Monster()
        {

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
            Xenomorph m1 = new(name: "Drooly the Chestburster", maxLife: 10,  hitChance: 6, block: 6, maxDamage: 7, minDamage: 3,
                description: "You aren't in space, so we can definetly hear you scream");
            Wyvern m2 = new(name:"Randy", maxLife: 15, hitChance: 8, block: 7, maxDamage: 12, minDamage: 5,
                description: "Is it a worm...or a dragon?");
            Saibaman m3 = new(name:"Greeny", maxLife: 20, hitChance: 8, block: 10, maxDamage: 10, minDamage: 2,
                description: "Just add water...");
            Grunbeld m4 = new(name:"Grunbeld", maxLife: 50, hitChance: 10, block: 10, maxDamage: 25, minDamage: 5,
                description: "The Legendary Flame Dragon Knight Apostle!");
            //add monster to a collection
            List<Monster> monsters = new()
            {
                m1,m1,m1,m1,
                m2,m2,m2,
                m3,m3,
                m4,
            };

            //pick one at random to place in dungeon room
            return monsters[new Random().Next(monsters.Count)];
        }
    }
}
