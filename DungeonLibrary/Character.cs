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
        private int _maxLife;
        private string _name;
        private int _hitChance;
        private int _block;

        //Properties - 1 for each field
        
        public int MaxLife
        {
            get { return _maxLife; }
            set { _maxLife = value; }
        }//end int
        public int Life
        {
            get { return _life; }
            set
            {
                if (value <= _maxLife)
                {
                    _life = value;
                }//end if
                else
                {
                    _life = MaxLife;
                }//end else

            }
        }//end int
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//end string
        public int HitChance
        {
            get { return _hitChance; }
            set { _hitChance = value; }
        }//end int
        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }//end int

        //Ctors - 1 fully qualified, 1 default/unqualified

        public Character(int maxLife, int life,  string name, int hitChance, int block)
        {
            MaxLife = maxLife;
            Life = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
        }

        public Character()
        {
        }

        //Methods
        //ToString() override
        public override string ToString()
        {
            return $"--------- {Name} ---------\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Hit Chance: {HitChance}%\n" +
                $"Block: {Block}";
        }


        //CalcBlock() returns an int -> return Block;
        //CalcHitChance() returns an int -> return HitChance;(StrikeChance)
        //CalcDamage() returns an int -> return 0;
        public virtual int CalcBlock() { return Block; }
        public virtual int CalcHitChance() { return HitChance; }
        public virtual int CalcDamage() { return 0; }

    }//end class
}//end namespace