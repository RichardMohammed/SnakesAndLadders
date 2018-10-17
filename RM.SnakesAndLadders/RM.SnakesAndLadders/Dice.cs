using System;

namespace RM.SnakesAndLadders
{
    public class Dice
    {
        private static readonly Dice instance = new Dice();
        private Random _rand;
        static Dice() {}

        private Dice() {
            _rand = new Random();
        }

        public static Dice Instance
        {
            get
            {
                return instance;
            }
        }

        public int Roll()
        {
            return _rand.Next(1, 7);
        }
    }
}
