using DungeonLibrary;
using System.Threading;
using static System.Formats.Asn1.AsnWriter;
using Xunit;

namespace UnitTesting
{
    public class UnitTesting
    {
        
        [Fact]
        public void DungeonTestingMinDamageTests()
        {
            Xenomorph m1 = new(name: "Chestburster", maxLife: 10, hitChance: 6, block: 6, maxDamage: 7, minDamage: 3,
               description: "You aren't in space, so we can definetly hear you scream");
            int expectedMinDamage = 0;
            int actualMinDamage = 0;
            expectedMinDamage = 3;
            actualMinDamage = m1.MinDamage;
            Assert.Equal(expectedMinDamage,actualMinDamage)
                
        }
        [Fact]
        public void DungeonTestingMinDamageTests2()
        {
            Wyvern m2 = new(name: "Randy", maxLife: 15, hitChance: 8, block: 7, maxDamage: 12, minDamage: 5,
                description: "Is it a worm...or a dragon?");
            int expectedMinDamage = 0;
            int actualMinDamage = 0;
            expectedMinDamage = 5;
            actualMinDamage = m2.MinDamage;
            Assert.Equal(expectedMinDamage, actualMinDamage)


        }
        [Fact]
        public void DungeonTestingMaxDamageTests1()
        {
            Saibaman m3 = new(name: "Greeny", maxLife: 20, hitChance: 8, block: 10, maxDamage: 10, minDamage: 2,
                description: "Just add water...");
            int expectedMaxDamage = 0;
            int actualMaxDamage = 0;
            expectedMaxDamage = 10;
            actualMaxDamage = m3.MaxDamage;
            Assert.Equal(expectedMaxDamage, actualMaxDamage)

        }
        [Fact]
        public void DungeonTestingMaxDamageTests2()
        {
            Grunbeld m4 = new(name: "Grunbeld", maxLife: 50, hitChance: 10, block: 10, maxDamage: 25, minDamage: 5,
                description: "The Legendary Flame Dragon Knight Apostle!");
            int expectedMaxDamage = 0;
            int actualMaxDamage = 0;
            expectedMaxDamage = 25;
            actualMaxDamage = m4.MaxDamage;
            Assert.Equal(expectedMaxDamage, actualMaxDamage)
        }
        [Fact]
        public void DungeonTestingMaxDamageTests3()
        {
            DemonKing m6 = new("Demon King", 75, 25, 17, 50, 25, "Sometimes its better to just run...");
            int expectedMaxDamage = 0;
            int actualMaxDamage = 0;
            expectedMaxDamage = 25;
            actualMaxDamage = m6.MaxDamage;
            Assert.Equal(expectedMaxDamage, actualMaxDamage)

        }

    }
}