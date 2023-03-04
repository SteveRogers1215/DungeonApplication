using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        //This is not a datatype class so it will not have fields props or CTORs. It will serve as a warehouse for a variety of combat related methods.

        public static void DoAttack(Character attacker, Character defender)
        {
            //Get a random number from 1 to 100 this is to determine the hit
            int roll = new Random().Next(1, 101);
            Thread.Sleep(200);
            //The attacker hits if the roll is less than or equal to the attackers hitchance - defenders block
            if (roll <= (attacker.CalcHitChance() - defender.CalcBlock()))
            {
                //calc the damage
                int damageDealt = attacker.CalcDamage();
                //assign damage to defenders life
                defender.Life -= damageDealt;
                //output the result
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit the {defender.Name} for {damageDealt} damage!");
                Console.ResetColor();
            }
            else//attacker missed
            {
                Console.WriteLine($"{attacker.Name} missed!");
            }
        }
        //THIS IS THE BATTLE(TURN BASED!)
        public static void DoBattle(Player player, Monster monster)
        {
            DoAttack(player, monster);
            //If the monster survives, then they can attack
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
            }
        }

        public static void DoBattle(Player player, object monster)
        {
            throw new NotImplementedException();
        }

        public static void DoBattle(object player, object monster)
        {
            throw new NotImplementedException();
        }
    }
}
