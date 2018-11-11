using System;

namespace Exercise_4
{
    class Enemy
    {
        public int damage = 20;        
    }
    class Player
    {
        public void Shout(String str)
        {
            System.Console.WriteLine(str);
        }
        public void Shout(int number)
        {
            System.Console.WriteLine(number + " is my lucky number!");
        }
        public void Shout(Enemy enm)
        {
            System.Console.WriteLine("The enemy can do " + enm.damage + " damage to me!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Player plr = new Player();
           Enemy enm = new Enemy();
           plr.Shout("Never should have come here");
           plr.Shout(5);
           plr.Shout(enm);
        }
    }
}
