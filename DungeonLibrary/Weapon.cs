using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    //Make it public
    public class Weapon
    {
        //Fields
        /*
         * int for min damage (cannot be less than 0 or > max
         * int for max damage (cannot be less than 0) - assign first in CTOR
         * string for the name
         * int for bonusHitChance
         * bool isTwoHanded
         */
        private int _minDamage;
        private int _maxDamage;
        private string _name;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        //Props - 1 for each field
        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _minDamage = value; }
        }
        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value > 0 && value <= MaxDamage ? value : 1; }
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }
        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

        //Constructors(CTORS)
        //1 Fully Qualified CTOR and 1 Unqualified CTOR if you want object initialization syntax
        public Weapon(int maxDamage, int minDamage, string name, int bonusHitChance, bool isTwoHanded)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Name = name;
            BonusHitChance = bonusHitChance;
            IsTwoHanded = isTwoHanded;
        }

        public Weapon()
        {
        }

        //Methods
        //Nicely formatted ToString() override
        public override string ToString()
        {
            return $"Max Damage: {MaxDamage}\n" +
                   $"Min Damage: {MinDamage}\n" +
                   $"Name: {Name}\n" +
                   $"Bonus Hit Chance: {BonusHitChance}\n" +
                   $"Weapon: {IsTwoHanded}\n";
        }
        
        public int CalcDamage()
        {
            return new Random().Next(MinDamage, MaxDamage + 1);

        }
    }
}
