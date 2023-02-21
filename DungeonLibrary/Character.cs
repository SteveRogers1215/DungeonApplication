namespace DungeonLibrary
{
    public class Character
    {
        //Fields

        /*
         * int life (cannot be more than maxlife)
         * int maxlife (assign first in ctor)
         * string name
         * int hit chance(_strikeChance)
         * int block
         */
        private int _life;
        private int _maxlife;
        private string _name;
        private int _strikeChance;
        private int _block;

        //Properties - 1 for each field
        public int Life
        {
            get { return _life; }
            set { _life = value; }
        }//end int
        public int MaxLife
        {
            get { return _maxlife; }
            set { _maxlife = value; }
        }//end int
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//end string
        public int StrikeChance
        {
            get { return _strikeChance; }
            set { _strikeChance = value; }
        }//end int
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }//end int

        //Ctors - 1 fully qualified, 1 default/unqualified

        public Character(int maxLife, int life,  string name, int strikeChance, int block)
        {
            MaxLife = maxLife;
            Life = life;
            StrikeChance = strikeChance;
            Block = block;
        }

        //Methods
        //ToString() override
        public override string ToString()
        {
            return $"{Life}\n" +
                   $"Max Life: {MaxLife}\n" +
                   $"Strike Chance: {StrikeChance}\n" +
                   $"Block: {Block}\n";
        }
        public int CalcBlock()
        {
            return Block;
        }
        public int CalcHitChance()
        {
            return StrikeChance;
        }
        public int CalcDamage()
        {
            return 0;
        }

        //CalcBlock() returns an int -> return Block;
        //CalcHitChance() returns an int -> return HitChance;(StrikeChance)
        //CalcDamage() returns an int -> return 0;

    }//end class
}//end namespace