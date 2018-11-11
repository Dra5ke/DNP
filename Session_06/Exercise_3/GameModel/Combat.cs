using System;

namespace GameModel
{
    public class Combat
    {
        /*
         * Two Heroes battle until a winner is found.
         */
        public void Battle(Hero hero1, Hero hero2)
        {
            var attacking = hero1;
            var defending = hero2;

            if (FlipCoin())
            {
                swap(attacking, defending);
            }

            while (attacking.IsAlive() && defending.IsAlive())
            {
                defending.Defend(attacking);
                swap(attacking, defending);
            }
        }

        private void swap(Hero attacking, Hero defending)
        {
            var temp = attacking;
            attacking = defending;
            defending = temp;
        }

        /* 
         * The attacking hero gets to attack first, and will
         * get an extra attack if 20 is rolled.
         */
        public void Ambush(Hero attacking, Hero defending)
        {

            if (RollDice(20) == 20)
            {
                defending.Defend(attacking);
            }

            while (attacking.IsAlive() && defending.IsAlive())
            {
                defending.Defend(attacking);
                swap(attacking, defending);
            }
        }

        /*
         * The attacking hero will succesfully deal damage without
         * getting hit if a 6'er is rolled.
         */
        public void HitAndRun(Hero attacking, Hero defending)
        {
            if (RollDice(6) == 6)
            {
                defending.Defend(attacking);
            }
        }

        private bool FlipCoin()
        {
            var rnd = new Random();
            return (rnd.Next(2) == 0);
        }

        private int RollDice(int sides)
        {
            var rnd = new Random();
            return rnd.Next(sides) + 1;
        }
    }
}