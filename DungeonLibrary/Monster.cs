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
            //Create variety of monsters//3/2/2023 - MADE THREE NEW MONSTERS WILL ADD THEM SUNDAY MORNING. OUTSIDE OF THAT WILL ATTEMPT SOME LAST MINUTE SYTLING AND LEAVE IT AT THAT 
            Xenomorph m1 = new("Chestburster", 10,  6, 6,  7,  3, "You aren't in space, so we can definetly hear you scream");
            Wyvern m2 = new("Wyvern", 15, 8, 7, 12, 5, "Is it a worm...or a dragon?");
            Saibaman m3 = new("Saibaman",  20,  8,  10,  10,  2,  "Just add water...");
            Grunbeld m4 = new("Grunbeld",  50,  10,  10,  25,  5,  "The Legendary Flame Dragon Knight Apostle!");
            Wendigo m5 = new("Wendigo", 50, 23, 17, 22, 15, "A consistent devourer of people.");
            DemonKing m6 = new("Demon King", 75, 25, 17, 50, 25, "Sometimes its better to just run...");
            Wyrm m7 = new("Great Wyrm", 100, 30, 20, 40, 15, "Its hide is impenitrable...it's claws like talons. A MIGHTY FOE.");
            
            List<Monster> monsters = new()
            {
                m2,m1,
                m1,m2,m6,m1,
                m1,m3,m4,m1,m7,
                m1,m2,m6,m1,
                m3,m4,
            };

            //pick one at random to place in dungeon room
            return monsters[new Random().Next(monsters.Count)];
        }
    }
}
