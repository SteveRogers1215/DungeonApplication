﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Xenomorph : Monster
    {
        public Xenomorph(string name, int maxLife, int hitChance, int block, int maxDamage, int minDamage, string description) :
            base(name, maxLife, hitChance, block, maxDamage, minDamage, description)
        {
            MaxDamage = maxDamage;
            MinDamage = minDamage;
            Description = description;
        }
        public Xenomorph()
        {
            Name = "Drooly the Chestburster";
            MaxLife = 10;
            HitChance = 6;
            Block = 6;
            MaxDamage = 7;
            MinDamage = 3;
            Description = "You aren't in space, so we can definetly hear you scream";
        }//Still need Nicely Formatted ToString
        //Still need CalcBlock override()
        public override string ToString()
        {
            string description = Description.ToString();
            return base.ToString() + $"\nMonster Description: {description}\n" +
                $"Damage: {MinDamage} to {MaxDamage}";
        }
        public override int CalcBlock()
        {
            int calculatedBlock = Block;
            if (true)
            {
                calculatedBlock += calculatedBlock / 2;
            }
            return calculatedBlock;
            //Create a random object
            //Random rando = new Random();
            //Determine damage
            //int grunDamage = rando.Next(MinDamage, MaxDamage + 1);
            //Return the damage
            //return grunDamage;
        }
        //public override int CalcDamage()
        //{
        //Create a random object
        //Random rando = new Random();
        //Determine damage
        //int xenoDamage = rando.Next(MinDamage, MaxDamage + 1);

        //Return the damage
        //return xenoDamage;
        //}
    }
}