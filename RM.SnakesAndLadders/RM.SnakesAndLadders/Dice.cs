using System;

namespace RM.SnakesAndLadders
{
    public class Dice
    {
        private static Dice _instance;
        private readonly Random _rand;

        static Dice() {}

        private Dice() {
            _rand = new Random();
        }

        public static Dice Instance => _instance ?? (_instance = new Dice());

        public int Roll()
        {
            return _rand.Next(1, 7);
        }
    }
}
