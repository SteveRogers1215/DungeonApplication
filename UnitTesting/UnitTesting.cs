using DungeonLibrary;
using System.Threading;
using static System.Formats.Asn1.AsnWriter;
using Xunit;

namespace UnitTesting
{
    public class UnitTesting
    {
        [Fact]
        public Monster DungeonFunctionTest1()
        {
            #region TestParameters
            //Arrange
            Xenomorph m1 = new(name: "Chestburster", maxLife: 10, hitChance: 6, block: 6, maxDamage: 7, minDamage: 3,
               description: "You aren't in space, so we can definetly hear you scream");
            Wyvern m2 = new(name: "Randy", maxLife: 15, hitChance: 8, block: 7, maxDamage: 12, minDamage: 5,
                description: "Is it a worm...or a dragon?");
            Saibaman m3 = new(name: "Greeny", maxLife: 20, hitChance: 8, block: 10, maxDamage: 10, minDamage: 2,
                description: "Just add water...");
            Grunbeld m4 = new(name: "Grunbeld", maxLife: 50, hitChance: 10, block: 10, maxDamage: 25, minDamage: 5,
                description: "The Legendary Flame Dragon Knight Apostle!");

            #region TestParameters
            
            #endregion


            //pick one at random to place in dungeon room

            //Act
            List<Monster> monsters = new()
            {
                m1,m1,m1,m1,
                m2,m2,m2,
                m3,m3,
                m4,
            };
            return monsters[new Random().Next(monsters.Count)];

            #endregion



            

        }
        [Fact]
        public void DungeonTesting()
        {

        }
    }
}